using System;
using Google.Apis.Drive.v3.Data;
using Sonneville.Google.Wrappers.Files;

namespace Sonneville.Google.Wrappers.Changes
{
    public interface IChange
    {
        /// <summary>The updated state of the file. Present if the file has not been removed.</summary>
        IFile File { get; set; }

        /// <summary>The ID of the file which has changed.</summary>
        string FileId { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "drive#change".</summary>
        string Kind { get; set; }

        /// <summary>Whether the file has been removed from the view of the changes list, for example by deletion or
        /// lost access.</summary>
        bool? Removed { get; set; }

        /// <summary>The time of this change (RFC 3339 date-time).</summary>
        string TimeRaw { get; set; }

        /// <summary><seealso cref="T:System.DateTime" /> representation of <see cref="P:Google.Apis.Drive.v3.Data.Change.TimeRaw" />.</summary>
        DateTime? Time { get; set; }

        /// <summary>The ETag of the item.</summary>
        string ETag { get; set; }

        Change Impl { get; }
    }

    public class ChangeWrapper : IChange
    {
        public ChangeWrapper(Change impl)
        {
            Impl = impl;
        }

        public Change Impl { get; }

        public IFile File
        {
            get { return new FileWrapper(Impl.File); }
            set { Impl.File = value.Impl; }
        }

        public string FileId
        {
            get { return Impl.FileId; }
            set { Impl.FileId = value; }
        }

        public string Kind
        {
            get { return Impl.Kind; }
            set { Impl.Kind = value; }
        }

        public bool? Removed
        {
            get { return Impl.Removed; }
            set { Impl.Removed = value; }
        }

        public string TimeRaw
        {
            get { return Impl.TimeRaw; }
            set { Impl.TimeRaw = value; }
        }

        public DateTime? Time
        {
            get { return Impl.Time; }
            set { Impl.Time = value; }
        }

        public string ETag
        {
            get { return Impl.ETag; }
            set { Impl.ETag = value; }
        }
    }
}