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
    }
}