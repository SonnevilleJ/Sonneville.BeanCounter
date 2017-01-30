namespace Sonneville.Google.Wrappers.Replies
{
    public interface IGetRequest
    {
        /// <summary>The ID of the file.</summary>
        string FileId { get; }

        /// <summary>The ID of the comment.</summary>
        string CommentId { get; }

        /// <summary>The ID of the reply.</summary>
        string ReplyId { get; }

        /// <summary>Whether to return deleted replies. Deleted replies will not include their original
        /// content.</summary>
        /// 
        ///             [default: false]
        bool? IncludeDeleted { get; set; }

        /// <summary>Gets the method name.</summary>
        string MethodName { get; }

        /// <summary>Gets the HTTP method.</summary>
        string HttpMethod { get; }

        /// <summary>Gets the REST path.</summary>
        string RestPath { get; }
    }
}