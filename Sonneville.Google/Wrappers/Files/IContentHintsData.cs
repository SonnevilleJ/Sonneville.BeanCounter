using Google.Apis.Drive.v3.Data;

namespace Sonneville.Google.Wrappers.Files
{
    public interface IContentHintsData
    {
        /// <summary>Text to be indexed for the file to improve fullText queries. This is limited to 128KB in length
        /// and may contain HTML elements.</summary>
        string IndexableText { get; set; }

        /// <summary>A thumbnail for the file. This will only be used if Drive cannot generate a standard
        /// thumbnail.</summary>
        IThumbnailData Thumbnail { get; set; }

        File.ContentHintsData Impl { get; }
    }

    public class ContentHintsData : IContentHintsData
    {
        public ContentHintsData(File.ContentHintsData impl)
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