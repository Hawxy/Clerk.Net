using System.Reflection;
using Microsoft.Kiota.Http.HttpClientLibrary.Middleware.Options;

namespace Clerk.Net;

/// <summary>
/// Contains default configuration overrides for the Kiota handler pipeline.
/// </summary>
public static class KiotaHandlerConfiguration
{
    /// <summary>
    /// Overrides for Kiota's user agent handler.
    /// </summary>
    public static readonly UserAgentHandlerOption UserAgentHandlerOption = new UserAgentHandlerOption()
    {
        ProductName = "Clerk.Net",
        ProductVersion = GetVersion()
    };

    private static string GetVersion()
    {
        var assemblyVersion = typeof(KiotaHandlerConfiguration).Assembly
            .GetCustomAttribute<AssemblyInformationalVersionAttribute>()!
            .InformationalVersion;

        return assemblyVersion.Contains('+') 
            ? assemblyVersion.Split('+')[0] 
            : assemblyVersion;
    }
}