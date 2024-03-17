// <auto-generated/>
using Clerk.Net.Client.Models;
using Clerk.Net.Client.Users.Count;
using Clerk.Net.Client.Users.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Clerk.Net.Client.Users {
    /// <summary>
    /// Builds and executes requests for operations under \users
    /// </summary>
    public class UsersRequestBuilder : BaseRequestBuilder {
        /// <summary>The count property</summary>
        public CountRequestBuilder Count { get =>
            new CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Clerk.Net.Client.users.item collection</summary>
        /// <param name="position">The ID of the user to retrieve</param>
        public WithUser_ItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("user_id", position);
            return new WithUser_ItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new UsersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users{?email_address*,external_id*,last_active_at_since*,limit*,offset*,order_by*,organization_id*,phone_number*,query*,username*,user_id*,web3_wallet*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new UsersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users{?email_address*,external_id*,last_active_at_since*,limit*,offset*,order_by*,organization_id*,phone_number*,query*,username*,user_id*,web3_wallet*}", rawUrl) {
        }
        /// <summary>
        /// Returns a list of all users.The users are returned sorted by creation date, with the newest users appearing first.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<User>?> GetAsync(Action<RequestConfiguration<UsersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<User>> GetAsync(Action<RequestConfiguration<UsersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"400", ClerkErrors.CreateFromDiscriminatorValue},
                {"401", ClerkErrors.CreateFromDiscriminatorValue},
                {"422", ClerkErrors.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<User>(requestInfo, User.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Creates a new user. Your user management settings determine how you should setup your user model.Any email address and phone number created using this method will be marked as verified.Note: If you are performing a migration, check out our guide on [zero downtime migrations](https://clerk.com/docs/deployments/migrate-overview).A rate limit rule of 20 requests per 10 seconds is applied to this endpoint.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<User?> PostAsync(UsersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<User> PostAsync(UsersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"400", ClerkErrors.CreateFromDiscriminatorValue},
                {"401", ClerkErrors.CreateFromDiscriminatorValue},
                {"403", ClerkErrors.CreateFromDiscriminatorValue},
                {"422", ClerkErrors.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<User>(requestInfo, User.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a list of all users.The users are returned sorted by creation date, with the newest users appearing first.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<UsersRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<UsersRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates a new user. Your user management settings determine how you should setup your user model.Any email address and phone number created using this method will be marked as verified.Note: If you are performing a migration, check out our guide on [zero downtime migrations](https://clerk.com/docs/deployments/migrate-overview).A rate limit rule of 20 requests per 10 seconds is applied to this endpoint.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(UsersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(UsersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
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
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public UsersRequestBuilder WithUrl(string rawUrl) {
            return new UsersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a list of all users.The users are returned sorted by creation date, with the newest users appearing first.
        /// </summary>
        public class UsersRequestBuilderGetQueryParameters {
            /// <summary>Returns users with the specified email addresses.Accepts up to 100 email addresses.Any email addresses not found are ignored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("email_address")]
            public string[]? EmailAddress { get; set; }
#nullable restore
#else
            [QueryParameter("email_address")]
            public string[] EmailAddress { get; set; }
#endif
            /// <summary>Returns users with the specified external ids.For each external id, the `+` and `-` can beprepended to the id, which denote whether therespective external id should be included orexcluded from the result set.Accepts up to 100 external ids.Any external ids not found are ignored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("external_id")]
            public string[]? ExternalId { get; set; }
#nullable restore
#else
            [QueryParameter("external_id")]
            public string[] ExternalId { get; set; }
#endif
            /// <summary>Returns users that had session activity since the given date, with day precision.Providing a value with higher precision than day will result in an error.Example: use 1700690400000 to retrieve users that had session activity from 2023-11-23 until the current day.</summary>
            [QueryParameter("last_active_at_since")]
            public int? LastActiveAtSince { get; set; }
            /// <summary>Applies a limit to the number of results returned.Can be used for paginating the results together with `offset`.Must be an integer greater than zero and less than 500.By default, if not supplied, a limit of 10 is used.</summary>
            [QueryParameter("limit")]
            public double? Limit { get; set; }
            /// <summary>Skip the first `offset` results when paginating.Needs to be an integer greater or equal to zero.To be used in conjunction with `limit`.</summary>
            [QueryParameter("offset")]
            public double? Offset { get; set; }
            /// <summary>Allows to return users in a particular order.At the moment, you can order the returned users by their `created_at`,`updated_at`,`email_address`,`web3wallet`,`first_name`,`last_name`,`phone_number`,`username`,`last_active_at`,`last_sign_in_at`.In order to specify the direction, you can use the `+/-` symbols prepended in the property to order by.For example, if you want users to be returned in descending order according to their `created_at` property, you can use `-created_at`.If you don&apos;t use `+` or `-`, then `+` is implied. We only support one `order_by` parameter, and if multiple `order_by` parameters are provided, we will only keep the first one. For example,if you pass `order_by=username&amp;order_by=created_at`, we will consider only the first `order_by` parameter, which is `username`. The `created_at` parameter will be ignored in this case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("order_by")]
            public string? OrderBy { get; set; }
#nullable restore
#else
            [QueryParameter("order_by")]
            public string OrderBy { get; set; }
#endif
            /// <summary>Returns users that have memberships to thegiven organizations.For each organization id, the `+` and `-` can beprepended to the id, which denote whether therespective organization should be included orexcluded from the result set.Accepts up to 100 organization ids.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("organization_id")]
            public string[]? OrganizationId { get; set; }
#nullable restore
#else
            [QueryParameter("organization_id")]
            public string[] OrganizationId { get; set; }
#endif
            /// <summary>Returns users with the specified phone numbers.Accepts up to 100 phone numbers.Any phone numbers not found are ignored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("phone_number")]
            public string[]? PhoneNumber { get; set; }
#nullable restore
#else
            [QueryParameter("phone_number")]
            public string[] PhoneNumber { get; set; }
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
            /// <summary>Returns users with the user ids specified.For each user id, the `+` and `-` can beprepended to the id, which denote whether therespective user id should be included orexcluded from the result set.Accepts up to 100 user ids.Any user ids not found are ignored.</summary>
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
