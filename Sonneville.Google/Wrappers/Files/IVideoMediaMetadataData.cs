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
    }
}