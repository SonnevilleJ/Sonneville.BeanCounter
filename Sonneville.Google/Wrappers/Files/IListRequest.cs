using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis;
using Google.Apis.Discovery;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;

namespace Sonneville.Google.Wrappers.Files
{
    public interface IListRequest
    {
        /// <summary>The source of files to list.</summary>
        /// 
        ///             [default: user]
        FilesResource.ListRequest.CorpusEnum? Corpus { get; set; }

        /// <summary>A comma-separated list of sort keys. Valid keys are 'createdTime', 'folder',
        /// 'modifiedByMeTime', 'modifiedTime', 'name', 'quotaBytesUsed', 'recency', 'sharedWithMeTime', 'starred',
        /// and 'viewedByMeTime'. Each key sorts ascending by default, but may be reversed with the 'desc' modifier.
        /// Example usage: ?orderBy=folder,modifiedTime desc,name. Please note that there is a current limitation
        /// for users with approximately one million files in which the requested sort order is ignored.</summary>
        string OrderBy { get; set; }

        /// <summary>The maximum number of files to return per page.</summary>
        /// 
        ///             [default: 100]
        ///             [minimum: 1]
        ///             [maximum: 1000]
        int? PageSize { get; set; }

        /// <summary>The token for continuing a previous list request on the next page. This should be set to the
        /// value of 'nextPageToken' from the previous response.</summary>
        string PageToken { get; set; }

        /// <summary>A query for filtering the file results. See the "Search for Files" guide for supported
        /// syntax.</summary>
        string Q { get; set; }

        /// <summary>A comma-separated list of spaces to query within the corpus. Supported values are 'drive',
        /// 'appDataFolder' and 'photos'.</summary>
        /// 
        ///             [default: drive]
        string Spaces { get; set; }

        /// <summary>Gets the method name.</summary>
        string MethodName { get; }

        /// <summary>Gets the HTTP method.</summary>
        string HttpMethod { get; }

        /// <summary>Gets the REST path.</summary>
        string RestPath { get; }

        FilesResource.ListRequest.AltEnum? Alt { get; set; }

        string Fields { get; set; }

        string Key { get; set; }

        string OauthToken { get; set; }

        bool? PrettyPrint { get; set; }

        string QuotaUser { get; set; }

        string UserIp { get; set; }

        ETagAction ETagAction { get; set; }

        IDictionary<string, IParameter> RequestParameters { get; }

        IClientService Service { get; }

        FilesResource.ListRequest Impl { get; }

        IFileList Execute();

        Stream ExecuteAsStream();

        Task<IFileList> ExecuteAsync();

        Task<IFileList> ExecuteAsync(CancellationToken cancellationToken);

        Task<Stream> ExecuteAsStreamAsync();

        Task<Stream> ExecuteAsStreamAsync(CancellationToken cancellationToken);

        HttpRequestMessage CreateRequest(bool? overrideGZipEnabled);
    }

    public class ListRequestWrapper : IListRequest
    {
        public ListRequestWrapper(FilesResource.ListRequest impl)
        {
            Impl = impl;
        }

        public FilesResource.ListRequest Impl { get; }

        public FilesResource.ListRequest.CorpusEnum? Corpus
        {
            get { return Impl.Corpus; }
            set { Impl.Corpus = value; }
        }

        public string OrderBy
        {
            get { return Impl.OrderBy; }
            set { Impl.OrderBy = value; }
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

        public string Q
        {
            get { return Impl.Q; }
            set { Impl.Q = value; }
        }

        public string Spaces
        {
            get { return Impl.Spaces; }
            set { Impl.Spaces = value; }
        }

        public string MethodName => Impl.MethodName;

        public string HttpMethod => Impl.HttpMethod;

        public string RestPath => Impl.RestPath;

        public DriveBaseServiceRequest<FileList>.AltEnum? Alt
        {
            get { return Impl.Alt; }
            set { Impl.Alt = value; }
        }

        public string Fields
        {
            get { return Impl.Fields; }
            set { Impl.Fields = value; }
        }

        public string Key
        {
            get { return Impl.Key; }
            set { Impl.Key = value; }
        }

        public string OauthToken
        {
            get { return Impl.OauthToken; }
            set { Impl.OauthToken = value; }
        }

        public bool? PrettyPrint
        {
            get { return Impl.PrettyPrint; }
            set { Impl.PrettyPrint = value; }
        }

        public string QuotaUser
        {
            get { return Impl.QuotaUser; }
            set { Impl.QuotaUser = value; }
        }

        public string UserIp
        {
            get { return Impl.UserIp; }
            set { Impl.UserIp = value; }
        }

        public ETagAction ETagAction
        {
            get { return Impl.ETagAction; }
            set { Impl.ETagAction = value; }
        }

        public IDictionary<string, IParameter> RequestParameters => Impl.RequestParameters;

        public IClientService Service => Impl.Service;

        public IFileList Execute()
        {
            return new FileListWrapper(Impl.Execute());
        }

        public Stream ExecuteAsStream()
        {
            return Impl.ExecuteAsStream();
        }

        public Task<IFileList> ExecuteAsync()
        {
            return Task
                .Run(() => Impl.ExecuteAsync())
                .ContinueWith(task => new FileListWrapper(task.Result) as IFileList);
        }

        public Task<IFileList> ExecuteAsync(CancellationToken cancellationToken)
        {
            return Task
                .Run(() => Impl.ExecuteAsync(cancellationToken), cancellationToken)
                .ContinueWith(task => new FileListWrapper(task.Result) as IFileList, cancellationToken);
        }

        public Task<Stream> ExecuteAsStreamAsync()
        {
            return Impl.ExecuteAsStreamAsync();
        }

        public Task<Stream> ExecuteAsStreamAsync(CancellationToken cancellationToken)
        {
            return Impl.ExecuteAsStreamAsync(cancellationToken);
        }

        public HttpRequestMessage CreateRequest(bool? overrideGZipEnabled)
        {
            return Impl.CreateRequest(overrideGZipEnabled);
        }
    }
}