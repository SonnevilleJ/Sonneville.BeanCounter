using System;
using Google.Apis.Drive.v3.Data;

namespace Sonneville.Google.Wrappers.Data
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

        Permission Impl { get; }
    }

    public class PermissionWrapper : IPermission
    {
        public PermissionWrapper(Permission impl)
        {
            Impl = impl;
        }

        public Permission Impl { get; }

        public bool? AllowFileDiscovery
        {
            get { return Impl.AllowFileDiscovery; }
            set { Impl.AllowFileDiscovery = value; }
        }

        public string DisplayName
        {
            get { return Impl.DisplayName; }
            set { Impl.DisplayName = value; }
        }

        public string Domain
        {
            get { return Impl.Domain; }
            set { Impl.Domain = value; }
        }

        public string EmailAddress
        {
            get { return Impl.EmailAddress; }
            set { Impl.EmailAddress = value; }
        }

        public string ExpirationTimeRaw
        {
            get { return Impl.ExpirationTimeRaw; }
            set { Impl.ExpirationTimeRaw = value; }
        }

        public DateTime? ExpirationTime
        {
            get { return Impl.ExpirationTime; }
            set { Impl.ExpirationTime = value; }
        }

        public string Id
        {
            get { return Impl.Id; }
            set { Impl.Id = value; }
        }

        public string Kind
        {
            get { return Impl.Kind; }
            set { Impl.Kind = value; }
        }

        public string PhotoLink
        {
            get { return Impl.PhotoLink; }
            set { Impl.PhotoLink = value; }
        }

        public string Role
        {
            get { return Impl.Role; }
            set { Impl.Role = value; }
        }

        public string Type
        {
            get { return Impl.Type; }
            set { Impl.Type = value; }
        }

        public string ETag
        {
            get { return Impl.ETag; }
            set { Impl.ETag = value; }
        }
    }
}