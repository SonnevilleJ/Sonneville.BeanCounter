using System;
using System.Collections.Generic;
using System.Linq;
using Google.Apis.Drive.v3.Data;

namespace Sonneville.Google.Wrappers.Files
{
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
            get { return new ContentHintsDataWrapper(Impl.ContentHints); }
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
