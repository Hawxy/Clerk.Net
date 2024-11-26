// <auto-generated/>
#pragma warning disable CS0618
using Clerk.Net.Client.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Clerk.Net.Client.Users.Count
{
    /// <summary>
    /// Builds and executes requests for operations under \users\count
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CountRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Users.Count.CountRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CountRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/count{?email_address*,email_address_query*,external_id*,phone_number*,phone_number_query*,query*,user_id*,username*,username_query*,web3_wallet*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Users.Count.CountRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CountRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/count{?email_address*,email_address_query*,external_id*,phone_number*,phone_number_query*,query*,user_id*,username*,username_query*,web3_wallet*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns a total count of all users that match the given filtering criteria.
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Models.TotalCount"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Clerk.Net.Client.Models.TotalCount?> GetAsync(Action<RequestConfiguration<global::Clerk.Net.Client.Users.Count.CountRequestBuilder.CountRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Clerk.Net.Client.Models.TotalCount> GetAsync(Action<RequestConfiguration<global::Clerk.Net.Client.Users.Count.CountRequestBuilder.CountRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "422", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Clerk.Net.Client.Models.TotalCount>(requestInfo, global::Clerk.Net.Client.Models.TotalCount.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a total count of all users that match the given filtering criteria.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Clerk.Net.Client.Users.Count.CountRequestBuilder.CountRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Clerk.Net.Client.Users.Count.CountRequestBuilder.CountRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Users.Count.CountRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Clerk.Net.Client.Users.Count.CountRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Clerk.Net.Client.Users.Count.CountRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a total count of all users that match the given filtering criteria.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CountRequestBuilderGetQueryParameters 
        {
            /// <summary>Counts users with the specified email addresses.Accepts up to 100 email addresses.Any email addresses not found are ignored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("email_address")]
            public string[]? EmailAddress { get; set; }
#nullable restore
#else
            [QueryParameter("email_address")]
            public string[] EmailAddress { get; set; }
#endif
            /// <summary>Counts users with emails that match the given query, via case-insensitive partial match.For example, `email_address_query=ello` will match a user with the email `HELLO@example.com`,and will be included in the resulting count.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("email_address_query")]
            public string? EmailAddressQuery { get; set; }
#nullable restore
#else
            [QueryParameter("email_address_query")]
            public string EmailAddressQuery { get; set; }
#endif
            /// <summary>Counts users with the specified external ids.Accepts up to 100 external ids.Any external ids not found are ignored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("external_id")]
            public string[]? ExternalId { get; set; }
#nullable restore
#else
            [QueryParameter("external_id")]
            public string[] ExternalId { get; set; }
#endif
            /// <summary>Counts users with the specified phone numbers.Accepts up to 100 phone numbers.Any phone numbers not found are ignored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("phone_number")]
            public string[]? PhoneNumber { get; set; }
#nullable restore
#else
            [QueryParameter("phone_number")]
            public string[] PhoneNumber { get; set; }
#endif
            /// <summary>Counts users with phone numbers that match the given query, via case-insensitive partial match.For example, `phone_number_query=555` will match a user with the phone number `+1555xxxxxxx`,and will be included in the resulting count.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("phone_number_query")]
            public string? PhoneNumberQuery { get; set; }
#nullable restore
#else
            [QueryParameter("phone_number_query")]
            public string PhoneNumberQuery { get; set; }
#endif
            /// <summary>Counts users that match the given query.For possible matches, we check the email addresses, phone numbers, usernames, web3 wallets, user ids, first and last names.The query value doesn&apos;t need to match the exact value you are looking for, it is capable of partial matches as well.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("query")]
            public string? Query { get; set; }
#nullable restore
#else
            [QueryParameter("query")]
            public string Query { get; set; }
#endif
            /// <summary>Counts users with the user ids specified.Accepts up to 100 user ids.Any user ids not found are ignored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("user_id")]
            public string[]? UserId { get; set; }
#nullable restore
#else
            [QueryParameter("user_id")]
            public string[] UserId { get; set; }
#endif
            /// <summary>Counts users with the specified usernames.Accepts up to 100 usernames.Any usernames not found are ignored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("username")]
            public string[]? Username { get; set; }
#nullable restore
#else
            [QueryParameter("username")]
            public string[] Username { get; set; }
#endif
            /// <summary>Counts users with usernames that match the given query, via case-insensitive partial match.For example, `username_query=CoolUser` will match a user with the username `SomeCoolUser`,and will be included in the resulting count.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("username_query")]
            public string? UsernameQuery { get; set; }
#nullable restore
#else
            [QueryParameter("username_query")]
            public string UsernameQuery { get; set; }
#endif
            /// <summary>Counts users with the specified web3 wallet addresses.Accepts up to 100 web3 wallet addresses.Any web3 wallet addressed not found are ignored.</summary>
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
