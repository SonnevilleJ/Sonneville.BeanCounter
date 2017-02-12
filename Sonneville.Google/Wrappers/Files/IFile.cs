using System;
using System.Collections.Generic;
using System.Linq;
using Google.Apis.Drive.v3.Data;
using Sonneville.Google.Wrappers.Data;

namespace Sonneville.Google.Wrappers.Files
{
    public interface IFile
    {
        /// <summary>A collection of arbitrary key-value pairs which are private to the requesting app. Entries with
        /// null values are cleared in update and copy requests.</summary>
        IDictionary<string, string> AppProperties { get; set; }

        /// <summary>Capabilities the current user has on the file.</summary>
        ICapabilitiesData Capabilities { get; set; }

        /// <summary>Additional information about the content of the file. These fields are never populated in
        /// responses.</summary>
        IContentHintsData ContentHints { get; set; }

        /// <summary>The time at which the file was created (RFC 3339 date-time).</summary>
        string CreatedTimeRaw { get; set; }

        /// <summary><seealso cref="T:System.DateTime" /> representation of <see cref="P:Google.Apis.Drive.v3.Data.File.CreatedTimeRaw" />.</summary>
        DateTime? CreatedTime { get; set; }

        /// <summary>A short description of the file.</summary>
        string Description { get; set; }

        /// <summary>Whether the file has been explicitly trashed, as opposed to recursively trashed from a parent
        /// folder.</summary>
        bool? ExplicitlyTrashed { get; set; }

        /// <summary>The final component of fullFileExtension. This is only available for files with binary content in
        /// Drive.</summary>
        string FileExtension { get; set; }

        /// <summary>The color for a folder as an RGB hex string. The supported colors are published in the
        /// folderColorPalette field of the About resource. If an unsupported color is specified, the closest color in
        /// the palette will be used instead.</summary>
        string FolderColorRgb { get; set; }

        /// <summary>The full file extension extracted from the name field. May contain multiple concatenated
        /// extensions, such as "tar.gz". This is only available for files with binary content in Drive. This is
        /// automatically updated when the name field changes, however it is not cleared if the new name does not
        /// contain a valid extension.</summary>
        string FullFileExtension { get; set; }

        /// <summary>Whether this file has a thumbnail.</summary>
        bool? HasThumbnail { get; set; }

        /// <summary>The ID of the file's head revision. This is currently only available for files with binary content
        /// in Drive.</summary>
        string HeadRevisionId { get; set; }

        /// <summary>A static, unauthenticated link to the file's icon.</summary>
        string IconLink { get; set; }

        /// <summary>The ID of the file.</summary>
        string Id { get; set; }

        /// <summary>Additional metadata about image media, if available.</summary>
        IImageMediaMetadataData ImageMediaMetadata { get; set; }

        /// <summary>Whether the file was created or opened by the requesting app.</summary>
        bool? IsAppAuthorized { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "drive#file".</summary>
        string Kind { get; set; }

        /// <summary>The last user to modify the file.</summary>
        IUser LastModifyingUser { get; set; }

        /// <summary>The MD5 checksum for the content of the file. This is only applicable to files with binary content
        /// in Drive.</summary>
        string Md5Checksum { get; set; }

        /// <summary>The MIME type of the file. Drive will attempt to automatically detect an appropriate value from
        /// uploaded content if no value is provided. The value cannot be changed unless a new revision is uploaded. If
        /// a file is created with a Google Doc MIME type, the uploaded content will be imported if possible. The
        /// supported import formats are published in the About resource.</summary>
        string MimeType { get; set; }

        /// <summary>Whether the file has been modified by this user.</summary>
        bool? ModifiedByMe { get; set; }

        /// <summary>The last time the file was modified by the user (RFC 3339 date-time).</summary>
        string ModifiedByMeTimeRaw { get; set; }

        /// <summary><seealso cref="T:System.DateTime" /> representation of <see cref="P:Google.Apis.Drive.v3.Data.File.ModifiedByMeTimeRaw" />.</summary>
        DateTime? ModifiedByMeTime { get; set; }

        /// <summary>The last time the file was modified by anyone (RFC 3339 date-time). Note that setting modifiedTime
        /// will also update modifiedByMeTime for the user.</summary>
        string ModifiedTimeRaw { get; set; }

        /// <summary><seealso cref="T:System.DateTime" /> representation of <see cref="P:Google.Apis.Drive.v3.Data.File.ModifiedTimeRaw" />.</summary>
        DateTime? ModifiedTime { get; set; }

        /// <summary>The name of the file. This is not necessarily unique within a folder.</summary>
        string Name { get; set; }

        /// <summary>The original filename of the uploaded content if available, or else the original value of the name
        /// field. This is only available for files with binary content in Drive.</summary>
        string OriginalFilename { get; set; }

        /// <summary>Whether the user owns the file.</summary>
        bool? OwnedByMe { get; set; }

        /// <summary>The owners of the file. Currently, only certain legacy files may have more than one
        /// owner.</summary>
        IList<IUser> Owners { get; set; }

        /// <summary>The IDs of the parent folders which contain the file. If not specified as part of a create request,
        /// the file will be placed directly in the My Drive folder. Update requests must use the addParents and
        /// removeParents parameters to modify the values.</summary>
        IList<string> Parents { get; set; }

        /// <summary>The full list of permissions for the file. This is only available if the requesting user can share
        /// the file.</summary>
        IList<IPermission> Permissions { get; set; }

        /// <summary>A collection of arbitrary key-value pairs which are visible to all apps. Entries with null values
        /// are cleared in update and copy requests.</summary>
        IDictionary<string, string> Properties { get; set; }

        /// <summary>The number of storage quota bytes used by the file. This includes the head revision as well as
        /// previous revisions with keepForever enabled.</summary>
        long? QuotaBytesUsed { get; set; }

        /// <summary>Whether the file has been shared.</summary>
        bool? Shared { get; set; }

        /// <summary>The time at which the file was shared with the user, if applicable (RFC 3339 date-time).</summary>
        string SharedWithMeTimeRaw { get; set; }

        /// <summary><seealso cref="T:System.DateTime" /> representation of <see cref="P:Google.Apis.Drive.v3.Data.File.SharedWithMeTimeRaw" />.</summary>
        DateTime? SharedWithMeTime { get; set; }

        /// <summary>The user who shared the file with the requesting user, if applicable.</summary>
        IUser SharingUser { get; set; }

        /// <summary>The size of the file's content in bytes. This is only applicable to files with binary content in
        /// Drive.</summary>
        long? Size { get; set; }

        /// <summary>The list of spaces which contain the file. The currently supported values are 'drive',
        /// 'appDataFolder' and 'photos'.</summary>
        IList<string> Spaces { get; set; }

        /// <summary>Whether the user has starred the file.</summary>
        bool? Starred { get; set; }

        /// <summary>A short-lived link to the file's thumbnail, if available. Typically lasts on the order of hours.
        /// Only populated when the requesting app can access the file's content.</summary>
        string ThumbnailLink { get; set; }

        /// <summary>The thumbnail version for use in client-contructable thumbnail URLs or thumbnail cache
        /// invalidation.</summary>
        long? ThumbnailVersion { get; set; }

        /// <summary>Whether the file has been trashed, either explicitly or from a trashed parent folder. Only the
        /// owner may trash a file, and other users cannot see files in the owner's trash.</summary>
        bool? Trashed { get; set; }

        /// <summary>A monotonically increasing version number for the file. This reflects every change made to the file
        /// on the server, even those not visible to the user.</summary>
        long? Version { get; set; }

        /// <summary>Additional metadata about video media. This may not be available immediately upon upload.</summary>
        IVideoMediaMetadataData VideoMediaMetadata { get; set; }

        /// <summary>Whether the file has been viewed by this user.</summary>
        bool? ViewedByMe { get; set; }

        /// <summary>The last time the file was viewed by the user (RFC 3339 date-time).</summary>
        string ViewedByMeTimeRaw { get; set; }

        /// <summary><seealso cref="T:System.DateTime" /> representation of <see cref="P:Google.Apis.Drive.v3.Data.File.ViewedByMeTimeRaw" />.</summary>
        DateTime? ViewedByMeTime { get; set; }

        /// <summary>Whether users with only reader or commenter permission can copy the file's content. This affects
        /// copy, download, and print operations.</summary>
        bool? ViewersCanCopyContent { get; set; }

        /// <summary>A link for downloading the content of the file in a browser. This is only available for files with
        /// binary content in Drive.</summary>
        string WebContentLink { get; set; }

        /// <summary>A link for opening the file in a relevant Google editor or viewer in a browser.</summary>
        string WebViewLink { get; set; }

        /// <summary>Whether users with only writer permission can modify the file's permissions.</summary>
        bool? WritersCanShare { get; set; }

        /// <summary>The ETag of the item.</summary>
        string ETag { get; set; }

        File Impl { get; }
    }

    public class FileWrapper : IFile
    {
        public FileWrapper(File impl)
        {
            Impl = impl;
        }

        public File Impl { get; }

        public IDictionary<string, string> AppProperties
        {
            get { return Impl.AppProperties; }
            set { Impl.AppProperties = value; }
        }

        public ICapabilitiesData Capabilities
        {
            get { return new CapabilitiesDataWrapper(Impl.Capabilities); }
            set { Impl.Capabilities = value.Impl; }
        }

        public IContentHintsData ContentHints
        {
            get { return new ContentHintsData(Impl.ContentHints); }
            set { Impl.ContentHints = value.Impl; }
        }

        public string CreatedTimeRaw
        {
            get { return Impl.CreatedTimeRaw; }
            set { Impl.CreatedTimeRaw = value; }
        }

        public DateTime? CreatedTime
        {
            get { return Impl.CreatedTime; }
            set { Impl.CreatedTime = value; }
        }

        public string Description
        {
            get { return Impl.Description; }
            set { Impl.Description = value; }
        }

        public bool? ExplicitlyTrashed
        {
            get { return Impl.ExplicitlyTrashed; }
            set { Impl.ExplicitlyTrashed = value; }
        }

        public string FileExtension
        {
            get { return Impl.FileExtension; }
            set { Impl.FileExtension = value; }
        }

        public string FolderColorRgb
        {
            get { return Impl.FolderColorRgb; }
            set { Impl.FolderColorRgb = value; }
        }

        public string FullFileExtension
        {
            get { return Impl.FullFileExtension; }
            set { Impl.FullFileExtension = value; }
        }

        public bool? HasThumbnail
        {
            get { return Impl.HasThumbnail; }
            set { Impl.HasThumbnail = value; }
        }

        public string HeadRevisionId
        {
            get { return Impl.HeadRevisionId; }
            set { Impl.HeadRevisionId = value; }
        }

        public string IconLink
        {
            get { return Impl.IconLink; }
            set { Impl.IconLink = value; }
        }

        public string Id
        {
            get { return Impl.Id; }
            set { Impl.Id = value; }
        }

        public IImageMediaMetadataData ImageMediaMetadata
        {
            get { return new ImageMediaMetadataDataWrapper(Impl.ImageMediaMetadata); }
            set { Impl.ImageMediaMetadata = value.Impl; }
        }

        public bool? IsAppAuthorized
        {
            get { return Impl.IsAppAuthorized; }
            set { Impl.IsAppAuthorized = value; }
        }

        public string Kind
        {
            get { return Impl.Kind; }
            set { Impl.Kind = value; }
        }

        public IUser LastModifyingUser
        {
            get { return new UserWrapper(Impl.LastModifyingUser); }
            set { Impl.LastModifyingUser = value.Impl; }
        }

        public string Md5Checksum
        {
            get { return Impl.Md5Checksum; }
            set { Impl.Md5Checksum = value; }
        }

        public string MimeType
        {
            get { return Impl.MimeType; }
            set { Impl.MimeType = value; }
        }

        public bool? ModifiedByMe
        {
            get { return Impl.ModifiedByMe; }
            set { Impl.ModifiedByMe = value; }
        }

        public string ModifiedByMeTimeRaw
        {
            get { return Impl.ModifiedByMeTimeRaw; }
            set { Impl.ModifiedByMeTimeRaw = value; }
        }

        public DateTime? ModifiedByMeTime
        {
            get { return Impl.ModifiedByMeTime; }
            set { Impl.ModifiedByMeTime = value; }
        }

        public string ModifiedTimeRaw
        {
            get { return Impl.ModifiedTimeRaw; }
            set { Impl.ModifiedTimeRaw = value; }
        }

        public DateTime? ModifiedTime
        {
            get { return Impl.ModifiedTime; }
            set { Impl.ModifiedTime = value; }
        }

        public string Name
        {
            get { return Impl.Name; }
            set { Impl.Name = value; }
        }

        public string OriginalFilename
        {
            get { return Impl.OriginalFilename; }
            set { Impl.OriginalFilename = value; }
        }

        public bool? OwnedByMe
        {
            get { return Impl.OwnedByMe; }
            set { Impl.OwnedByMe = value; }
        }

        public IList<IUser> Owners
        {
            get { return Impl.Owners.Select(user => new UserWrapper(user)).Cast<IUser>().ToList(); }
            set { Impl.Owners = value.Select(user => user.Impl).ToList(); }
        }

        public IList<string> Parents
        {
            get { return Impl.Parents; }
            set { Impl.Parents = value; }
        }

        public IList<IPermission> Permissions
        {
            get { return Impl.Permissions.Select(permission => new PermissionWrapper(permission)).Cast<IPermission>().ToList(); }
            set { Impl.Permissions = value.Select(permission => permission.Impl).ToList(); }
        }

        public IDictionary<string, string> Properties
        {
            get { return Impl.Properties; }
            set { Impl.Properties = value; }
        }

        public long? QuotaBytesUsed
        {
            get { return Impl.QuotaBytesUsed; }
            set { Impl.QuotaBytesUsed = value; }
        }

        public bool? Shared
        {
            get { return Impl.Shared; }
            set { Impl.Shared = value; }
        }

        public string SharedWithMeTimeRaw
        {
            get { return Impl.SharedWithMeTimeRaw; }
            set { Impl.SharedWithMeTimeRaw = value; }
        }

        public DateTime? SharedWithMeTime
        {
            get { return Impl.SharedWithMeTime; }
            set { Impl.SharedWithMeTime = value; }
        }

        public IUser SharingUser
        {
            get { return new UserWrapper(Impl.SharingUser); }
            set { Impl.SharingUser = value.Impl; }
        }

        public long? Size
        {
            get { return Impl.Size; }
            set { Impl.Size = value; }
        }

        public IList<string> Spaces
        {
            get { return Impl.Spaces; }
            set { Impl.Spaces = value; }
        }

        public bool? Starred
        {
            get { return Impl.Starred; }
            set { Impl.Starred = value; }
        }

        public string ThumbnailLink
        {
            get { return Impl.ThumbnailLink; }
            set { Impl.ThumbnailLink = value; }
        }

        public long? ThumbnailVersion
        {
            get { return Impl.ThumbnailVersion; }
            set { Impl.ThumbnailVersion = value; }
        }

        public bool? Trashed
        {
            get { return Impl.Trashed; }
            set { Impl.Trashed = value; }
        }

        public long? Version
        {
            get { return Impl.Version; }
            set { Impl.Version = value; }
        }

        public IVideoMediaMetadataData VideoMediaMetadata
        {
            get { return new VideoMediaMetadataDataWrapper(Impl.VideoMediaMetadata); }
            set { Impl.VideoMediaMetadata = value.Impl; }
        }

        public bool? ViewedByMe
        {
            get { return Impl.ViewedByMe; }
            set { Impl.ViewedByMe = value; }
        }

        public string ViewedByMeTimeRaw
        {
            get { return Impl.ViewedByMeTimeRaw; }
            set { Impl.ViewedByMeTimeRaw = value; }
        }

        public DateTime? ViewedByMeTime
        {
            get { return Impl.ViewedByMeTime; }
            set { Impl.ViewedByMeTime = value; }
        }

        public bool? ViewersCanCopyContent
        {
            get { return Impl.ViewersCanCopyContent; }
            set { Impl.ViewersCanCopyContent = value; }
        }

        public string WebContentLink
        {
            get { return Impl.WebContentLink; }
            set { Impl.WebContentLink = value; }
        }

        public string WebViewLink
        {
            get { return Impl.WebViewLink; }
            set { Impl.WebViewLink = value; }
        }

        public bool? WritersCanShare
        {
            get { return Impl.WritersCanShare; }
            set { Impl.WritersCanShare = value; }
        }

        public string ETag
        {
            get { return Impl.ETag; }
            set { Impl.ETag = value; }
        }
    }
}