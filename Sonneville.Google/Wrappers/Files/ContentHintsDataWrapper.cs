using Google.Apis.Drive.v3.Data;

namespace Sonneville.Google.Wrappers.Files
{
    public class ContentHintsDataWrapper : IContentHintsData
    {
        public ContentHintsDataWrapper(File.ContentHintsData impl)
        {
            Impl = impl;
        }

        public File.ContentHintsData Impl { get; }

        public string IndexableText
        {
            get { return Impl.IndexableText; }
            set { Impl.IndexableText = value; }
        }

        public IThumbnailData Thumbnail
        {
            get { return new ThumbnailDataWrapper(Impl.Thumbnail); }
            set { Impl.Thumbnail = value.Impl; }
        }
    }
}