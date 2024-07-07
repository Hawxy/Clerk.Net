// <auto-generated/>
using Clerk.Net.Client.Invitations.Item.Revoke;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Clerk.Net.Client.Invitations.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \invitations\{invitation_id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class WithInvitation_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The revoke property</summary>
        public global::Clerk.Net.Client.Invitations.Item.Revoke.RevokeRequestBuilder Revoke
        {
            get => new global::Clerk.Net.Client.Invitations.Item.Revoke.RevokeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Invitations.Item.WithInvitation_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithInvitation_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/invitations/{invitation_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Invitations.Item.WithInvitation_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithInvitation_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/invitations/{invitation_id}", rawUrl)
        {
        }
    }
}
