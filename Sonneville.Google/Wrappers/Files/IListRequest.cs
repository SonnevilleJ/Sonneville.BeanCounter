using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis;
using Google.Apis.Discovery;
using Google.Apis.Drive.v3;
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

        IFileList Execute();

        Stream ExecuteAsStream();

        Task<IFileList> ExecuteAsync();

        Task<IFileList> ExecuteAsync(CancellationToken cancellationToken);

        Task<Stream> ExecuteAsStreamAsync();

        Task<Stream> ExecuteAsStreamAsync(CancellationToken cancellationToken);

        HttpRequestMessage CreateRequest(bool? overrideGZipEnabled);
    }
}