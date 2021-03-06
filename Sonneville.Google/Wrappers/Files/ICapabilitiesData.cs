using Google.Apis.Drive.v3.Data;

namespace Sonneville.Google.Wrappers.Files
{
    public interface ICapabilitiesData
    {
        /// <summary>Whether the user can comment on the file.</summary>
        bool? CanComment { get; set; }

        /// <summary>Whether the user can copy the file.</summary>
        bool? CanCopy { get; set; }

        /// <summary>Whether the user can edit the file's content.</summary>
        bool? CanEdit { get; set; }

        /// <summary>Whether the current user has read access to the Revisions resource of the file.</summary>
        bool? CanReadRevisions { get; set; }

        /// <summary>Whether the user can modify the file's permissions and sharing settings.</summary>
        bool? CanShare { get; set; }

        File.CapabilitiesData Impl { get; }
    }

    public class CapabilitiesDataWrapper : ICapabilitiesData
    {
        public CapabilitiesDataWrapper(File.CapabilitiesData impl)
        {
            Impl = impl;
        }

        public File.CapabilitiesData Impl { get; }

        public bool? CanComment
        {
            get { return Impl.CanComment; }
            set { Impl.CanComment = value; }
        }

        public bool? CanCopy
        {
            get { return Impl.CanCopy; }
            set { Impl.CanCopy = value; }
        }

        public bool? CanEdit
        {
            get { return Impl.CanEdit; }
            set { Impl.CanEdit = value; }
        }

        public bool? CanReadRevisions
        {
            get { return Impl.CanReadRevisions; }
            set { Impl.CanReadRevisions = value; }
        }

        public bool? CanShare
        {
            get { return Impl.CanShare; }
            set { Impl.CanShare = value; }
        }
    }
}
