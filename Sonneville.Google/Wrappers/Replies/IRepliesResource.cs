using Google.Apis.Drive.v3;

namespace Sonneville.Google.Wrappers.Replies
{
    public interface IRepliesResource
    {
        /// <summary>Creates a new reply to a comment.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="commentId">The ID of the comment.</param>
        ICreateRequest Create(IReply body, string fileId, string commentId);

        /// <summary>Deletes a reply.</summary>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="commentId">The ID of the
        /// comment.</param>
        /// <param name="replyId">The ID of the reply.</param>
        IDeleteRequest Delete(string fileId, string commentId, string replyId);

        /// <summary>Gets a reply by ID.</summary>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="commentId">The ID of the
        /// comment.</param>
        /// <param name="replyId">The ID of the reply.</param>
        IGetRequest Get(string fileId, string commentId, string replyId);

        /// <summary>Lists a comment's replies.</summary>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="commentId">The ID of the comment.</param>
        IListRequest List(string fileId, string commentId);

        /// <summary>Updates a reply with patch semantics.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="commentId">The ID of the
        /// comment.</param>
        /// <param name="replyId">The ID of the reply.</param>
        IUpdateRequest Update(IReply body, string fileId, string commentId, string replyId);

        RepliesResource Impl { get; }
    }

    public class RepliesResourceWrapper : IRepliesResource
    {
        public RepliesResourceWrapper(RepliesResource impl)
        {
            Impl = impl;
        }

        public RepliesResource Impl { get; }

        public ICreateRequest Create(IReply body, string fileId, string commentId)
        {
            return new CreateRequestWrapper(Impl.Create(body.Impl, fileId, commentId));
        }

        public IDeleteRequest Delete(string fileId, string commentId, string replyId)
        {
            return new DeleteRequestWrapper(Impl.Delete(fileId, commentId, replyId));
        }

        public IGetRequest Get(string fileId, string commentId, string replyId)
        {
            return new GetRequestWrapper(Impl.Get(fileId, commentId, replyId));
        }

        public IListRequest List(string fileId, string commentId)
        {
            return new ListRequestWrapper(Impl.List(fileId, commentId));
        }

        public IUpdateRequest Update(IReply body, string fileId, string commentId, string replyId)
        {
            return new UpdateRequestWrapper(Impl.Update(body.Impl, fileId, commentId, replyId));
        }
    }
}