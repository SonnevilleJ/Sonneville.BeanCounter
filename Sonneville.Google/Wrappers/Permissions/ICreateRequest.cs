namespace Sonneville.Google.Wrappers.Permissions
{
    public interface ICreateRequest
    {
        /// <summary>The ID of the file.</summary>
        string FileId { get; }

        /// <summary>A custom message to include in the notification email.</summary>
        string EmailMessage { get; set; }

        /// <summary>Whether to send a notification email when sharing to users or groups. This defaults to true for
        /// users and groups, and is not allowed for other requests. It must not be disabled for ownership
        /// transfers.</summary>
        bool? SendNotificationEmail { get; set; }

        /// <summary>Whether to transfer ownership to the specified user and downgrade the current owner to a
        /// writer. This parameter is required as an acknowledgement of the side effect.</summary>
        /// 
        ///             [default: false]
        bool? TransferOwnership { get; set; }

        /// <summary>Gets the method name.</summary>
        string MethodName { get; }

        /// <summary>Gets the HTTP method.</summary>
        string HttpMethod { get; }

        /// <summary>Gets the REST path.</summary>
        string RestPath { get; }
    }
}