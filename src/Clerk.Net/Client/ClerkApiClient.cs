// <auto-generated/>
#pragma warning disable CS0618
using Clerk.Net.Client.Accountless_applications;
using Clerk.Net.Client.Actor_tokens;
using Clerk.Net.Client.Allowlist_identifiers;
using Clerk.Net.Client.Aws_credentials;
using Clerk.Net.Client.Beta_features;
using Clerk.Net.Client.Blocklist_identifiers;
using Clerk.Net.Client.Clients;
using Clerk.Net.Client.Domains;
using Clerk.Net.Client.Email_addresses;
using Clerk.Net.Client.Instance;
using Clerk.Net.Client.Invitations;
using Clerk.Net.Client.Jwks;
using Clerk.Net.Client.Jwt_templates;
using Clerk.Net.Client.Machine_tokens;
using Clerk.Net.Client.Management;
using Clerk.Net.Client.Oauth_applications;
using Clerk.Net.Client.Organization_invitations;
using Clerk.Net.Client.Organization_memberships;
using Clerk.Net.Client.Organizations;
using Clerk.Net.Client.Phone_numbers;
using Clerk.Net.Client.Proxy_checks;
using Clerk.Net.Client.Public;
using Clerk.Net.Client.Redirect_urls;
using Clerk.Net.Client.Saml_connections;
using Clerk.Net.Client.Sessions;
using Clerk.Net.Client.Sign_in_tokens;
using Clerk.Net.Client.Sign_ups;
using Clerk.Net.Client.Templates;
using Clerk.Net.Client.Testing_tokens;
using Clerk.Net.Client.Users;
using Clerk.Net.Client.Waitlist_entries;
using Clerk.Net.Client.Webhooks;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Multipart;
using Microsoft.Kiota.Serialization.Text;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Clerk.Net.Client
{
    /// <summary>
    /// The main entry point of the SDK, exposes the configuration and the fluent API.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ClerkApiClient : BaseRequestBuilder
    {
        /// <summary>The accountless_applications property</summary>
        public global::Clerk.Net.Client.Accountless_applications.Accountless_applicationsRequestBuilder AccountlessApplications
        {
            get => new global::Clerk.Net.Client.Accountless_applications.Accountless_applicationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The actor_tokens property</summary>
        public global::Clerk.Net.Client.Actor_tokens.Actor_tokensRequestBuilder ActorTokens
        {
            get => new global::Clerk.Net.Client.Actor_tokens.Actor_tokensRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The allowlist_identifiers property</summary>
        public global::Clerk.Net.Client.Allowlist_identifiers.Allowlist_identifiersRequestBuilder AllowlistIdentifiers
        {
            get => new global::Clerk.Net.Client.Allowlist_identifiers.Allowlist_identifiersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The aws_credentials property</summary>
        public global::Clerk.Net.Client.Aws_credentials.Aws_credentialsRequestBuilder AwsCredentials
        {
            get => new global::Clerk.Net.Client.Aws_credentials.Aws_credentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The beta_features property</summary>
        public global::Clerk.Net.Client.Beta_features.Beta_featuresRequestBuilder BetaFeatures
        {
            get => new global::Clerk.Net.Client.Beta_features.Beta_featuresRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The blocklist_identifiers property</summary>
        public global::Clerk.Net.Client.Blocklist_identifiers.Blocklist_identifiersRequestBuilder BlocklistIdentifiers
        {
            get => new global::Clerk.Net.Client.Blocklist_identifiers.Blocklist_identifiersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The clients property</summary>
        public global::Clerk.Net.Client.Clients.ClientsRequestBuilder Clients
        {
            get => new global::Clerk.Net.Client.Clients.ClientsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The domains property</summary>
        public global::Clerk.Net.Client.Domains.DomainsRequestBuilder Domains
        {
            get => new global::Clerk.Net.Client.Domains.DomainsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The email_addresses property</summary>
        public global::Clerk.Net.Client.Email_addresses.Email_addressesRequestBuilder EmailAddresses
        {
            get => new global::Clerk.Net.Client.Email_addresses.Email_addressesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The instance property</summary>
        public global::Clerk.Net.Client.Instance.InstanceRequestBuilder Instance
        {
            get => new global::Clerk.Net.Client.Instance.InstanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The invitations property</summary>
        public global::Clerk.Net.Client.Invitations.InvitationsRequestBuilder Invitations
        {
            get => new global::Clerk.Net.Client.Invitations.InvitationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The jwks property</summary>
        public global::Clerk.Net.Client.Jwks.JwksRequestBuilder Jwks
        {
            get => new global::Clerk.Net.Client.Jwks.JwksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The jwt_templates property</summary>
        public global::Clerk.Net.Client.Jwt_templates.Jwt_templatesRequestBuilder JwtTemplates
        {
            get => new global::Clerk.Net.Client.Jwt_templates.Jwt_templatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The machine_tokens property</summary>
        public global::Clerk.Net.Client.Machine_tokens.Machine_tokensRequestBuilder MachineTokens
        {
            get => new global::Clerk.Net.Client.Machine_tokens.Machine_tokensRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The management property</summary>
        public global::Clerk.Net.Client.Management.ManagementRequestBuilder Management
        {
            get => new global::Clerk.Net.Client.Management.ManagementRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The oauth_applications property</summary>
        public global::Clerk.Net.Client.Oauth_applications.Oauth_applicationsRequestBuilder OauthApplications
        {
            get => new global::Clerk.Net.Client.Oauth_applications.Oauth_applicationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The organization_invitations property</summary>
        public global::Clerk.Net.Client.Organization_invitations.Organization_invitationsRequestBuilder OrganizationInvitations
        {
            get => new global::Clerk.Net.Client.Organization_invitations.Organization_invitationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The organization_memberships property</summary>
        public global::Clerk.Net.Client.Organization_memberships.Organization_membershipsRequestBuilder OrganizationMemberships
        {
            get => new global::Clerk.Net.Client.Organization_memberships.Organization_membershipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The organizations property</summary>
        public global::Clerk.Net.Client.Organizations.OrganizationsRequestBuilder Organizations
        {
            get => new global::Clerk.Net.Client.Organizations.OrganizationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The phone_numbers property</summary>
        public global::Clerk.Net.Client.Phone_numbers.Phone_numbersRequestBuilder PhoneNumbers
        {
            get => new global::Clerk.Net.Client.Phone_numbers.Phone_numbersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The proxy_checks property</summary>
        public global::Clerk.Net.Client.Proxy_checks.Proxy_checksRequestBuilder ProxyChecks
        {
            get => new global::Clerk.Net.Client.Proxy_checks.Proxy_checksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The public property</summary>
        public global::Clerk.Net.Client.Public.PublicRequestBuilder Public
        {
            get => new global::Clerk.Net.Client.Public.PublicRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The redirect_urls property</summary>
        public global::Clerk.Net.Client.Redirect_urls.Redirect_urlsRequestBuilder RedirectUrls
        {
            get => new global::Clerk.Net.Client.Redirect_urls.Redirect_urlsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The saml_connections property</summary>
        public global::Clerk.Net.Client.Saml_connections.Saml_connectionsRequestBuilder SamlConnections
        {
            get => new global::Clerk.Net.Client.Saml_connections.Saml_connectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sessions property</summary>
        public global::Clerk.Net.Client.Sessions.SessionsRequestBuilder Sessions
        {
            get => new global::Clerk.Net.Client.Sessions.SessionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sign_in_tokens property</summary>
        public global::Clerk.Net.Client.Sign_in_tokens.Sign_in_tokensRequestBuilder SignInTokens
        {
            get => new global::Clerk.Net.Client.Sign_in_tokens.Sign_in_tokensRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sign_ups property</summary>
        public global::Clerk.Net.Client.Sign_ups.Sign_upsRequestBuilder SignUps
        {
            get => new global::Clerk.Net.Client.Sign_ups.Sign_upsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The templates property</summary>
        public global::Clerk.Net.Client.Templates.TemplatesRequestBuilder Templates
        {
            get => new global::Clerk.Net.Client.Templates.TemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The testing_tokens property</summary>
        public global::Clerk.Net.Client.Testing_tokens.Testing_tokensRequestBuilder TestingTokens
        {
            get => new global::Clerk.Net.Client.Testing_tokens.Testing_tokensRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The users property</summary>
        public global::Clerk.Net.Client.Users.UsersRequestBuilder Users
        {
            get => new global::Clerk.Net.Client.Users.UsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The waitlist_entries property</summary>
        public global::Clerk.Net.Client.Waitlist_entries.Waitlist_entriesRequestBuilder WaitlistEntries
        {
            get => new global::Clerk.Net.Client.Waitlist_entries.Waitlist_entriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The webhooks property</summary>
        public global::Clerk.Net.Client.Webhooks.WebhooksRequestBuilder Webhooks
        {
            get => new global::Clerk.Net.Client.Webhooks.WebhooksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.ClerkApiClient"/> and sets the default values.
        /// </summary>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ClerkApiClient(IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}", new Dictionary<string, object>())
        {
            ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<TextSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<FormSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<MultipartSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<TextParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<FormParseNodeFactory>();
            if (string.IsNullOrEmpty(RequestAdapter.BaseUrl))
            {
                RequestAdapter.BaseUrl = "https://api.clerk.com/v1";
            }
            PathParameters.TryAdd("baseurl", RequestAdapter.BaseUrl);
        }
    }
}
#pragma warning restore CS0618
