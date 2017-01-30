using Google.Apis.Drive.v3;

namespace Sonneville.Google.Wrappers.Replies
{
    public interface IDeleteRequest
    {
        /// <summary>The ID of the file.</summary>
        string FileId { get; }

        /// <summary>The ID of the comment.</summary>
        string CommentId { get; }

        /// <summary>The ID of the reply.</summary>
        string ReplyId { get; }

        /// <summary>Gets the method name.</summary>
        string MethodName { get; }

        /// <summary>Gets the HTTP method.</summary>
        string HttpMethod { get; }

        /// <summary>Gets the REST path.</summary>
        string RestPath { get; }

        RepliesResource.DeleteRequest Impl { get; }
    }

    public class DeleteRequestWrapper : IDeleteRequest
    {
        public DeleteRequestWrapper(RepliesResource.DeleteRequest impl)
        {
            Impl = impl;
        }

        public RepliesResource.DeleteRequest Impl { get; }

        public string FileId => Impl.FileId;

        public string CommentId => Impl.CommentId;

        public string ReplyId => Impl.ReplyId;

        public string MethodName => Impl.MethodName;

        public string HttpMethod => Impl.HttpMethod;

        public string RestPath => Impl.RestPath;
    }
}