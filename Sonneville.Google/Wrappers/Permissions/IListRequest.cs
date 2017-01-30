using Google.Apis.Drive.v3;

namespace Sonneville.Google.Wrappers.Permissions
{
    public interface IListRequest
    {
        /// <summary>The ID of the file.</summary>
        string FileId { get; }

        /// <summary>Gets the method name.</summary>
        string MethodName { get; }

        /// <summary>Gets the HTTP method.</summary>
        string HttpMethod { get; }

        /// <summary>Gets the REST path.</summary>
        string RestPath { get; }

        PermissionsResource.ListRequest Impl { get; }
    }

    public class ListRequestWrapper : IListRequest
    {
        public ListRequestWrapper(PermissionsResource.ListRequest impl)
        {
            Impl = impl;
        }

        public PermissionsResource.ListRequest Impl { get; }

        public string FileId => Impl.FileId;

        public string MethodName => Impl.MethodName;

        public string HttpMethod => Impl.HttpMethod;

        public string RestPath => Impl.RestPath;
    }
}