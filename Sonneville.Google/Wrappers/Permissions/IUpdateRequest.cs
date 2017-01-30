using Google.Apis.Drive.v3;

namespace Sonneville.Google.Wrappers.Permissions
{
    public interface IUpdateRequest
    {
        /// <summary>The ID of the file.</summary>
        string FileId { get; }

        /// <summary>The ID of the permission.</summary>
        string PermissionId { get; }

        /// <summary>Whether to remove the expiration date.</summary>
        /// 
        ///             [default: false]
        bool? RemoveExpiration { get; set; }

        /// <summary>Whether to transfer ownership to the specified user and downgrade the current owner to a
        /// writer. This parameter is required as an acknowledgement of the side effect.</summary>
        /// 
        ///             [default: false]
        bool? TransferOwnership { get; set; }

        /// <summary>Gets the method name.</summary>
        string MethodName { get; }

        /// <summary>Gets the HTTP method.</summary>
        string HttpMethod { get; }

        /// <summary>Gets the REST path.</summary>
        string RestPath { get; }

        PermissionsResource.UpdateRequest Impl { get; }
    }

    public class UpdateRequestWrapper : IUpdateRequest
    {
        public UpdateRequestWrapper(PermissionsResource.UpdateRequest impl)
        {
            Impl = impl;
        }

        public PermissionsResource.UpdateRequest Impl { get; }

        public string FileId => Impl.FileId;

        public string PermissionId => Impl.PermissionId;

        public bool? RemoveExpiration
        {
            get { return Impl.RemoveExpiration; }
            set { Impl.RemoveExpiration = value; }
        }

        public bool? TransferOwnership
        {
            get { return Impl.TransferOwnership; }
            set { Impl.TransferOwnership = value; }
        }

        public string MethodName => Impl.MethodName;

        public string HttpMethod => Impl.HttpMethod;

        public string RestPath => Impl.RestPath;
    }
}