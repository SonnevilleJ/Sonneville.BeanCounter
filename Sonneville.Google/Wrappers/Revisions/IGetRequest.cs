using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Download;
using Google.Apis.Drive.v3;

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

        RevisionsResource.GetRequest Impl { get; }

        /// <summary>Synchronously download the media into the given stream.</summary>
        void Download(Stream stream);

        /// <summary>Asynchronously download the media into the given stream.</summary>
        Task<IDownloadProgress> DownloadAsync(Stream stream);

        /// <summary>Asynchronously download the media into the given stream.</summary>
        Task<IDownloadProgress> DownloadAsync(Stream stream, CancellationToken cancellationToken);
    }

    public class GetRequestWrapper : IGetRequest
    {
        public GetRequestWrapper(RevisionsResource.GetRequest impl)
        {
            Impl = impl;
        }

        public RevisionsResource.GetRequest Impl { get; }

        public string FileId => Impl.FileId;

        public string RevisionId => Impl.RevisionId;

        public bool? AcknowledgeAbuse
        {
            get { return Impl.AcknowledgeAbuse; }
            set { Impl.AcknowledgeAbuse = value; }
        }

        public string MethodName => Impl.MethodName;

        public string HttpMethod => Impl.HttpMethod;

        public string RestPath => Impl.RestPath;

        public IMediaDownloader MediaDownloader => Impl.MediaDownloader;

        public void Download(Stream stream)
        {
            Impl.Download(stream);
        }

        public Task<IDownloadProgress> DownloadAsync(Stream stream)
        {
            return Impl.DownloadAsync(stream);
        }

        public Task<IDownloadProgress> DownloadAsync(Stream stream, CancellationToken cancellationToken)
        {
            return Impl.DownloadAsync(stream, cancellationToken);
        }
    }
}