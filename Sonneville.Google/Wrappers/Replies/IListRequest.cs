using Google.Apis.Drive.v3;

namespace Sonneville.Google.Wrappers.Replies
{
    public interface IListRequest
    {
        /// <summary>The ID of the file.</summary>
        string FileId { get; }

        /// <summary>The ID of the comment.</summary>
        string CommentId { get; }

        /// <summary>Whether to include deleted replies. Deleted replies will not include their original
        /// content.</summary>
        /// 
        ///             [default: false]
        bool? IncludeDeleted { get; set; }

        /// <summary>The maximum number of replies to return per page.</summary>
        /// 
        ///             [default: 20]
        ///             [minimum: 1]
        ///             [maximum: 100]
        int? PageSize { get; set; }

        /// <summary>The token for continuing a previous list request on the next page. This should be set to the
        /// value of 'nextPageToken' from the previous response.</summary>
        string PageToken { get; set; }

        /// <summary>Gets the method name.</summary>
        string MethodName { get; }

        /// <summary>Gets the HTTP method.</summary>
        string HttpMethod { get; }

        /// <summary>Gets the REST path.</summary>
        string RestPath { get; }

        RepliesResource.ListRequest Impl { get; }
    }

    public class ListRequestWrapper : IListRequest
    {
        public ListRequestWrapper(RepliesResource.ListRequest impl)
        {
            Impl = impl;
        }

        public RepliesResource.ListRequest Impl { get; }

        public string FileId => Impl.FileId;

        public string CommentId => Impl.CommentId;

        public bool? IncludeDeleted
        {
            get { return Impl.IncludeDeleted; }
            set { Impl.IncludeDeleted = value; }
        }

        public int? PageSize
        {
            get { return Impl.PageSize; }
            set { Impl.PageSize = value; }
        }

        public string PageToken
        {
            get { return Impl.PageToken; }
            set { Impl.PageToken = value; }
        }

        public string MethodName => Impl.MethodName;

        public string HttpMethod => Impl.HttpMethod;

        public string RestPath => Impl.RestPath;
    }
}