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
    public class CreateRequestWrapper : ICreateRequest
    {
        public CreateRequestWrapper(FilesResource.CreateRequest impl)
        {
            Impl = impl;
        }

        public FilesResource.CreateRequest Impl { get; }

        public bool? IgnoreDefaultVisibility
        {
            get { return Impl.IgnoreDefaultVisibility; }
            set { Impl.IgnoreDefaultVisibility = value; }
        }

        public bool? KeepRevisionForever
        {
            get { return Impl.KeepRevisionForever; }
            set { Impl.KeepRevisionForever = value; }
        }

        public string OcrLanguage
        {
            get { return Impl.OcrLanguage; }
            set { Impl.OcrLanguage = value; }
        }

        public bool? UseContentAsIndexableText
        {
            get { return Impl.UseContentAsIndexableText; }
            set { Impl.UseContentAsIndexableText = value; }
        }

        public string MethodName
        {
            get { return Impl.MethodName; }
        }

        public string HttpMethod
        {
            get { return Impl.HttpMethod; }
        }

        public string RestPath
        {
            get { return Impl.RestPath; }
        }

        public FilesResource.CreateMediaUpload.AltEnum? Alt
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

        public IDictionary<string, IParameter> RequestParameters
        {
            get { return Impl.RequestParameters; }
        }

        public IClientService Service
        {
            get { return Impl.Service; }
        }

        public IFile Execute()
        {
            return Impl.Execute();
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