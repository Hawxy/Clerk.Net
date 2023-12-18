// <auto-generated/>
using Clerk.Net.Client.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Clerk.Net.Client.Proxy_checks {
    /// <summary>
    /// Builds and executes requests for operations under \proxy_checks
    /// </summary>
    public class Proxy_checksRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new Proxy_checksRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Proxy_checksRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/proxy_checks", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new Proxy_checksRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Proxy_checksRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/proxy_checks", rawUrl) {
        }
        /// <summary>
        /// This endpoint can be used to validate that a proxy-enabled domain is operational.It tries to verify that the proxy URL provided in the parameters maps to a functional proxy that can reach the Clerk Frontend API.You can use this endpoint before you set a proxy URL for a domain. This way you can ensure that switching to proxy-basedconfiguration will not lead to downtime for your instance.The `proxy_url` parameter allows for testing proxy configurations for domains that don&apos;t have a proxy URL yet, or operate ona different proxy URL than the one provided. It can also be used to re-validate a domain that is already configured to work with a proxy.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ProxyCheck?> PostAsync(Proxy_checksPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ProxyCheck> PostAsync(Proxy_checksPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"400", ClerkErrors.CreateFromDiscriminatorValue},
                {"422", ClerkErrors.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ProxyCheck>(requestInfo, ProxyCheck.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// This endpoint can be used to validate that a proxy-enabled domain is operational.It tries to verify that the proxy URL provided in the parameters maps to a functional proxy that can reach the Clerk Frontend API.You can use this endpoint before you set a proxy URL for a domain. This way you can ensure that switching to proxy-basedconfiguration will not lead to downtime for your instance.The `proxy_url` parameter allows for testing proxy configurations for domains that don&apos;t have a proxy URL yet, or operate ona different proxy URL than the one provided. It can also be used to re-validate a domain that is already configured to work with a proxy.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Proxy_checksPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Proxy_checksPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
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
        public Proxy_checksRequestBuilder WithUrl(string rawUrl) {
            return new Proxy_checksRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
