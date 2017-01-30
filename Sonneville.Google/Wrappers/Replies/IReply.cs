using System;
using Google.Apis.Drive.v3.Data;

namespace Sonneville.Google.Wrappers.Replies
{
    public interface IReply
    {
        /// <summary>The action the reply performed to the parent comment. Valid values are: - resolve -
        /// reopen</summary>
        string Action { get; set; }

        /// <summary>The user who created the reply.</summary>
        User Author { get; set; }

        /// <summary>The plain text content of the reply. This field is used for setting the content, while htmlContent
        /// should be displayed. This is required on creates if no action is specified.</summary>
        string Content { get; set; }

        /// <summary>The time at which the reply was created (RFC 3339 date-time).</summary>
        string CreatedTimeRaw { get; set; }

        /// <summary><seealso cref="T:System.DateTime" /> representation of <see cref="P:Google.Apis.Drive.v3.Data.Reply.CreatedTimeRaw" />.</summary>
        DateTime? CreatedTime { get; set; }

        /// <summary>Whether the reply has been deleted. A deleted reply has no content.</summary>
        bool? Deleted { get; set; }

        /// <summary>The content of the reply with HTML formatting.</summary>
        string HtmlContent { get; set; }

        /// <summary>The ID of the reply.</summary>
        string Id { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "drive#reply".</summary>
        string Kind { get; set; }

        /// <summary>The last time the reply was modified (RFC 3339 date-time).</summary>
        string ModifiedTimeRaw { get; set; }

        /// <summary><seealso cref="T:System.DateTime" /> representation of <see cref="P:Google.Apis.Drive.v3.Data.Reply.ModifiedTimeRaw" />.</summary>
        DateTime? ModifiedTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        string ETag { get; set; }
    }
}