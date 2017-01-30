namespace Sonneville.Google.Wrappers.Files
{
    public interface IThumbnailData
    {
        /// <summary>The thumbnail data encoded with URL-safe Base64 (RFC 4648 section 5).</summary>
        string Image { get; set; }

        /// <summary>The MIME type of the thumbnail.</summary>
        string MimeType { get; set; }
    }
}