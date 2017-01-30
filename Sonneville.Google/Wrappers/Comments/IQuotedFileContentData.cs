namespace Sonneville.Google.Wrappers.Comments
{
    public interface IQuotedFileContentData
    {
        /// <summary>The MIME type of the quoted content.</summary>
        string MimeType { get; set; }

        /// <summary>The quoted content itself. This is interpreted as plain text if set through the API.</summary>
        string Value { get; set; }
    }
}