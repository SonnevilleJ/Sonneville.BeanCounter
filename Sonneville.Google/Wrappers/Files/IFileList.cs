using System.Collections.Generic;
using System.Linq;
using Google.Apis.Drive.v3.Data;

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

        FileList Impl { get; }
    }

    public class FileListWrapper : IFileList
    {
        public FileListWrapper(FileList impl)
        {
            Impl = impl;
        }

        public FileList Impl { get; }

        public IList<IFile> Files
        {
            get { return Impl.Files.Select(file => new FileWrapper(file)).Cast<IFile>().ToList(); }
            set { Impl.Files = value.Select(file => file.Impl).ToList(); }
        }

        public string Kind
        {
            get { return Impl.Kind; }
            set { Impl.Kind = value; }
        }

        public string NextPageToken
        {
            get { return Impl.NextPageToken; }
            set { Impl.NextPageToken = value; }
        }

        public string ETag
        {
            get { return Impl.ETag; }
            set { Impl.ETag = value; }
        }
    }
}