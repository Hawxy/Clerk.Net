// <auto-generated/>
#pragma warning disable CS0618
using Clerk.Net.Client.Users.Item.Passkeys.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Clerk.Net.Client.Users.Item.Passkeys
{
    /// <summary>
    /// Builds and executes requests for operations under \users\{user_id}\passkeys
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PasskeysRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Clerk.Net.Client.users.item.passkeys.item collection</summary>
        /// <param name="position">The ID of the passkey identity to be deleted</param>
        /// <returns>A <see cref="global::Clerk.Net.Client.Users.Item.Passkeys.Item.WithPasskey_identification_ItemRequestBuilder"/></returns>
        public global::Clerk.Net.Client.Users.Item.Passkeys.Item.WithPasskey_identification_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("passkey_identification_id", position);
                return new global::Clerk.Net.Client.Users.Item.Passkeys.Item.WithPasskey_identification_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Users.Item.Passkeys.PasskeysRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PasskeysRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user_id}/passkeys", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Users.Item.Passkeys.PasskeysRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PasskeysRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user_id}/passkeys", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
