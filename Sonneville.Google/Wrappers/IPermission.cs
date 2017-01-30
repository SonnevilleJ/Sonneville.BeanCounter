using System;

namespace Sonneville.Google.Wrappers
{
    public interface IPermission
    {
        /// <summary>Whether the permission allows the file to be discovered through search. This is only applicable for
        /// permissions of type domain or anyone.</summary>
        bool? AllowFileDiscovery { get; set; }

        /// <summary>A displayable name for users, groups or domains.</summary>
        string DisplayName { get; set; }

        /// <summary>The domain to which this permission refers.</summary>
        string Domain { get; set; }

        /// <summary>The email address of the user or group to which this permission refers.</summary>
        string EmailAddress { get; set; }

        /// <summary>The time at which this permission will expire (RFC 3339 date-time).</summary>
        string ExpirationTimeRaw { get; set; }

        /// <summary><seealso cref="T:System.DateTime" /> representation of <see cref="P:Google.Apis.Drive.v3.Data.Permission.ExpirationTimeRaw" />.</summary>
        DateTime? ExpirationTime { get; set; }

        /// <summary>The ID of this permission. This is a unique identifier for the grantee, and is published in User
        /// resources as permissionId.</summary>
        string Id { get; set; }

        /// <summary>Identifies what kind of resource this is. Value: the fixed string "drive#permission".</summary>
        string Kind { get; set; }

        /// <summary>A link to the user's profile photo, if available.</summary>
        string PhotoLink { get; set; }

        /// <summary>The role granted by this permission. Valid values are: - owner - writer - commenter -
        /// reader</summary>
        string Role { get; set; }

        /// <summary>The type of the grantee. Valid values are: - user - group - domain - anyone</summary>
        string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        string ETag { get; set; }
    }
}