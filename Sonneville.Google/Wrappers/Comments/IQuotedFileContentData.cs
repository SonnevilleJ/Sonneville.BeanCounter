using Google.Apis.Drive.v3.Data;

namespace Sonneville.Google.Wrappers.Comments
{
    public interface IQuotedFileContentData
    {
        /// <summary>The MIME type of the quoted content.</summary>
        string MimeType { get; set; }

        /// <summary>The quoted content itself. This is interpreted as plain text if set through the API.</summary>
        string Value { get; set; }

        Comment.QuotedFileContentData Impl { get; }
    }

    public class QuotedFileContentDataWrapper : IQuotedFileContentData
    {
        public QuotedFileContentDataWrapper(Comment.QuotedFileContentData impl)
        {
            Impl = impl;
        }

        public Comment.QuotedFileContentData Impl { get; }

        public string MimeType
        {
            get { return Impl.MimeType; }
            set { Impl.MimeType = value; }
        }

        public string Value
        {
            get { return Impl.Value; }
            set { Impl.Value = value; }
        }
    }
}