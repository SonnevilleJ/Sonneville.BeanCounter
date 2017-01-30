using System;
using System.Collections.Generic;
using System.Linq;
using Google.Apis.Drive.v3.Data;
using Sonneville.Google.Wrappers.Replies;

namespace Sonneville.Google.Wrappers.Comments
{
    public interface IComment
    {
        /// <summary>A region of the document represented as a JSON string. See anchor documentation for details on how
        /// to define and interpret anchor properties.</summary>
        string Anchor { get; set; }

        /// <summary>The user who created the comment.</summary>
        IUser Author { get; set; }

        /// <summary>The plain text content of the comment. This field is used for setting the content, while
        /// htmlContent should be displayed.</summary>
        string Content { get; set; }

        /// <summary>The time at which the comment was created (RFC 3339 date-time).</summary>
        string CreatedTimeRaw { get; set; }

        /// <summary><seealso cref="T:System.DateTime" /> representation of <see cref="P:Google.Apis.Drive.v3.Data.Comment.CreatedTimeRaw" />.</summary>
        DateTime? CreatedTime { get; set; }

        /// <summary>Whether the comment has been deleted. A deleted comment has no content.</summary>
        bool? Deleted { get; set; }

        /// <summary>The content of the comment with HTML formatting.</summary>
        string HtmlContent { get; set; }

        /// <summary>The ID of the comment.</summary>
        string Id { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "drive#comment".</summary>
        string Kind { get; set; }

        /// <summary>The last time the comment or any of its replies was modified (RFC 3339 date-time).</summary>
        string ModifiedTimeRaw { get; set; }

        /// <summary><seealso cref="T:System.DateTime" /> representation of <see cref="P:Google.Apis.Drive.v3.Data.Comment.ModifiedTimeRaw" />.</summary>
        DateTime? ModifiedTime { get; set; }

        /// <summary>The file content to which the comment refers, typically within the anchor region. For a text file,
        /// for example, this would be the text at the location of the comment.</summary>
        IQuotedFileContentData QuotedFileContent { get; set; }

        /// <summary>The full list of replies to the comment in chronological order.</summary>
        IList<IReply> Replies { get; set; }

        /// <summary>Whether the comment has been resolved by one of its replies.</summary>
        bool? Resolved { get; set; }

        /// <summary>The ETag of the item.</summary>
        string ETag { get; set; }

        Comment Impl { get; }
    }

    public class CommentWrapper : IComment
    {
        public CommentWrapper(Comment impl)
        {
            Impl = impl;
        }

        public Comment Impl { get; }

        public string Anchor
        {
            get { return Impl.Anchor; }
            set { Impl.Anchor = value; }
        }

        public IUser Author
        {
            get { return new UserWrapper(Impl.Author); }
            set { Impl.Author = value.Impl; }
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

        public IQuotedFileContentData QuotedFileContent
        {
            get { return new QuotedFileContentDataWrapper(Impl.QuotedFileContent); }
            set { Impl.QuotedFileContent = value.Impl; }
        }

        public IList<IReply> Replies
        {
            get { return Impl.Replies.Select(reply => new ReplyWrapper(reply)).Cast<IReply>().ToList(); }
            set { Impl.Replies = value.Select(reply => reply.Impl).ToList(); }
        }

        public bool? Resolved
        {
            get { return Impl.Resolved; }
            set { Impl.Resolved = value; }
        }

        public string ETag
        {
            get { return Impl.ETag; }
            set { Impl.ETag = value; }
        }
    }
}