using System.Collections.Generic;

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
    }
}