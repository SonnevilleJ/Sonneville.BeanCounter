using Google.Apis.Drive.v3;

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

        CommentsResource Impl { get; }
    }

    public class CommentsResourceWrapper : ICommentsResource
    {
        public CommentsResourceWrapper(CommentsResource impl)
        {
            Impl = impl;
        }

        public CommentsResource Impl { get; }

        public ICreateRequest Create(IComment body, string fileId)
        {
            return new CreateRequestWrapper(Impl.Create(body.Impl, fileId));
        }

        public IDeleteRequest Delete(string fileId, string commentId)
        {
            return new DeleteRequestWrapper(Impl.Delete(fileId, commentId));
        }

        public IGetRequest Get(string fileId, string commentId)
        {
            return new GetRequestWrapper(Impl.Get(fileId, commentId));
        }

        public IListRequest List(string fileId)
        {
            return new ListRequestWrapper(Impl.List(fileId));
        }

        public IUpdateRequest Update(IComment body, string fileId, string commentId)
        {
            return new UpdateRequestWrapper(Impl.Update(body.Impl, fileId, commentId));
        }
    }
}