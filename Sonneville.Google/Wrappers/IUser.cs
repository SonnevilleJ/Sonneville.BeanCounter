namespace Sonneville.Google.Wrappers
{
    public interface IUser
    {
        /// <summary>A plain text displayable name for this user.</summary>
        string DisplayName { get; set; }

        /// <summary>The email address of the user. This may not be present in certain contexts if the user has not made
        /// their email address visible to the requester.</summary>
        string EmailAddress { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "drive#user".</summary>
        string Kind { get; set; }

        /// <summary>Whether this user is the requesting user.</summary>
        bool? Me { get; set; }

        /// <summary>The user's ID as visible in Permission resources.</summary>
        string PermissionId { get; set; }

        /// <summary>A link to the user's profile photo, if available.</summary>
        string PhotoLink { get; set; }

        /// <summary>The ETag of the item.</summary>
        string ETag { get; set; }
    }
}