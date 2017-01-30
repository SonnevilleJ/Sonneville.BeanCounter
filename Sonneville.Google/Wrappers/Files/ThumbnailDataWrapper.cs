using Google.Apis.Drive.v3.Data;

namespace Sonneville.Google.Wrappers.Files
{
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