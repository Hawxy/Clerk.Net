using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace Clerk.Net.AspNetCore.Security;

/// <summary>
/// Extensions used to register Clerk authentication with ASP.NET Core
/// </summary>
public static class ClerkAuthenticationExtensions
{
    /// <summary>
    /// Adds Clerk authentication to the environment.
    /// </summary>
    /// <param name="builder">An instance of <see cref="AuthenticationBuilder"/></param>
    /// <param name="options">The configuration options.</param>
    /// <returns>An instance of <see cref="AuthenticationBuilder"/></returns>
    /// <exception cref="InvalidOperationException">Thrown if validation of the configuration object does not pass.</exception>
    public static AuthenticationBuilder AddClerkAuthentication(this AuthenticationBuilder builder, Action<ClerkAuthenticationOptions> options)
    {
        return builder.AddClerkAuthentication(ClerkAuthenticationDefaults.AuthenticationScheme, options);
    }

    /// <summary>
    /// Adds Clerk authentication to the environment.
    /// </summary>
    /// <param name="builder">An instance of <see cref="AuthenticationBuilder"/></param>
    /// <param name="authenticationScheme">A custom scheme.</param>
    /// <param name="options">The configuration options.</param>
    /// <returns>An instance of <see cref="AuthenticationBuilder"/></returns>
    /// <exception cref="InvalidOperationException">Thrown if validation of the configuration object does not pass.</exception>
    public static AuthenticationBuilder AddClerkAuthentication(this AuthenticationBuilder builder,
        string authenticationScheme, Action<ClerkAuthenticationOptions> options)
    {
        ArgumentNullException.ThrowIfNull(options);

        var optionsObj = new ClerkAuthenticationOptions();
        options.Invoke(optionsObj);

        if (string.IsNullOrEmpty(optionsObj.Authority))
            throw new InvalidOperationException("Clerk Authority cannot be empty or null");

        return builder.AddJwtBearer(authenticationScheme, x =>
        {
            x.Authority = optionsObj.Authority;
            x.TokenValidationParameters = new TokenValidationParameters()
            {
                ValidateAudience = false,
                NameClaimType = ClaimTypes.NameIdentifier
            };
            x.Events = new JwtBearerEvents()
            {
                // Additional validation for AZP claim
                // NOTE: Validation will succeed if neither AuthorizedParty nor AuthorizedParties is set
                OnTokenValidated = context =>
                {
                    var azp = context.Principal?.FindFirstValue("azp");

                    if (string.IsNullOrEmpty(azp))
                    {
                        context.Fail("AZP Claim is missing");
                    }

                    // OBSOLETE: Check single AuthorizedParty
                    if (!string.IsNullOrEmpty(optionsObj.AuthorizedParty))
                    {
                        if (azp != optionsObj.AuthorizedParty)
                        {
                            context.Fail("AZP Claim does not match the authorized party");
                        }
                    }

                    // Check multiple AuthorizedParties
                    if (optionsObj.AuthorizedParties != null &&
                        optionsObj.AuthorizedParties.Count > 0)
                    {
                        if (!optionsObj.AuthorizedParties.Contains(azp))
                        {
                            context.Fail("AZP Claim is not in the list of authorized parties");
                        }
                    }

                    return Task.CompletedTask;
                },
                OnMessageReceived = context =>
                {
                    context.Token = context.Request.Cookies["__session"];

                    return Task.CompletedTask;
                }
            };
        });
    }
}