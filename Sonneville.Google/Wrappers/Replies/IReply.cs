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

        Reply Impl { get; }
    }

    public class ReplyWrapper : IReply
    {
        public ReplyWrapper(Reply impl)
        {
            Impl = impl;
        }

        public Reply Impl { get; }

        public string Action
        {
            get { return Impl.Action; }
            set { Impl.Action = value; }
        }

        public User Author
        {
            get { return Impl.Author; }
            set { Impl.Author = value; }
        }

        public string Content
        {
            get { return Impl.Content; }
            set { Impl.Content = value; }
        }

        public string CreatedTimeRaw
        {
            get { return Impl.CreatedTimeRaw; }
            set { Impl.CreatedTimeRaw = value; }
        }

        public DateTime? CreatedTime
        {
            get { return Impl.CreatedTime; }
            set { Impl.CreatedTime = value; }
        }

        public bool? Deleted
        {
            get { return Impl.Deleted; }
            set { Impl.Deleted = value; }
        }

        public string HtmlContent
        {
            get { return Impl.HtmlContent; }
            set { Impl.HtmlContent = value; }
        }

        public string Id
        {
            get { return Impl.Id; }
            set { Impl.Id = value; }
        }

        public string Kind
        {
            get { return Impl.Kind; }
            set { Impl.Kind = value; }
        }

        public string ModifiedTimeRaw
        {
            get { return Impl.ModifiedTimeRaw; }
            set { Impl.ModifiedTimeRaw = value; }
        }

        public DateTime? ModifiedTime
        {
            get { return Impl.ModifiedTime; }
            set { Impl.ModifiedTime = value; }
        }

        public string ETag
        {
            get { return Impl.ETag; }
            set { Impl.ETag = value; }
        }
    }
}