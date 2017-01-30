using Google.Apis.Drive.v3.Data;

namespace Sonneville.Google.Wrappers.Changes
{
    public interface IStartPageToken
    {
        /// <summary>Identifies what kind of resource this is. Value: the fixed string "drive#startPageToken".</summary>
        string Kind { get; set; }

        /// <summary>The starting page token for listing changes.</summary>
        string StartPageTokenValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        string ETag { get; set; }

        StartPageToken Impl { get; }
    }

    public class StartPageTokenWrapper : IStartPageToken
    {
        public StartPageTokenWrapper(StartPageToken impl)
        {
            Impl = impl;
        }

        public StartPageToken Impl { get; }

        public string Kind
        {
            get { return Impl.Kind; }
            set { Impl.Kind = value; }
        }

        public string StartPageTokenValue
        {
            get { return Impl.StartPageTokenValue; }
            set { Impl.StartPageTokenValue = value; }
        }

        public string ETag
        {
            get { return Impl.ETag; }
            set { Impl.ETag = value; }
        }
    }
}