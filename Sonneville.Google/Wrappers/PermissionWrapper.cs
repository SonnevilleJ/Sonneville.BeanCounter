using System;
using Google.Apis.Drive.v3.Data;

namespace Sonneville.Google.Wrappers
{
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