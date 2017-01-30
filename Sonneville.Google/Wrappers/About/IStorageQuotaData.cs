namespace Sonneville.Google.Wrappers.About
{
    public interface IStorageQuotaData
    {
        /// <summary>The usage limit, if applicable. This will not be present if the user has unlimited
        /// storage.</summary>
        long? Limit { get; set; }

        /// <summary>The total usage across all services.</summary>
        long? Usage { get; set; }

        /// <summary>The usage by all files in Google Drive.</summary>
        long? UsageInDrive { get; set; }

        /// <summary>The usage by trashed files in Google Drive.</summary>
        long? UsageInDriveTrash { get; set; }
    }
}