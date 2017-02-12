using System.Collections.Generic;
using Sonneville.Google.Wrappers.Data;

namespace Sonneville.Google.Wrappers.About
{
    public interface IAbout
    {
        /// <summary>Whether the user has installed the requesting app.</summary>
        bool? AppInstalled { get; set; }

        /// <summary>A map of source MIME type to possible targets for all supported exports.</summary>
        IDictionary<string, IList<string>> ExportFormats { get; set; }

        /// <summary>The currently supported folder colors as RGB hex strings.</summary>
        IList<string> FolderColorPalette { get; set; }

        /// <summary>A map of source MIME type to possible targets for all supported imports.</summary>
        IDictionary<string, IList<string>> ImportFormats { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "drive#about".</summary>
        string Kind { get; set; }

        /// <summary>A map of maximum import sizes by MIME type, in bytes.</summary>
        IDictionary<string, long?> MaxImportSizes { get; set; }

        /// <summary>The maximum upload size in bytes.</summary>
        long? MaxUploadSize { get; set; }

        /// <summary>The user's storage quota limits and usage. All fields are measured in bytes.</summary>
        IStorageQuotaData StorageQuota { get; set; }

        /// <summary>The authenticated user.</summary>
        IUser User { get; set; }

        /// <summary>The ETag of the item.</summary>
        string ETag { get; set; }

        global::Google.Apis.Drive.v3.Data.About Impl { get; }
    }

    public class AboutWrapper : IAbout
    {
        public AboutWrapper(global::Google.Apis.Drive.v3.Data.About impl)
        {
            Impl = impl;
        }

        public global::Google.Apis.Drive.v3.Data.About Impl { get; }

        public bool? AppInstalled
        {
            get { return Impl.AppInstalled; }
            set { Impl.AppInstalled = value; }
        }

        public IDictionary<string, IList<string>> ExportFormats
        {
            get { return Impl.ExportFormats; }
            set { Impl.ExportFormats = value; }
        }

        public IList<string> FolderColorPalette
        {
            get { return Impl.FolderColorPalette; }
            set { Impl.FolderColorPalette = value; }
        }

        public IDictionary<string, IList<string>> ImportFormats
        {
            get { return Impl.ImportFormats; }
            set { Impl.ImportFormats = value; }
        }

        public string Kind
        {
            get { return Impl.Kind; }
            set { Impl.Kind = value; }
        }

        public IDictionary<string, long?> MaxImportSizes
        {
            get { return Impl.MaxImportSizes; }
            set { Impl.MaxImportSizes = value; }
        }

        public long? MaxUploadSize
        {
            get { return Impl.MaxUploadSize; }
            set { Impl.MaxUploadSize = value; }
        }

        public IStorageQuotaData StorageQuota
        {
            get { return new StorageQuotaDataWrapper(Impl.StorageQuota); }
            set { Impl.StorageQuota = value.Impl; }
        }

        public IUser User
        {
            get { return new UserWrapper(Impl.User); }
            set { Impl.User = value.Impl; }
        }

        public string ETag
        {
            get { return Impl.ETag; }
            set { Impl.ETag = value; }
        }
    }
}