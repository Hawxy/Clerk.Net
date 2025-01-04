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
namespace Clerk.Net.Client.Waitlist_entries
{
    /// <summary>
    /// Builds and executes requests for operations under \waitlist_entries
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Waitlist_entriesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Waitlist_entries.Waitlist_entriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Waitlist_entriesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/waitlist_entries{?limit*,offset*,order_by*,query*,status*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Waitlist_entries.Waitlist_entriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Waitlist_entriesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/waitlist_entries{?limit*,offset*,order_by*,query*,status*}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieve a list of waitlist entries for the instance.Entries are ordered by creation date in descending order by default.Supports filtering by email address or status and pagination with limit and offset parameters.
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Waitlist_entries.Waitlist_entriesGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Clerk.Net.Client.Waitlist_entries.Waitlist_entriesGetResponse?> GetAsync(Action<RequestConfiguration<global::Clerk.Net.Client.Waitlist_entries.Waitlist_entriesRequestBuilder.Waitlist_entriesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Clerk.Net.Client.Waitlist_entries.Waitlist_entriesGetResponse> GetAsync(Action<RequestConfiguration<global::Clerk.Net.Client.Waitlist_entries.Waitlist_entriesRequestBuilder.Waitlist_entriesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Clerk.Net.Client.Waitlist_entries.Waitlist_entriesGetResponse>(requestInfo, global::Clerk.Net.Client.Waitlist_entries.Waitlist_entriesGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a new waitlist entry for the given email address.If the email address is already on the waitlist, no new entry will be created and the existing waitlist entry will be returned.
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Models.WaitlistEntry"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 400 status code</exception>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Clerk.Net.Client.Models.WaitlistEntry?> PostAsync(global::Clerk.Net.Client.Waitlist_entries.Waitlist_entriesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Clerk.Net.Client.Models.WaitlistEntry> PostAsync(global::Clerk.Net.Client.Waitlist_entries.Waitlist_entriesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
                { "422", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Clerk.Net.Client.Models.WaitlistEntry>(requestInfo, global::Clerk.Net.Client.Models.WaitlistEntry.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve a list of waitlist entries for the instance.Entries are ordered by creation date in descending order by default.Supports filtering by email address or status and pagination with limit and offset parameters.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Clerk.Net.Client.Waitlist_entries.Waitlist_entriesRequestBuilder.Waitlist_entriesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Clerk.Net.Client.Waitlist_entries.Waitlist_entriesRequestBuilder.Waitlist_entriesRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates a new waitlist entry for the given email address.If the email address is already on the waitlist, no new entry will be created and the existing waitlist entry will be returned.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Clerk.Net.Client.Waitlist_entries.Waitlist_entriesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Clerk.Net.Client.Waitlist_entries.Waitlist_entriesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Clerk.Net.Client.Waitlist_entries.Waitlist_entriesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Clerk.Net.Client.Waitlist_entries.Waitlist_entriesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Clerk.Net.Client.Waitlist_entries.Waitlist_entriesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieve a list of waitlist entries for the instance.Entries are ordered by creation date in descending order by default.Supports filtering by email address or status and pagination with limit and offset parameters.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Waitlist_entriesRequestBuilderGetQueryParameters 
        {
            /// <summary>Applies a limit to the number of results returned.Can be used for paginating the results together with `offset`.</summary>
            [QueryParameter("limit")]
            public double? Limit { get; set; }
            /// <summary>Skip the first `offset` results when paginating.Needs to be an integer greater or equal to zero.To be used in conjunction with `limit`.</summary>
            [QueryParameter("offset")]
            public double? Offset { get; set; }
            /// <summary>Specify the order of results. Supported values are:- `created_at`- `email_address`- `invited_at`Use `+` for ascending or `-` for descending order. Defaults to `-created_at`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("order_by")]
            public string? OrderBy { get; set; }
#nullable restore
#else
            [QueryParameter("order_by")]
            public string OrderBy { get; set; }
#endif
            /// <summary>Filter waitlist entries by email address</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("query")]
            public string? Query { get; set; }
#nullable restore
#else
            [QueryParameter("query")]
            public string Query { get; set; }
#endif
            /// <summary>Filter waitlist entries by their status</summary>
            [QueryParameter("status")]
            public global::Clerk.Net.Client.Waitlist_entries.GetStatusQueryParameterType? Status { get; set; }
        }
    }
}
#pragma warning restore CS0618