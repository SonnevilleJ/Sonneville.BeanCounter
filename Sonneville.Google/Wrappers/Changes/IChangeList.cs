using System.Collections.Generic;

namespace Sonneville.Google.Wrappers.Changes
{
    public interface IChangeList
    {
        /// <summary>The page of changes.</summary>
        IList<IChange> Changes { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "drive#changeList".</summary>
        string Kind { get; set; }

        /// <summary>The starting page token for future changes. This will be present only if the end of the current
        /// changes list has been reached.</summary>
        string NewStartPageToken { get; set; }

        /// <summary>The page token for the next page of changes. This will be absent if the end of the current changes
        /// list has been reached.</summary>
        string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        string ETag { get; set; }
    }
}