using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CaseConverter;
using Nuke.Common;
using Nuke.Common.CI.GitHubActions;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Serilog;
using static Nuke.Common.Tools.DotNet.DotNetTasks;


[GitHubActions(
    "Build & Test",
    GitHubActionsImage.UbuntuLatest,
    OnPushBranches = ["main"],
    OnPullRequestBranches = ["main"],
    InvokedTargets = [nameof(Test)],
    ImportSecrets = [nameof(ClerkAuthority), nameof(ClerkSecretKey)])]
[GitHubActions(
    "Manual Nuget Push",
    GitHubActionsImage.UbuntuLatest,
    On = [GitHubActionsTrigger.WorkflowDispatch],
    InvokedTargets = [nameof(NugetPush)],
    ImportSecrets = [nameof(NugetApiKey)])]
partial class Build : NukeBuild
{
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode

    public static int Main() => Execute<Build>(x => x.Compile);

    [Solution(GenerateProjects = true)] readonly Solution Solution;

    [NuGetPackage("Microsoft.OpenApi.Kiota", "kiota.dll")] readonly Tool Kiota;
    AbsolutePath ArtifactsDirectory => RootDirectory / "artifacts";

    Target Clean => _ => _
        .Before(Restore)
        .Executes(() =>
        {
            ArtifactsDirectory.CreateOrCleanDirectory();
        });

    Target Restore => _ => _
        .DependsOn(Clean)
        .Executes(() =>
        {
            DotNetRestore(s => s
                .SetProjectFile(Solution));
        });

    Target Compile => _ => _
        .DependsOn(Restore)
        .Executes(() =>
        {
            DotNetBuild(s => s
                .SetProjectFile(Solution)
                .SetConfiguration("Release")
                .EnableNoRestore());
        });
    
    [Parameter("Clerk Authority")][Secret] readonly string ClerkAuthority;
    [Parameter("Clerk Secret Key")][Secret] readonly string ClerkSecretKey;

    Target Test => _ => _
        .DependsOn(Compile)
        .Executes(() =>
        {
            DotNetTest(s => s
                .SetProjectFile(Solution.Clerk_Net_Tests));

            DotNetTest(s => s
                .SetProjectFile(Solution.Clerk_Net_AspNetCore_Security)
                .AddProcessEnvironmentVariable("CLERK__AUTHORITY", ClerkAuthority)
                .AddProcessEnvironmentVariable("CLERK__SECRETKEY", ClerkSecretKey));
        });

    Target NugetPack => _ => _
        .DependsOn(Compile)
        .Executes(() =>
        {
            DotNetPack(_ => _
                .SetProject(Solution.Clerk_Net)
                .SetConfiguration("Release")
                .EnableContinuousIntegrationBuild()
                .SetOutputDirectory(ArtifactsDirectory));

            DotNetPack(_ => _
                .SetProject(Solution.Clerk_Net_DependencyInjection)
                .SetConfiguration("Release")
                .EnableContinuousIntegrationBuild()
                .SetOutputDirectory(ArtifactsDirectory));
            
            DotNetPack(_ => _
                .SetProject(Solution.Clerk_Net_AspNetCore_Security)
                .SetConfiguration("Release")
                .EnableContinuousIntegrationBuild()
                .SetOutputDirectory(ArtifactsDirectory));
        });

    [Parameter("Nuget Api Key")] [Secret] readonly string NugetApiKey;

    Target NugetPush => _ => _
        .DependsOn(NugetPack)
        .Requires(() => !string.IsNullOrEmpty(NugetApiKey))
        .Executes(() =>
        {
            DotNetNuGetPush(_ => _
                .SetSource("https://api.nuget.org/v3/index.json")
                .SetTargetPath(ArtifactsDirectory / "*.nupkg")
                .EnableSkipDuplicate()
                .EnableNoSymbols()
                .SetApiKey(NugetApiKey));
        });
    
    Target Update => _ => _
        .Requires(() => Kiota) 
        .Triggers(PostProcess)
        .Executes(async () =>
        {
            using var client = new HttpClient();

            var swagger =
                await client.GetStringAsync(
                    "https://raw.githubusercontent.com/clerk/openapi-specs/refs/heads/main/bapi/2024-10-01.yml");
            
            var projectDir = Solution.Clerk_Net.Directory;

            await File.WriteAllTextAsync(projectDir / "swagger.yml", swagger);

            Kiota(workingDirectory: projectDir, arguments: $"update -o {projectDir / "Client"} --clean-output");

        });

    
    // We do a little bit of cleanup to fix some builder paths output as snake_Case. This is temporary and won't be needed with Kiota 2.0
    Target PostProcess => _ => _
        .Executes(async () =>
        {
            var dir = Solution.Clerk_Net.Directory / "Client";

            static async Task ProcessFile(string file)
            {
                var data = await File.ReadAllTextAsync(file);
                var output = FindBuilder().Replace(data, match => match.Value.ToPascalCase());
                await File.WriteAllTextAsync(file, output);
            }

            foreach (var file in Directory.EnumerateFiles(dir, "*Builder.cs", SearchOption.AllDirectories))
            {
                Log.Information("Formatting {File}", file);
                await ProcessFile(file);
            }

            await ProcessFile(dir / "ClerkApiClient.cs");

        });

   [GeneratedRegex("""(?<=\bglobal\S*::\S*\s)[a-zA-Z]+(?:_[a-zA-Z]+)+\b""")]
   private static partial Regex FindBuilder();
}
    
    
