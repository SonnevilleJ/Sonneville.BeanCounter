using Google.Apis.Drive.v3;

namespace Sonneville.Google.Wrappers.Comments
{
    public interface IListRequest
    {
        /// <summary>The ID of the file.</summary>
        string FileId { get; }

        /// <summary>Whether to include deleted comments. Deleted comments will not include their original
        /// content.</summary>
        /// 
        ///             [default: false]
        bool? IncludeDeleted { get; set; }

        /// <summary>The maximum number of comments to return per page.</summary>
        /// 
        ///             [default: 20]
        ///             [minimum: 1]
        ///             [maximum: 100]
        int? PageSize { get; set; }

        /// <summary>The token for continuing a previous list request on the next page. This should be set to the
        /// value of 'nextPageToken' from the previous response.</summary>
        string PageToken { get; set; }

        /// <summary>The minimum value of 'modifiedTime' for the result comments (RFC 3339 date-time).</summary>
        string StartModifiedTime { get; set; }

        /// <summary>Gets the method name.</summary>
        string MethodName { get; }

        /// <summary>Gets the HTTP method.</summary>
        string HttpMethod { get; }

        /// <summary>Gets the REST path.</summary>
        string RestPath { get; }

        CommentsResource.ListRequest Impl { get; }
    }

    public class ListRequestWrapper : IListRequest
    {
        public ListRequestWrapper(CommentsResource.ListRequest impl)
        {
            Impl = impl;
        }

        public CommentsResource.ListRequest Impl { get; }

        public string FileId => Impl.FileId;

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

        public string StartModifiedTime
        {
            get { return Impl.StartModifiedTime; }
            set { Impl.StartModifiedTime = value; }
        }

        public string MethodName => Impl.MethodName;

        public string HttpMethod => Impl.HttpMethod;

        public string RestPath => Impl.RestPath;
    }
}