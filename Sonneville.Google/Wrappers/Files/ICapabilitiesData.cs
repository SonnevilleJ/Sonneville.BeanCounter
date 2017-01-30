namespace Sonneville.Google.Wrappers.Files
{
    public interface ICapabilitiesData
    {
        /// <summary>Whether the user can comment on the file.</summary>
        bool? CanComment { get; set; }

        /// <summary>Whether the user can copy the file.</summary>
        bool? CanCopy { get; set; }

        /// <summary>Whether the user can edit the file's content.</summary>
        bool? CanEdit { get; set; }

        /// <summary>Whether the current user has read access to the Revisions resource of the file.</summary>
        bool? CanReadRevisions { get; set; }

        /// <summary>Whether the user can modify the file's permissions and sharing settings.</summary>
        bool? CanShare { get; set; }
    }
}