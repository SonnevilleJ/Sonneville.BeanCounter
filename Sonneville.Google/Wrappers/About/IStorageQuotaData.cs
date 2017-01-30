using static Google.Apis.Drive.v3.Data.About;

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

        StorageQuotaData Impl { get; }
    }

    public class StorageQuotaDataWrapper : IStorageQuotaData
    {
        public StorageQuotaDataWrapper(StorageQuotaData impl)
        {
            Impl = impl;
        }

        public StorageQuotaData Impl { get; }

        public long? Limit
        {
            get { return Impl.Limit; }
            set { Impl.Limit = value; }
        }

        public long? Usage
        {
            get { return Impl.Usage; }
            set { Impl.Usage = value; }
        }

        public long? UsageInDrive
        {
            get { return Impl.UsageInDrive; }
            set { Impl.UsageInDrive = value; }
        }

        public long? UsageInDriveTrash
        {
            get { return Impl.UsageInDriveTrash; }
            set { Impl.UsageInDriveTrash = value; }
        }
    }
}