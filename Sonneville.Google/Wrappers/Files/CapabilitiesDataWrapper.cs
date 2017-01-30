using Google.Apis.Drive.v3.Data;

namespace Sonneville.Google.Wrappers.Files
{
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