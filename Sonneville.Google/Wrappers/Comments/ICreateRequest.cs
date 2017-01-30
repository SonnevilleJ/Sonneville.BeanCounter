using Google.Apis.Drive.v3;

namespace Sonneville.Google.Wrappers.Comments
{
    public interface ICreateRequest
    {
        /// <summary>The ID of the file.</summary>
        string FileId { get; }

        /// <summary>Gets the method name.</summary>
        string MethodName { get; }

        /// <summary>Gets the HTTP method.</summary>
        string HttpMethod { get; }

        /// <summary>Gets the REST path.</summary>
        string RestPath { get; }

        CommentsResource.CreateRequest Impl { get; }
    }

    public class CreateRequestWrapper : ICreateRequest
    {
        public CreateRequestWrapper(CommentsResource.CreateRequest impl)
        {
            Impl = impl;
        }

        public CommentsResource.CreateRequest Impl { get; }

        public string FileId => Impl.FileId;

        public string MethodName => Impl.MethodName;

        public string HttpMethod => Impl.HttpMethod;

        public string RestPath => Impl.RestPath;
    }
}