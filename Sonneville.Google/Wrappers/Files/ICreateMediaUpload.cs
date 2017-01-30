using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Upload;

namespace Sonneville.Google.Wrappers.Files
{
    public interface ICreateMediaUpload
    {
        /// <summary>Data format for the response.</summary>
        /// 
        ///             [default: json]
        FilesResource.CreateMediaUpload.AltEnum? Alt { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and
        /// reports. Required unless you provide an OAuth 2.0 token.</summary>
        string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// 
        ///             [default: true]
        bool? PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters. Overrides userIp if both are
        /// provided.</summary>
        string QuotaUser { get; set; }

        /// <summary>IP address of the site where the request originates. Use this if you want to enforce per-user
        /// limits.</summary>
        string UserIp { get; set; }

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

        IFile ResponseBody { get; }

        IClientService Service { get; }

        string Path { get; }

        string HttpMethod { get; }

        Stream ContentStream { get; }

        string ContentType { get; }

        IFile Body { get; set; }

        int ChunkSize { get; set; }

        event Action<IFile> ResponseReceived;

        IUploadProgress GetProgress();

        IUploadProgress Upload();

        Task<IUploadProgress> UploadAsync();

        Task<IUploadProgress> UploadAsync(CancellationToken cancellationToken);

        IUploadProgress Resume();

        IUploadProgress Resume(Uri uploadUri);

        Task<IUploadProgress> ResumeAsync();

        Task<IUploadProgress> ResumeAsync(CancellationToken cancellationToken);

        Task<IUploadProgress> ResumeAsync(Uri uploadUri);

        Task<IUploadProgress> ResumeAsync(Uri uploadUri, CancellationToken cancellationToken);

        event Action<IUploadProgress> ProgressChanged;

        event Action<IUploadSessionData> UploadSessionData;
    }
}