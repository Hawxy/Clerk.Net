// <auto-generated/>
#pragma warning disable CS0618
using Clerk.Net.Client.Models;
using Clerk.Net.Client.Organizations.Item.Memberships.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Clerk.Net.Client.Organizations.Item.Memberships
{
    /// <summary>
    /// Builds and executes requests for operations under \organizations\{organization_id}\memberships
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MembershipsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Clerk.Net.Client.organizations.item.memberships.item collection</summary>
        /// <param name="position">The ID of the user that this membership belongs to</param>
        /// <returns>A <see cref="global::Clerk.Net.Client.Organizations.Item.Memberships.Item.WithUser_ItemRequestBuilder"/></returns>
        public global::Clerk.Net.Client.Organizations.Item.Memberships.Item.WithUser_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("user_id", position);
                return new global::Clerk.Net.Client.Organizations.Item.Memberships.Item.WithUser_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Organizations.Item.Memberships.MembershipsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MembershipsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/organizations/{organization_id}/memberships{?created_at_after*,created_at_before*,email_address*,email_address_query*,last_active_at_after*,last_active_at_before*,limit*,name_query*,offset*,order_by*,phone_number*,phone_number_query*,query*,role*,user_id*,username*,username_query*,web3_wallet*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Organizations.Item.Memberships.MembershipsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MembershipsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/organizations/{organization_id}/memberships{?created_at_after*,created_at_before*,email_address*,email_address_query*,last_active_at_after*,last_active_at_before*,limit*,name_query*,offset*,order_by*,phone_number*,phone_number_query*,query*,role*,user_id*,username*,username_query*,web3_wallet*}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieves all user memberships for the given organization
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Models.OrganizationMemberships"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 401 status code</exception>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Clerk.Net.Client.Models.OrganizationMemberships?> GetAsync(Action<RequestConfiguration<global::Clerk.Net.Client.Organizations.Item.Memberships.MembershipsRequestBuilder.MembershipsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Clerk.Net.Client.Models.OrganizationMemberships> GetAsync(Action<RequestConfiguration<global::Clerk.Net.Client.Organizations.Item.Memberships.MembershipsRequestBuilder.MembershipsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
                { "422", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Clerk.Net.Client.Models.OrganizationMemberships>(requestInfo, global::Clerk.Net.Client.Models.OrganizationMemberships.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Adds a user as a member to the given organization.Only users in the same instance as the organization can be added as members.This organization will be the user&apos;s [active organization] (https://clerk.com/docs/organizations/overview#active-organization)the next time they create a session, presuming they don&apos;t explicitly set adifferent organization as active before then.
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Models.OrganizationMembership"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 400 status code</exception>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 403 status code</exception>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 404 status code</exception>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Clerk.Net.Client.Models.OrganizationMembership?> PostAsync(global::Clerk.Net.Client.Organizations.Item.Memberships.MembershipsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Clerk.Net.Client.Models.OrganizationMembership> PostAsync(global::Clerk.Net.Client.Organizations.Item.Memberships.MembershipsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
                { "403", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
                { "404", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
                { "422", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Clerk.Net.Client.Models.OrganizationMembership>(requestInfo, global::Clerk.Net.Client.Models.OrganizationMembership.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieves all user memberships for the given organization
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Clerk.Net.Client.Organizations.Item.Memberships.MembershipsRequestBuilder.MembershipsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Clerk.Net.Client.Organizations.Item.Memberships.MembershipsRequestBuilder.MembershipsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Adds a user as a member to the given organization.Only users in the same instance as the organization can be added as members.This organization will be the user&apos;s [active organization] (https://clerk.com/docs/organizations/overview#active-organization)the next time they create a session, presuming they don&apos;t explicitly set adifferent organization as active before then.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Clerk.Net.Client.Organizations.Item.Memberships.MembershipsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Clerk.Net.Client.Organizations.Item.Memberships.MembershipsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Clerk.Net.Client.Organizations.Item.Memberships.MembershipsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Clerk.Net.Client.Organizations.Item.Memberships.MembershipsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Clerk.Net.Client.Organizations.Item.Memberships.MembershipsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieves all user memberships for the given organization
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class MembershipsRequestBuilderGetQueryParameters 
        {
            /// <summary>Returns users who have been created after the given date (with millisecond precision).Example: use 1730160000000 to retrieve users who have been created after 2024-10-29.</summary>
            [QueryParameter("created_at_after")]
            public int? CreatedAtAfter { get; set; }
            /// <summary>Returns users who have been created before the given date (with millisecond precision).Example: use 1730160000000 to retrieve users who have been created before 2024-10-29.</summary>
            [QueryParameter("created_at_before")]
            public int? CreatedAtBefore { get; set; }
            /// <summary>Returns users with the specified email addresses. Accepts up to 100 email addresses. Any email addresses not found are ignored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("email_address")]
            public string[]? EmailAddress { get; set; }
#nullable restore
#else
            [QueryParameter("email_address")]
            public string[] EmailAddress { get; set; }
#endif
            /// <summary>Returns users with emails that match the given query, via case-insensitive partial match.For example, `email_address_query=ello` will match a user with the email `HELLO@example.com`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("email_address_query")]
            public string? EmailAddressQuery { get; set; }
#nullable restore
#else
            [QueryParameter("email_address_query")]
            public string EmailAddressQuery { get; set; }
#endif
            /// <summary>Returns users whose last session activity was after the given date (with millisecond precision).Example: use 1700690400000 to retrieve users whose last session activity was after 2023-11-23.</summary>
            [QueryParameter("last_active_at_after")]
            public int? LastActiveAtAfter { get; set; }
            /// <summary>Returns users whose last session activity was before the given date (with millisecond precision).Example: use 1700690400000 to retrieve users whose last session activity was before 2023-11-23.</summary>
            [QueryParameter("last_active_at_before")]
            public int? LastActiveAtBefore { get; set; }
            /// <summary>Applies a limit to the number of results returned.Can be used for paginating the results together with `offset`.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>Returns users with names that match the given query, via case-insensitive partial match.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("name_query")]
            public string? NameQuery { get; set; }
#nullable restore
#else
            [QueryParameter("name_query")]
            public string NameQuery { get; set; }
#endif
            /// <summary>Skip the first `offset` results when paginating.Needs to be an integer greater or equal to zero.To be used in conjunction with `limit`.</summary>
            [QueryParameter("offset")]
            public int? Offset { get; set; }
            /// <summary>Sorts organizations memberships by phone_number, email_address, created_at, first_name, last_name or username.By prepending one of those values with + or -, we can choose to sort in ascending (ASC) or descending (DESC) order.&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("order_by")]
            public string? OrderBy { get; set; }
#nullable restore
#else
            [QueryParameter("order_by")]
            public string OrderBy { get; set; }
#endif
            /// <summary>Returns users with the specified phone numbers. Accepts up to 100 phone numbers. Any phone numbers not found are ignored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("phone_number")]
            public string[]? PhoneNumber { get; set; }
#nullable restore
#else
            [QueryParameter("phone_number")]
            public string[] PhoneNumber { get; set; }
#endif
            /// <summary>Returns users with phone numbers that match the given query, via case-insensitive partial match.For example, `phone_number_query=555` will match a user with the phone number `+1555xxxxxxx`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("phone_number_query")]
            public string? PhoneNumberQuery { get; set; }
#nullable restore
#else
            [QueryParameter("phone_number_query")]
            public string PhoneNumberQuery { get; set; }
#endif
            /// <summary>Returns users that match the given query.For possible matches, we check the email addresses, phone numbers, usernames, web3 wallets, user ids, first and last names.The query value doesn&apos;t need to match the exact value you are looking for, it is capable of partial matches as well.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("query")]
            public string? Query { get; set; }
#nullable restore
#else
            [QueryParameter("query")]
            public string Query { get; set; }
#endif
            /// <summary>Returns users with the specified roles. Accepts up to 100 roles. Any roles not found are ignored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("role")]
            public string[]? Role { get; set; }
#nullable restore
#else
            [QueryParameter("role")]
            public string[] Role { get; set; }
#endif
            /// <summary>Returns users with the user ids specified. For each user id, the `+` and `-` can beprepended to the id, which denote whether the respective user id should be included orexcluded from the result set. Accepts up to 100 user ids. Any user ids not found are ignored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("user_id")]
            public string[]? UserId { get; set; }
#nullable restore
#else
            [QueryParameter("user_id")]
            public string[] UserId { get; set; }
#endif
            /// <summary>Returns users with the specified usernames.Accepts up to 100 usernames.Any usernames not found are ignored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("username")]
            public string[]? Username { get; set; }
#nullable restore
#else
            [QueryParameter("username")]
            public string[] Username { get; set; }
#endif
            /// <summary>Returns users with usernames that match the given query, via case-insensitive partial match.For example, `username_query=CoolUser` will match a user with the username `SomeCoolUser`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("username_query")]
            public string? UsernameQuery { get; set; }
#nullable restore
#else
            [QueryParameter("username_query")]
            public string UsernameQuery { get; set; }
#endif
            /// <summary>Returns users with the specified web3 wallet addresses.Accepts up to 100 web3 wallet addresses.Any web3 wallet addressed not found are ignored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("web3_wallet")]
            public string[]? Web3Wallet { get; set; }
#nullable restore
#else
            [QueryParameter("web3_wallet")]
            public string[] Web3Wallet { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
