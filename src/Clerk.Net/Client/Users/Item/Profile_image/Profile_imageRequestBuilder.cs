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
namespace Clerk.Net.Client.Users.Item.Profile_image
{
    /// <summary>
    /// Builds and executes requests for operations under \users\{user_id}\profile_image
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class Profile_imageRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Users.Item.Profile_image.Profile_imageRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Profile_imageRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user_id}/profile_image", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Users.Item.Profile_image.Profile_imageRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Profile_imageRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user_id}/profile_image", rawUrl)
        {
        }
        /// <summary>
        /// Delete a user&apos;s profile image
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Models.User"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Clerk.Net.Client.Models.User?> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Clerk.Net.Client.Models.User> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Clerk.Net.Client.Models.User>(requestInfo, global::Clerk.Net.Client.Models.User.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update a user&apos;s profile image
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Models.User"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 400 status code</exception>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 401 status code</exception>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Clerk.Net.Client.Models.User?> PostAsync(global::Clerk.Net.Client.Users.Item.Profile_image.Profile_imagePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Clerk.Net.Client.Models.User> PostAsync(global::Clerk.Net.Client.Users.Item.Profile_image.Profile_imagePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
                { "401", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
                { "404", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Clerk.Net.Client.Models.User>(requestInfo, global::Clerk.Net.Client.Models.User.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete a user&apos;s profile image
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
        /// Update a user&apos;s profile image
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Clerk.Net.Client.Users.Item.Profile_image.Profile_imagePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Clerk.Net.Client.Users.Item.Profile_image.Profile_imagePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "multipart/form-data", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Users.Item.Profile_image.Profile_imageRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Clerk.Net.Client.Users.Item.Profile_image.Profile_imageRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Clerk.Net.Client.Users.Item.Profile_image.Profile_imageRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
