using Google.Apis.Drive.v3;

namespace Sonneville.Google.Wrappers.Permissions
{
    public interface IGetRequest
    {
        /// <summary>The ID of the file.</summary>
        string FileId { get; }

        /// <summary>The ID of the permission.</summary>
        string PermissionId { get; }

        /// <summary>Gets the method name.</summary>
        string MethodName { get; }

        /// <summary>Gets the HTTP method.</summary>
        string HttpMethod { get; }

        /// <summary>Gets the REST path.</summary>
        string RestPath { get; }

        PermissionsResource.GetRequest Impl { get; }
    }

    public class GetRequestWrapper : IGetRequest
    {
        public GetRequestWrapper(PermissionsResource.GetRequest impl)
        {
            Impl = impl;
        }

        public PermissionsResource.GetRequest Impl { get; }

        public string FileId => Impl.FileId;

        public string PermissionId => Impl.PermissionId;

        public string MethodName => Impl.MethodName;

        public string HttpMethod => Impl.HttpMethod;

        public string RestPath => Impl.RestPath;
    }
}