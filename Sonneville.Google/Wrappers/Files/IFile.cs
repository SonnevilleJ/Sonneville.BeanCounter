using System;
using System.Collections.Generic;

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
    }
}