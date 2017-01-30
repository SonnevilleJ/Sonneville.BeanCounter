namespace Sonneville.Google.Wrappers.Comments
{
    public interface ICommentsResource
    {
        /// <summary>Creates a new comment on a file.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID of the file.</param>
        ICreateRequest Create(IComment body, string fileId);

        /// <summary>Deletes a comment.</summary>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="commentId">The ID of the comment.</param>
        IDeleteRequest Delete(string fileId, string commentId);

        /// <summary>Gets a comment by ID.</summary>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="commentId">The ID of the comment.</param>
        IGetRequest Get(string fileId, string commentId);

        /// <summary>Lists a file's comments.</summary>
        /// <param name="fileId">The ID of the file.</param>
        IListRequest List(string fileId);

        /// <summary>Updates a comment with patch semantics.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="commentId">The ID of the comment.</param>
        IUpdateRequest Update(IComment body, string fileId, string commentId);
    }
}