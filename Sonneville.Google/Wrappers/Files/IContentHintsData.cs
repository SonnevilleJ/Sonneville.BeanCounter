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
    }
}