// <auto-generated/>
#pragma warning disable CS0618
using Clerk.Net.Client.Actor_tokens.Item.Revoke;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Clerk.Net.Client.Actor_tokens.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \actor_tokens\{actor_token_id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithActor_token_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The revoke property</summary>
        public global::Clerk.Net.Client.Actor_tokens.Item.Revoke.RevokeRequestBuilder Revoke
        {
            get => new global::Clerk.Net.Client.Actor_tokens.Item.Revoke.RevokeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Actor_tokens.Item.WithActor_token_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithActor_token_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/actor_tokens/{actor_token_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Actor_tokens.Item.WithActor_token_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithActor_token_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/actor_tokens/{actor_token_id}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
