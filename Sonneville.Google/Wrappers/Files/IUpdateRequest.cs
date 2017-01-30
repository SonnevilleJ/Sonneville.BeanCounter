using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis;
using Google.Apis.Discovery;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using File = Google.Apis.Drive.v3.Data.File;

namespace Sonneville.Google.Wrappers.Files
{
    public interface IUpdateRequest
    {
        /// <summary>The ID of the file.</summary>
        string FileId { get; }

        /// <summary>A comma-separated list of parent IDs to add.</summary>
        string AddParents { get; set; }

        /// <summary>Whether to set the 'keepForever' field in the new head revision. This is only applicable to
        /// files with binary content in Drive.</summary>
        /// 
        ///             [default: false]
        bool? KeepRevisionForever { get; set; }

        /// <summary>A language hint for OCR processing during image import (ISO 639-1 code).</summary>
        string OcrLanguage { get; set; }

        /// <summary>A comma-separated list of parent IDs to remove.</summary>
        string RemoveParents { get; set; }

        /// <summary>Whether to use the uploaded content as indexable text.</summary>
        /// 
        ///             [default: false]
        bool? UseContentAsIndexableText { get; set; }

        /// <summary>Gets the method name.</summary>
        string MethodName { get; }

        /// <summary>Gets the HTTP method.</summary>
        string HttpMethod { get; }

        /// <summary>Gets the REST path.</summary>
        string RestPath { get; }

        FilesResource.UpdateRequest.AltEnum? Alt { get; set; }

        string Fields { get; set; }

        string Key { get; set; }

        string OauthToken { get; set; }

        bool? PrettyPrint { get; set; }

        string QuotaUser { get; set; }

        string UserIp { get; set; }

        ETagAction ETagAction { get; set; }

        IDictionary<string, IParameter> RequestParameters { get; }

        IClientService Service { get; }

        FilesResource.UpdateRequest Impl { get; }

        IFile Execute();

        Stream ExecuteAsStream();

        Task ExecuteAsync();

        Task ExecuteAsync(CancellationToken cancellationToken);

        Task<Stream> ExecuteAsStreamAsync();

        Task<Stream> ExecuteAsStreamAsync(CancellationToken cancellationToken);

        HttpRequestMessage CreateRequest(bool? overrideGZipEnabled);
    }

    public class UpdateRequestWrapper : IUpdateRequest
    {
        public UpdateRequestWrapper(FilesResource.UpdateRequest impl)
        {
            Impl = impl;
        }

        public FilesResource.UpdateRequest Impl { get; }

        public string FileId => Impl.FileId;

        public string AddParents
        {
            get { return Impl.AddParents; }
            set { Impl.AddParents = value; }
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

        public string RemoveParents
        {
            get { return Impl.RemoveParents; }
            set { Impl.RemoveParents = value; }
        }

        public bool? UseContentAsIndexableText
        {
            get { return Impl.UseContentAsIndexableText; }
            set { Impl.UseContentAsIndexableText = value; }
        }

        public string MethodName => Impl.MethodName;

        public string HttpMethod => Impl.HttpMethod;

        public string RestPath => Impl.RestPath;

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