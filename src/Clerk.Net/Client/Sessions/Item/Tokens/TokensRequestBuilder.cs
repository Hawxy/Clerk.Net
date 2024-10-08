// <auto-generated/>
#pragma warning disable CS0618
using Clerk.Net.Client.Sessions.Item.Tokens.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Clerk.Net.Client.Sessions.Item.Tokens
{
    /// <summary>
    /// Builds and executes requests for operations under \sessions\{session_id}\tokens
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class TokensRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Clerk.Net.Client.sessions.item.tokens.item collection</summary>
        /// <param name="position">The name of the JWT Template defined in your instance (e.g. `custom_hasura`).</param>
        /// <returns>A <see cref="global::Clerk.Net.Client.Sessions.Item.Tokens.Item.WithTemplate_nameItemRequestBuilder"/></returns>
        public global::Clerk.Net.Client.Sessions.Item.Tokens.Item.WithTemplate_nameItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("template_name", position);
                return new global::Clerk.Net.Client.Sessions.Item.Tokens.Item.WithTemplate_nameItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Sessions.Item.Tokens.TokensRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TokensRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/sessions/{session_id}/tokens", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Sessions.Item.Tokens.TokensRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TokensRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/sessions/{session_id}/tokens", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
