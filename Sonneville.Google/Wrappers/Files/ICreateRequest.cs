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
    public interface ICreateRequest
    {
        /// <summary>Whether to ignore the domain's default visibility settings for the created file. Domain
        /// administrators can choose to make all uploaded files visible to the domain by default; this parameter
        /// bypasses that behavior for the request. Permissions are still inherited from parent folders.</summary>
        /// 
        ///             [default: false]
        bool? IgnoreDefaultVisibility { get; set; }

        /// <summary>Whether to set the 'keepForever' field in the new head revision. This is only applicable to
        /// files with binary content in Drive.</summary>
        /// 
        ///             [default: false]
        bool? KeepRevisionForever { get; set; }

        /// <summary>A language hint for OCR processing during image import (ISO 639-1 code).</summary>
        string OcrLanguage { get; set; }

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

        FilesResource.CreateMediaUpload.AltEnum? Alt { get; set; }

        string Fields { get; set; }

        string Key { get; set; }

        string OauthToken { get; set; }

        bool? PrettyPrint { get; set; }

        string QuotaUser { get; set; }

        string UserIp { get; set; }

        ETagAction ETagAction { get; set; }

        IDictionary<string, IParameter> RequestParameters { get; }

        IClientService Service { get; }

        IFile Execute();

        Stream ExecuteAsStream();

        Task ExecuteAsync();

        Task ExecuteAsync(CancellationToken cancellationToken);

        Task<Stream> ExecuteAsStreamAsync();

        Task<Stream> ExecuteAsStreamAsync(CancellationToken cancellationToken);

        HttpRequestMessage CreateRequest(bool? overrideGZipEnabled);
    }
}