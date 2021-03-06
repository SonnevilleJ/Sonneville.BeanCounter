using Google.Apis.Drive.v3;

namespace Sonneville.Google.Wrappers.Revisions
{
    public interface IListRequest
    {
        /// <summary>The ID of the file.</summary>
        string FileId { get; }

        /// <summary>The maximum number of revisions to return per page.</summary>
        /// 
        ///             [default: 200]
        ///             [minimum: 1]
        ///             [maximum: 1000]
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

        RevisionsResource.ListRequest Impl { get; }
    }

    public class ListRequestWrapper : IListRequest
    {
        public ListRequestWrapper(RevisionsResource.ListRequest impl)
        {
            Impl = impl;
        }

        public RevisionsResource.ListRequest Impl { get; }

        public string FileId => Impl.FileId;

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