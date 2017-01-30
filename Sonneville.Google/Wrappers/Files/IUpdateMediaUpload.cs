using Google.Apis.Drive.v3;

namespace Sonneville.Google.Wrappers.Files
{
    public interface IUpdateMediaUpload
    {
        /// <summary>Data format for the response.</summary>
        /// 
        ///             [default: json]
        FilesResource.UpdateMediaUpload.AltEnum? Alt { get; set; }

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

        FilesResource.UpdateMediaUpload Impl { get; }
    }

    public class UpdateMediaUploadWrapper : IUpdateMediaUpload
    {
        public UpdateMediaUploadWrapper(FilesResource.UpdateMediaUpload impl)
        {
            Impl = impl;
        }

        public FilesResource.UpdateMediaUpload Impl { get; }

        public FilesResource.UpdateMediaUpload.AltEnum? Alt
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
    }
}