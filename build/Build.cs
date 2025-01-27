using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.Playwright;
using Nuke.Common;
using Nuke.Common.CI;
using Nuke.Common.CI.GitHubActions;
using Nuke.Common.Execution;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Utilities.Collections;
using static Nuke.Common.EnvironmentInfo;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;
using static Nuke.Common.Tools.DotNet.DotNetTasks;


[GitHubActions(
    "Build & Test",
    GitHubActionsImage.UbuntuLatest,
    OnPushBranches = ["main"],
    OnPullRequestBranches = ["main"],
    InvokedTargets = [nameof(Test)])]
[GitHubActions(
    "Manual Nuget Push",
    GitHubActionsImage.UbuntuLatest,
    On = [GitHubActionsTrigger.WorkflowDispatch],
    InvokedTargets = [nameof(NugetPush)],
    ImportSecrets = [nameof(NugetApiKey)])]
class Build : NukeBuild
{
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode

    public static int Main () => Execute<Build>(x => x.Compile);

    [Solution(GenerateProjects = true)] readonly Solution Solution;

    [NuGetPackage("Microsoft.OpenApi.Kiota", "kiota.dll")]
    readonly Tool Kiota;
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
    
    Target Test => _ => _
        .DependsOn(Compile)
        .Executes(() =>
        {
            DotNetTest(s => s
                .SetProjectFile(Solution.Clerk_Net_Tests));
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
        .Executes(async () =>
        {
            // swagger URL is a client-side blob...
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions() {Channel = "msedge"});
            
            var page = await browser.NewPageAsync();
            await page.GotoAsync("https://clerk.com/docs/reference/backend-api");

            var downloadTask = page.WaitForDownloadAsync();
            await page.GetByRole(AriaRole.Link, new PageGetByRoleOptions() { Name = "Download" }).ClickAsync();
            var download = await downloadTask;

            var projectDir = Solution.Clerk_Net.Directory;
            await download.SaveAsAsync($"{projectDir}/swagger.json");
            
            Kiota(workingDirectory: projectDir, arguments: $"update -o {projectDir / "Client"} --clean-output");
            
        });
}
