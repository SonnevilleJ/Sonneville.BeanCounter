using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Download;

namespace Sonneville.Google.Wrappers.Revisions
{
    public interface IGetRequest
    {
        /// <summary>The ID of the file.</summary>
        string FileId { get; }

        /// <summary>The ID of the revision.</summary>
        string RevisionId { get; }

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

        /// <summary>Synchronously download the media into the given stream.</summary>
        void Download(Stream stream);

        /// <summary>Asynchronously download the media into the given stream.</summary>
        Task<IDownloadProgress> DownloadAsync(Stream stream);

        /// <summary>Asynchronously download the media into the given stream.</summary>
        Task<IDownloadProgress> DownloadAsync(Stream stream, CancellationToken cancellationToken);
    }
}