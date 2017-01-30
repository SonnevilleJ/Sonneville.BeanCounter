using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis;
using Google.Apis.Discovery;
using Google.Apis.Download;
using Google.Apis.Drive.v3;
using Google.Apis.Services;

namespace Sonneville.Google.Wrappers.Files
{
    public interface IWatchRequest
    {
        /// <summary>The ID of the file.</summary>
        string FileId { get; }

        /// <summary>Whether the user is acknowledging the risk of downloading known malware or other abusive files.
        /// This is only applicable when alt=media.</summary>
        /// 
        ///             [default: false]
        bool? AcknowledgeAbuse { get; set; }

        /// <summary>Gets the method name.</summary>
        string MethodName { get; }

        /// <summary>Gets the HTTP method.</summary>
        string HttpMethod { get; }

        /// <summary>Gets the REST path.</summary>
        string RestPath { get; }

        /// <summary>Gets the media downloader.</summary>
        IMediaDownloader MediaDownloader { get; }

        FilesResource.WatchRequest.AltEnum? Alt { get; set; }

        string Fields { get; set; }

        string Key { get; set; }

        string OauthToken { get; set; }

        bool? PrettyPrint { get; set; }

        string QuotaUser { get; set; }

        string UserIp { get; set; }

        ETagAction ETagAction { get; set; }

        IDictionary<string, IParameter> RequestParameters { get; }

        IClientService Service { get; }

        /// <summary>Synchronously download the media into the given stream.</summary>
        void Download(Stream stream);

        /// <summary>Asynchronously download the media into the given stream.</summary>
        Task<IDownloadProgress> DownloadAsync(Stream stream);

        /// <summary>Asynchronously download the media into the given stream.</summary>
        Task<IDownloadProgress> DownloadAsync(Stream stream, CancellationToken cancellationToken);

        IChannel Execute();

        Stream ExecuteAsStream();

        Task<IChannel> ExecuteAsync();

        Task<IChannel> ExecuteAsync(CancellationToken cancellationToken);

        Task<Stream> ExecuteAsStreamAsync();

        Task<Stream> ExecuteAsStreamAsync(CancellationToken cancellationToken);

        HttpRequestMessage CreateRequest(bool? overrideGZipEnabled);
    }
}