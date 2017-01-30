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
    }
}