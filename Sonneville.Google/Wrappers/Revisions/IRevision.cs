using System;
using Google.Apis.Drive.v3.Data;

namespace Sonneville.Google.Wrappers.Revisions
{
    public interface IRevision
    {
        /// <summary>The ID of the revision.</summary>
        string Id { get; set; }

        /// <summary>Whether to keep this revision forever, even if it is no longer the head revision. If not set, the
        /// revision will be automatically purged 30 days after newer content is uploaded. This can be set on a maximum
        /// of 200 revisions for a file. This field is only applicable to files with binary content in Drive.</summary>
        bool? KeepForever { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "drive#revision".</summary>
        string Kind { get; set; }

        /// <summary>The last user to modify this revision.</summary>
        IUser LastModifyingUser { get; set; }

        /// <summary>The MD5 checksum of the revision's content. This is only applicable to files with binary content in
        /// Drive.</summary>
        string Md5Checksum { get; set; }

        /// <summary>The MIME type of the revision.</summary>
        string MimeType { get; set; }

        /// <summary>The last time the revision was modified (RFC 3339 date-time).</summary>
        string ModifiedTimeRaw { get; set; }

        /// <summary><seealso cref="T:System.DateTime" /> representation of <see cref="P:Google.Apis.Drive.v3.Data.Revision.ModifiedTimeRaw" />.</summary>
        DateTime? ModifiedTime { get; set; }

        /// <summary>The original filename used to create this revision. This is only applicable to files with binary
        /// content in Drive.</summary>
        string OriginalFilename { get; set; }

        /// <summary>Whether subsequent revisions will be automatically republished. This is only applicable to Google
        /// Docs.</summary>
        bool? PublishAuto { get; set; }

        /// <summary>Whether this revision is published. This is only applicable to Google Docs.</summary>
        bool? Published { get; set; }

        /// <summary>Whether this revision is published outside the domain. This is only applicable to Google
        /// Docs.</summary>
        bool? PublishedOutsideDomain { get; set; }

        /// <summary>The size of the revision's content in bytes. This is only applicable to files with binary content
        /// in Drive.</summary>
        long? Size { get; set; }

        /// <summary>The ETag of the item.</summary>
        string ETag { get; set; }

        Revision Impl { get; }
    }

    public class RevisionWrapper : IRevision
    {
        public RevisionWrapper(Revision impl)
        {
            Impl = impl;
        }

        public Revision Impl { get; }

        public string Id
        {
            get { return Impl.Id; }
            set { Impl.Id = value; }
        }

        public bool? KeepForever
        {
            get { return Impl.KeepForever; }
            set { Impl.KeepForever = value; }
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

        public string OriginalFilename
        {
            get { return Impl.OriginalFilename; }
            set { Impl.OriginalFilename = value; }
        }

        public bool? PublishAuto
        {
            get { return Impl.PublishAuto; }
            set { Impl.PublishAuto = value; }
        }

        public bool? Published
        {
            get { return Impl.Published; }
            set { Impl.Published = value; }
        }

        public bool? PublishedOutsideDomain
        {
            get { return Impl.PublishedOutsideDomain; }
            set { Impl.PublishedOutsideDomain = value; }
        }

        public long? Size
        {
            get { return Impl.Size; }
            set { Impl.Size = value; }
        }

        public string ETag
        {
            get { return Impl.ETag; }
            set { Impl.ETag = value; }
        }
    }
}