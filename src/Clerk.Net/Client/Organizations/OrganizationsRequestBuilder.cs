// <auto-generated/>
#pragma warning disable CS0618
using Clerk.Net.Client.Models;
using Clerk.Net.Client.Organizations.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Clerk.Net.Client.Organizations
{
    /// <summary>
    /// Builds and executes requests for operations under \organizations
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class OrganizationsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Clerk.Net.Client.organizations.item collection</summary>
        /// <param name="position">The ID or slug of the organization</param>
        /// <returns>A <see cref="global::Clerk.Net.Client.Organizations.Item.WithOrganization_ItemRequestBuilder"/></returns>
        public global::Clerk.Net.Client.Organizations.Item.WithOrganization_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("organization_id", position);
                return new global::Clerk.Net.Client.Organizations.Item.WithOrganization_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Organizations.OrganizationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OrganizationsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/organizations{?include_members_count*,limit*,offset*,order_by*,query*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Organizations.OrganizationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OrganizationsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/organizations{?include_members_count*,limit*,offset*,order_by*,query*}", rawUrl)
        {
        }
        /// <summary>
        /// This request returns the list of organizations for an instance.Results can be paginated using the optional `limit` and `offset` query parameters.The organizations are ordered by descending creation date.Most recent organizations will be returned first.
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Models.Organizations"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 400 status code</exception>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 403 status code</exception>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Clerk.Net.Client.Models.Organizations?> GetAsync(Action<RequestConfiguration<global::Clerk.Net.Client.Organizations.OrganizationsRequestBuilder.OrganizationsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Clerk.Net.Client.Models.Organizations> GetAsync(Action<RequestConfiguration<global::Clerk.Net.Client.Organizations.OrganizationsRequestBuilder.OrganizationsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
                { "403", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
                { "422", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Clerk.Net.Client.Models.Organizations>(requestInfo, global::Clerk.Net.Client.Models.Organizations.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a new organization with the given name for an instance.In order to successfully create an organization you need to provide the ID of the User who will become the organization administrator.You can specify an optional slug for the new organization.If provided, the organization slug can contain only lowercase alphanumeric characters (letters and digits) and the dash &quot;-&quot;.Organization slugs must be unique for the instance.You can provide additional metadata for the organization and set any custom attribute you want.Organizations support private and public metadata.Private metadata can only be accessed from the Backend API.Public metadata can be accessed from the Backend API, and are read-only from the Frontend API.The `created_by` user will see this as their [active organization] (https://clerk.com/docs/organizations/overview#active-organization)the next time they create a session, presuming they don&apos;t explicitly set a different organization as active before then.
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Models.Organization"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 400 status code</exception>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 403 status code</exception>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Clerk.Net.Client.Models.Organization?> PostAsync(global::Clerk.Net.Client.Organizations.OrganizationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Clerk.Net.Client.Models.Organization> PostAsync(global::Clerk.Net.Client.Organizations.OrganizationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
                { "403", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
                { "422", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Clerk.Net.Client.Models.Organization>(requestInfo, global::Clerk.Net.Client.Models.Organization.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// This request returns the list of organizations for an instance.Results can be paginated using the optional `limit` and `offset` query parameters.The organizations are ordered by descending creation date.Most recent organizations will be returned first.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Clerk.Net.Client.Organizations.OrganizationsRequestBuilder.OrganizationsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Clerk.Net.Client.Organizations.OrganizationsRequestBuilder.OrganizationsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates a new organization with the given name for an instance.In order to successfully create an organization you need to provide the ID of the User who will become the organization administrator.You can specify an optional slug for the new organization.If provided, the organization slug can contain only lowercase alphanumeric characters (letters and digits) and the dash &quot;-&quot;.Organization slugs must be unique for the instance.You can provide additional metadata for the organization and set any custom attribute you want.Organizations support private and public metadata.Private metadata can only be accessed from the Backend API.Public metadata can be accessed from the Backend API, and are read-only from the Frontend API.The `created_by` user will see this as their [active organization] (https://clerk.com/docs/organizations/overview#active-organization)the next time they create a session, presuming they don&apos;t explicitly set a different organization as active before then.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Clerk.Net.Client.Organizations.OrganizationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Clerk.Net.Client.Organizations.OrganizationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Organizations.OrganizationsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Clerk.Net.Client.Organizations.OrganizationsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Clerk.Net.Client.Organizations.OrganizationsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// This request returns the list of organizations for an instance.Results can be paginated using the optional `limit` and `offset` query parameters.The organizations are ordered by descending creation date.Most recent organizations will be returned first.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class OrganizationsRequestBuilderGetQueryParameters 
        {
            /// <summary>Flag to denote whether the member counts of each organization should be included in the response or not.</summary>
            [QueryParameter("include_members_count")]
            public bool? IncludeMembersCount { get; set; }
            /// <summary>Applies a limit to the number of results returned.Can be used for paginating the results together with `offset`.</summary>
            [QueryParameter("limit")]
            public double? Limit { get; set; }
            /// <summary>Skip the first `offset` results when paginating.Needs to be an integer greater or equal to zero.To be used in conjunction with `limit`.</summary>
            [QueryParameter("offset")]
            public double? Offset { get; set; }
            /// <summary>Allows to return organizations in a particular order.At the moment, you can order the returned organizations either by their `name`, `created_at` or `members_count`.In order to specify the direction, you can use the `+/-` symbols prepended in the property to order by.For example, if you want organizations to be returned in descending order according to their `created_at` property, you can use `-created_at`.If you don&apos;t use `+` or `-`, then `+` is implied.Defaults to `-created_at`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("order_by")]
            public string? OrderBy { get; set; }
#nullable restore
#else
            [QueryParameter("order_by")]
            public string OrderBy { get; set; }
#endif
            /// <summary>Returns organizations with ID, name, or slug that match the given query.Uses exact match for organization ID and partial match for name and slug.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("query")]
            public string? Query { get; set; }
#nullable restore
#else
            [QueryParameter("query")]
            public string Query { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
