// <auto-generated/>
using Clerk.Net.Client.Models;
using Clerk.Net.Client.Phone_numbers.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Clerk.Net.Client.Phone_numbers {
    /// <summary>
    /// Builds and executes requests for operations under \phone_numbers
    /// </summary>
    public class Phone_numbersRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Clerk.Net.Client.phone_numbers.item collection</summary>
        /// <param name="position">The ID of the phone number to retrieve</param>
        public WithPhone_number_ItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("phone_number_id", position);
            return new WithPhone_number_ItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new Phone_numbersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Phone_numbersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/phone_numbers", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new Phone_numbersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Phone_numbersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/phone_numbers", rawUrl) {
        }
        /// <summary>
        /// Create a new phone number
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PhoneNumber?> PostAsync(Phone_numbersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<PhoneNumber> PostAsync(Phone_numbersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"400", ClerkErrors.CreateFromDiscriminatorValue},
                {"401", ClerkErrors.CreateFromDiscriminatorValue},
                {"403", ClerkErrors.CreateFromDiscriminatorValue},
                {"404", ClerkErrors.CreateFromDiscriminatorValue},
                {"422", ClerkErrors.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<PhoneNumber>(requestInfo, PhoneNumber.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a new phone number
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Phone_numbersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Phone_numbersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new RequestConfiguration<DefaultQueryParameters>();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Phone_numbersRequestBuilder WithUrl(string rawUrl) {
            return new Phone_numbersRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
