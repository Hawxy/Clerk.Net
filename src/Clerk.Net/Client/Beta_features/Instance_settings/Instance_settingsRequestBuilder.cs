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
namespace Clerk.Net.Client.Beta_features.Instance_settings
{
    /// <summary>
    /// Builds and executes requests for operations under \beta_features\instance_settings
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Instance_settingsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Beta_features.Instance_settings.Instance_settingsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Instance_settingsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/beta_features/instance_settings", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Beta_features.Instance_settings.Instance_settingsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Instance_settingsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/beta_features/instance_settings", rawUrl)
        {
        }
        /// <summary>
        /// Updates the settings of an instance
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Beta_features.Instance_settings.Instance_settingsPatchResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 402 status code</exception>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Clerk.Net.Client.Beta_features.Instance_settings.Instance_settingsPatchResponse?> PatchAsync(global::Clerk.Net.Client.Beta_features.Instance_settings.Instance_settingsPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Clerk.Net.Client.Beta_features.Instance_settings.Instance_settingsPatchResponse> PatchAsync(global::Clerk.Net.Client.Beta_features.Instance_settings.Instance_settingsPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "402", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
                { "422", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Clerk.Net.Client.Beta_features.Instance_settings.Instance_settingsPatchResponse>(requestInfo, global::Clerk.Net.Client.Beta_features.Instance_settings.Instance_settingsPatchResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Updates the settings of an instance
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Clerk.Net.Client.Beta_features.Instance_settings.Instance_settingsPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Clerk.Net.Client.Beta_features.Instance_settings.Instance_settingsPatchRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Beta_features.Instance_settings.Instance_settingsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Clerk.Net.Client.Beta_features.Instance_settings.Instance_settingsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Clerk.Net.Client.Beta_features.Instance_settings.Instance_settingsRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
