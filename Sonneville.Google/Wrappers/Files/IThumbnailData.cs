using Google.Apis.Drive.v3.Data;

namespace Sonneville.Google.Wrappers.Files
{
    public interface IThumbnailData
    {
        /// <summary>The thumbnail data encoded with URL-safe Base64 (RFC 4648 section 5).</summary>
        string Image { get; set; }

        /// <summary>The MIME type of the thumbnail.</summary>
        string MimeType { get; set; }

        File.ContentHintsData.ThumbnailData Impl { get; }
    }

    public class ThumbnailDataWrapper : IThumbnailData
    {
        public ThumbnailDataWrapper(File.ContentHintsData.ThumbnailData impl)
        {
            Impl = impl;
        }

        public File.ContentHintsData.ThumbnailData Impl { get; }

        public string Image
        {
            get { return Impl.Image; }
            set { Impl.Image = value; }
        }

        public string MimeType
        {
            get { return Impl.MimeType; }
            set { Impl.MimeType = value; }
        }
    }
}