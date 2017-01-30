using Google.Apis.Drive.v3;

namespace Sonneville.Google.Wrappers.Comments
{
    public interface IGetRequest
    {
        /// <summary>The ID of the file.</summary>
        string FileId { get; }

        /// <summary>The ID of the comment.</summary>
        string CommentId { get; }

        /// <summary>Whether to return deleted comments. Deleted comments will not include their original
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

        CommentsResource.GetRequest Impl { get; }
    }

    public class GetRequestWrapper : IGetRequest
    {
        public GetRequestWrapper(CommentsResource.GetRequest impl)
        {
            Impl = impl;
        }

        public CommentsResource.GetRequest Impl { get; }

        public string FileId => Impl.FileId;

        public string CommentId => Impl.CommentId;

        public bool? IncludeDeleted
        {
            get { return Impl.IncludeDeleted; }
            set { Impl.IncludeDeleted = value; }
        }

        public string MethodName => Impl.MethodName;

        public string HttpMethod => Impl.HttpMethod;

        public string RestPath => Impl.RestPath;
    }
}