// <auto-generated/>
using Clerk.Net.Client.Users.Item.Oauth_access_tokens.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Clerk.Net.Client.Users.Item.Oauth_access_tokens
{
    /// <summary>
    /// Builds and executes requests for operations under \users\{user_id}\oauth_access_tokens
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class Oauth_access_tokensRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Clerk.Net.Client.users.item.oauth_access_tokens.item collection</summary>
        /// <param name="position">The ID of the OAuth provider (e.g. `oauth_google`)</param>
        /// <returns>A <see cref="global::Clerk.Net.Client.Users.Item.Oauth_access_tokens.Item.WithProviderItemRequestBuilder"/></returns>
        public global::Clerk.Net.Client.Users.Item.Oauth_access_tokens.Item.WithProviderItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("provider", position);
                return new global::Clerk.Net.Client.Users.Item.Oauth_access_tokens.Item.WithProviderItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Users.Item.Oauth_access_tokens.Oauth_access_tokensRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Oauth_access_tokensRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user_id}/oauth_access_tokens", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Users.Item.Oauth_access_tokens.Oauth_access_tokensRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Oauth_access_tokensRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user_id}/oauth_access_tokens", rawUrl)
        {
        }
    }
}
