using Google.Apis.Drive.v3;

namespace Sonneville.Google.Wrappers.Comments
{
    public interface IUpdateRequest
    {
        /// <summary>The ID of the file.</summary>
        string FileId { get; }

        /// <summary>The ID of the comment.</summary>
        string CommentId { get; }

        /// <summary>Gets the method name.</summary>
        string MethodName { get; }

        /// <summary>Gets the HTTP method.</summary>
        string HttpMethod { get; }

        /// <summary>Gets the REST path.</summary>
        string RestPath { get; }

        CommentsResource.UpdateRequest Impl { get; }
    }

    public class UpdateRequestWrapper : IUpdateRequest
    {
        public UpdateRequestWrapper(CommentsResource.UpdateRequest impl)
        {
            Impl = impl;
        }

        public CommentsResource.UpdateRequest Impl { get; }

        public string FileId => Impl.FileId;

        public string CommentId => Impl.CommentId;

        public string MethodName => Impl.MethodName;

        public string HttpMethod => Impl.HttpMethod;

        public string RestPath => Impl.RestPath;
    }
}