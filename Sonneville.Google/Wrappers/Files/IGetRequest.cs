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
using File = Google.Apis.Drive.v3.Data.File;

namespace Sonneville.Google.Wrappers.Files
{
    public interface IGetRequest
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

        FilesResource.GetRequest.AltEnum? Alt { get; set; }

        string Fields { get; set; }

        string Key { get; set; }

        string OauthToken { get; set; }

        bool? PrettyPrint { get; set; }

        string QuotaUser { get; set; }

        string UserIp { get; set; }

        ETagAction ETagAction { get; set; }

        IDictionary<string, IParameter> RequestParameters { get; }

        IClientService Service { get; }

        FilesResource.GetRequest Impl { get; }

        /// <summary>Synchronously download the media into the given stream.</summary>
        void Download(Stream stream);

        /// <summary>Asynchronously download the media into the given stream.</summary>
        Task<IDownloadProgress> DownloadAsync(Stream stream);

        /// <summary>Asynchronously download the media into the given stream.</summary>
        Task<IDownloadProgress> DownloadAsync(Stream stream, CancellationToken cancellationToken);

        IFile Execute();

        Stream ExecuteAsStream();

        Task ExecuteAsync();

        Task ExecuteAsync(CancellationToken cancellationToken);

        Task<Stream> ExecuteAsStreamAsync();

        Task<Stream> ExecuteAsStreamAsync(CancellationToken cancellationToken);

        HttpRequestMessage CreateRequest(bool? overrideGZipEnabled);
    }

    public class GetRequestWrapper : IGetRequest
    {
        public GetRequestWrapper(FilesResource.GetRequest impl)
        {
            Impl = impl;
        }

        public FilesResource.GetRequest Impl { get; }

        public string FileId => Impl.FileId;

        public bool? AcknowledgeAbuse
        {
            get { return Impl.AcknowledgeAbuse; }
            set { Impl.AcknowledgeAbuse = value; }
        }

        public string MethodName => Impl.MethodName;

        public string HttpMethod => Impl.HttpMethod;

        public string RestPath => Impl.RestPath;

        public IMediaDownloader MediaDownloader => Impl.MediaDownloader;

        public DriveBaseServiceRequest<File>.AltEnum? Alt
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

        public IFile Execute()
        {
            return new FileWrapper(Impl.Execute());
        }

        public Stream ExecuteAsStream()
        {
            return Impl.ExecuteAsStream();
        }

        public Task ExecuteAsync()
        {
            return Impl.ExecuteAsync();
        }

        public Task ExecuteAsync(CancellationToken cancellationToken)
        {
            return Impl.ExecuteAsync(cancellationToken);
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