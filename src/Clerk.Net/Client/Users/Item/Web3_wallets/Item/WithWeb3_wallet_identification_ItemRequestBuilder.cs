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
namespace Clerk.Net.Client.Users.Item.Web3_wallets.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \users\{user_id}\web3_wallets\{web3_wallet_identification_id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithWeb3_wallet_identification_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Users.Item.Web3_wallets.Item.WithWeb3_wallet_identification_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithWeb3_wallet_identification_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user_id}/web3_wallets/{web3_wallet_identification_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Users.Item.Web3_wallets.Item.WithWeb3_wallet_identification_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithWeb3_wallet_identification_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user_id}/web3_wallets/{web3_wallet_identification_id}", rawUrl)
        {
        }
        /// <summary>
        /// Delete the web3 wallet identification for a given user.
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Models.DeletedObject"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 400 status code</exception>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 403 status code</exception>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 404 status code</exception>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Clerk.Net.Client.Models.DeletedObject?> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Clerk.Net.Client.Models.DeletedObject> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
                { "403", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
                { "404", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
                { "500", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Clerk.Net.Client.Models.DeletedObject>(requestInfo, global::Clerk.Net.Client.Models.DeletedObject.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete the web3 wallet identification for a given user.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Users.Item.Web3_wallets.Item.WithWeb3_wallet_identification_ItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Clerk.Net.Client.Users.Item.Web3_wallets.Item.WithWeb3_wallet_identification_ItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Clerk.Net.Client.Users.Item.Web3_wallets.Item.WithWeb3_wallet_identification_ItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
