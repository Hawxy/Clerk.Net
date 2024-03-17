// <auto-generated/>
using Clerk.Net.Client.Beta_features.Domain;
using Clerk.Net.Client.Beta_features.Instance_settings;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Clerk.Net.Client.Beta_features {
    /// <summary>
    /// Builds and executes requests for operations under \beta_features
    /// </summary>
    public class Beta_featuresRequestBuilder : BaseRequestBuilder {
        /// <summary>The domain property</summary>
        public DomainRequestBuilder Domain { get =>
            new DomainRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The instance_settings property</summary>
        public Instance_settingsRequestBuilder Instance_settings { get =>
            new Instance_settingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Beta_featuresRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Beta_featuresRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/beta_features", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="Beta_featuresRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Beta_featuresRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/beta_features", rawUrl) {
        }
    }
}
