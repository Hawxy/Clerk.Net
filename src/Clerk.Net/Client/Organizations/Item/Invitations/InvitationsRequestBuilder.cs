// <auto-generated/>
#pragma warning disable CS0618
using Clerk.Net.Client.Models;
using Clerk.Net.Client.Organizations.Item.Invitations.Bulk;
using Clerk.Net.Client.Organizations.Item.Invitations.Item;
using Clerk.Net.Client.Organizations.Item.Invitations.Pending;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Clerk.Net.Client.Organizations.Item.Invitations
{
    /// <summary>
    /// Builds and executes requests for operations under \organizations\{organization_id}\invitations
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class InvitationsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The bulk property</summary>
        public global::Clerk.Net.Client.Organizations.Item.Invitations.Bulk.BulkRequestBuilder Bulk
        {
            get => new global::Clerk.Net.Client.Organizations.Item.Invitations.Bulk.BulkRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The pending property</summary>
        public global::Clerk.Net.Client.Organizations.Item.Invitations.Pending.PendingRequestBuilder Pending
        {
            get => new global::Clerk.Net.Client.Organizations.Item.Invitations.Pending.PendingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Clerk.Net.Client.organizations.item.invitations.item collection</summary>
        /// <param name="position">The organization invitation ID.</param>
        /// <returns>A <see cref="global::Clerk.Net.Client.Organizations.Item.Invitations.Item.WithInvitation_ItemRequestBuilder"/></returns>
        public global::Clerk.Net.Client.Organizations.Item.Invitations.Item.WithInvitation_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("invitation_id", position);
                return new global::Clerk.Net.Client.Organizations.Item.Invitations.Item.WithInvitation_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Organizations.Item.Invitations.InvitationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InvitationsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/organizations/{organization_id}/invitations{?email_address*,limit*,offset*,status*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Organizations.Item.Invitations.InvitationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InvitationsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/organizations/{organization_id}/invitations{?email_address*,limit*,offset*,status*}", rawUrl)
        {
        }
        /// <summary>
        /// This request returns the list of organization invitations.Results can be paginated using the optional `limit` and `offset` query parameters.You can filter them by providing the &apos;status&apos; query parameter, that accepts multiple values.The organization invitations are ordered by descending creation date.Most recent invitations will be returned first.Any invitations created as a result of an Organization Domain are not included in the results.
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Models.OrganizationInvitations"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 400 status code</exception>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 404 status code</exception>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Clerk.Net.Client.Models.OrganizationInvitations?> GetAsync(Action<RequestConfiguration<global::Clerk.Net.Client.Organizations.Item.Invitations.InvitationsRequestBuilder.InvitationsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Clerk.Net.Client.Models.OrganizationInvitations> GetAsync(Action<RequestConfiguration<global::Clerk.Net.Client.Organizations.Item.Invitations.InvitationsRequestBuilder.InvitationsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
                { "404", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
                { "422", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Clerk.Net.Client.Models.OrganizationInvitations>(requestInfo, global::Clerk.Net.Client.Models.OrganizationInvitations.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a new organization invitation and sends an email to the provided `email_address` with a link to accept the invitation and join the organization.You can specify the `role` for the invited organization member.New organization invitations get a &quot;pending&quot; status until they are revoked by an organization administrator or accepted by the invitee.The request body supports passing an optional `redirect_url` parameter.When the invited user clicks the link to accept the invitation, they will be redirected to the URL provided.Use this parameter to implement a custom invitation acceptance flow.You can specify the ID of the user that will send the invitation with the `inviter_user_id` parameter.That user must be a member with administrator privileges in the organization.Only &quot;admin&quot; members can create organization invitations.You can optionally provide public and private metadata for the organization invitation.The public metadata are visible by both the Frontend and the Backend whereas the private ones only by the Backend.When the organization invitation is accepted, the metadata will be transferred to the newly created organization membership.
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Models.OrganizationInvitation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 400 status code</exception>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 403 status code</exception>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 404 status code</exception>
        /// <exception cref="global::Clerk.Net.Client.Models.ClerkErrors">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Clerk.Net.Client.Models.OrganizationInvitation?> PostAsync(global::Clerk.Net.Client.Organizations.Item.Invitations.InvitationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Clerk.Net.Client.Models.OrganizationInvitation> PostAsync(global::Clerk.Net.Client.Organizations.Item.Invitations.InvitationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
                { "403", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
                { "404", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
                { "422", global::Clerk.Net.Client.Models.ClerkErrors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Clerk.Net.Client.Models.OrganizationInvitation>(requestInfo, global::Clerk.Net.Client.Models.OrganizationInvitation.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// This request returns the list of organization invitations.Results can be paginated using the optional `limit` and `offset` query parameters.You can filter them by providing the &apos;status&apos; query parameter, that accepts multiple values.The organization invitations are ordered by descending creation date.Most recent invitations will be returned first.Any invitations created as a result of an Organization Domain are not included in the results.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Clerk.Net.Client.Organizations.Item.Invitations.InvitationsRequestBuilder.InvitationsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Clerk.Net.Client.Organizations.Item.Invitations.InvitationsRequestBuilder.InvitationsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates a new organization invitation and sends an email to the provided `email_address` with a link to accept the invitation and join the organization.You can specify the `role` for the invited organization member.New organization invitations get a &quot;pending&quot; status until they are revoked by an organization administrator or accepted by the invitee.The request body supports passing an optional `redirect_url` parameter.When the invited user clicks the link to accept the invitation, they will be redirected to the URL provided.Use this parameter to implement a custom invitation acceptance flow.You can specify the ID of the user that will send the invitation with the `inviter_user_id` parameter.That user must be a member with administrator privileges in the organization.Only &quot;admin&quot; members can create organization invitations.You can optionally provide public and private metadata for the organization invitation.The public metadata are visible by both the Frontend and the Backend whereas the private ones only by the Backend.When the organization invitation is accepted, the metadata will be transferred to the newly created organization membership.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Clerk.Net.Client.Organizations.Item.Invitations.InvitationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Clerk.Net.Client.Organizations.Item.Invitations.InvitationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
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
        /// <returns>A <see cref="global::Clerk.Net.Client.Organizations.Item.Invitations.InvitationsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Clerk.Net.Client.Organizations.Item.Invitations.InvitationsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Clerk.Net.Client.Organizations.Item.Invitations.InvitationsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// This request returns the list of organization invitations.Results can be paginated using the optional `limit` and `offset` query parameters.You can filter them by providing the &apos;status&apos; query parameter, that accepts multiple values.The organization invitations are ordered by descending creation date.Most recent invitations will be returned first.Any invitations created as a result of an Organization Domain are not included in the results.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class InvitationsRequestBuilderGetQueryParameters 
        {
            /// <summary>Returns organization invitations inviting the specified email address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("email_address")]
            public string? EmailAddress { get; set; }
#nullable restore
#else
            [QueryParameter("email_address")]
            public string EmailAddress { get; set; }
#endif
            /// <summary>Applies a limit to the number of results returned.Can be used for paginating the results together with `offset`.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>Skip the first `offset` results when paginating.Needs to be an integer greater or equal to zero.To be used in conjunction with `limit`.</summary>
            [QueryParameter("offset")]
            public int? Offset { get; set; }
            /// <summary>Filter organization invitations based on their status</summary>
            [QueryParameter("status")]
            public global::Clerk.Net.Client.Organizations.Item.Invitations.GetStatusQueryParameterType? Status { get; set; }
        }
    }
}
#pragma warning restore CS0618
