using Google.Apis.Drive.v3.Data;

namespace Sonneville.Google.Wrappers.Files
{
    public class VideoMediaMetadataDataWrapper : IVideoMediaMetadataData
    {
        public VideoMediaMetadataDataWrapper(File.VideoMediaMetadataData impl)
        {
            Impl = impl;
        }

        public File.VideoMediaMetadataData Impl { get; }

        public long? DurationMillis
        {
            get { return Impl.DurationMillis; }
            set { Impl.DurationMillis = value; }
        }

        public int? Height
        {
            get { return Impl.Height; }
            set { Impl.Height = value; }
        }

        public int? Width
        {
            get { return Impl.Width; }
            set { Impl.Width = value; }
        }
    }
}