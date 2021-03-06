using Google.Apis.Drive.v3.Data;

namespace Sonneville.Google.Wrappers.Files
{
    public interface IVideoMediaMetadataData
    {
        /// <summary>The duration of the video in milliseconds.</summary>
        long? DurationMillis { get; set; }

        /// <summary>The height of the video in pixels.</summary>
        int? Height { get; set; }

        /// <summary>The width of the video in pixels.</summary>
        int? Width { get; set; }

        File.VideoMediaMetadataData Impl { get; }
    }

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