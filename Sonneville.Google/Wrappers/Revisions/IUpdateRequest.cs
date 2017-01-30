using Google.Apis.Drive.v3;

namespace Sonneville.Google.Wrappers.Revisions
{
    public interface IUpdateRequest
    {
        /// <summary>The ID of the file.</summary>
        string FileId { get; }

        /// <summary>The ID of the revision.</summary>
        string RevisionId { get; }

        /// <summary>Gets the method name.</summary>
        string MethodName { get; }

        /// <summary>Gets the HTTP method.</summary>
        string HttpMethod { get; }

        /// <summary>Gets the REST path.</summary>
        string RestPath { get; }

        RevisionsResource.UpdateRequest Impl { get; }
    }

    public class UpdateRequestWrapper : IUpdateRequest
    {
        public UpdateRequestWrapper(RevisionsResource.UpdateRequest impl)
        {
            Impl = impl;
        }

        public RevisionsResource.UpdateRequest Impl { get; }

        public string FileId => Impl.FileId;

        public string RevisionId => Impl.RevisionId;

        public string MethodName => Impl.MethodName;

        public string HttpMethod => Impl.HttpMethod;

        public string RestPath => Impl.RestPath;
    }
}