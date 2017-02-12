using Google.Apis.Drive.v3.Data;

namespace Sonneville.Google.Wrappers.Data
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

        User Impl { get; }
    }

    public class UserWrapper : IUser
    {
        public UserWrapper(User impl)
        {
            Impl = impl;
        }

        public User Impl { get; }

        public string DisplayName
        {
            get { return Impl.DisplayName; }
            set { Impl.DisplayName = value; }
        }

        public string EmailAddress
        {
            get { return Impl.EmailAddress; }
            set { Impl.EmailAddress = value; }
        }

        public string Kind
        {
            get { return Impl.Kind; }
            set { Impl.Kind = value; }
        }

        public bool? Me
        {
            get { return Impl.Me; }
            set { Impl.Me = value; }
        }

        public string PermissionId
        {
            get { return Impl.PermissionId; }
            set { Impl.PermissionId = value; }
        }

        public string PhotoLink
        {
            get { return Impl.PhotoLink; }
            set { Impl.PhotoLink = value; }
        }

        public string ETag
        {
            get { return Impl.ETag; }
            set { Impl.ETag = value; }
        }
    }
}