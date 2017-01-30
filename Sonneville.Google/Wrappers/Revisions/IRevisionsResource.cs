using Google.Apis.Drive.v3;

namespace Sonneville.Google.Wrappers.Revisions
{
    public interface IRevisionsResource
    {
        /// <summary>Permanently deletes a revision. This method is only applicable to files with binary content in
        /// Drive.</summary>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="revisionId">The ID of the
        /// revision.</param>
        IDeleteRequest Delete(string fileId, string revisionId);

        /// <summary>Gets a revision's metadata or content by ID.</summary>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="revisionId">The ID of the
        /// revision.</param>
        IGetRequest Get(string fileId, string revisionId);

        /// <summary>Lists a file's revisions.</summary>
        /// <param name="fileId">The ID of the file.</param>
        IListRequest List(string fileId);

        /// <summary>Updates a revision with patch semantics.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="revisionId">The ID of the
        /// revision.</param>
        IUpdateRequest Update(IRevision body, string fileId, string revisionId);

        RevisionsResource Impl { get; }
    }

    public class RevisionsResourceWrapper : IRevisionsResource
    {
        public RevisionsResourceWrapper(RevisionsResource impl)
        {
            Impl = impl;
        }

        public RevisionsResource Impl { get; }

        public IDeleteRequest Delete(string fileId, string revisionId)
        {
            return new DeleteRequestWrapper(Impl.Delete(fileId, revisionId));
        }

        public IGetRequest Get(string fileId, string revisionId)
        {
            return new GetRequestWrapper(Impl.Get(fileId, revisionId));
        }

        public IListRequest List(string fileId)
        {
            return new ListRequestWrapper(Impl.List(fileId));
        }

        public IUpdateRequest Update(IRevision body, string fileId, string revisionId)
        {
            return new UpdateRequestWrapper(Impl.Update(body.Impl, fileId, revisionId));
        }
    }
}