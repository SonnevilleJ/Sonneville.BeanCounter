using System.Collections.Generic;

namespace Sonneville.Google.Wrappers.Files
{
    public interface IFileList
    {
        /// <summary>The page of files.</summary>
        IList<IFile> Files { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "drive#fileList".</summary>
        string Kind { get; set; }

        /// <summary>The page token for the next page of files. This will be absent if the end of the files list has
        /// been reached.</summary>
        string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        string ETag { get; set; }
    }
}