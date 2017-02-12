using System.IO;
using Google.Apis.Drive.v3;
using Sonneville.Google.Wrappers.Data;

namespace Sonneville.Google.Wrappers.Files
{
    public interface IFilesResource
    {
        /// <summary>Creates a copy of a file and applies any requested updates with patch semantics.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID of the file.</param>
        ICopyRequest Copy(IFile body, string fileId);

        /// <summary>Creates a new file.</summary>
        /// <param name="body">The body of the request.</param>
        ICreateRequest Create(IFile body);

        /// <summary>Creates a new file.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="stream">The stream to upload.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        ICreateMediaUpload Create(IFile body, Stream stream, string contentType);

        /// <summary>Permanently deletes a file owned by the user without moving it to the trash. If the target is a
        /// folder, all descendants owned by the user are also deleted.</summary>
        /// <param name="fileId">The ID of the file.</param>
        IDeleteRequest Delete(string fileId);

        /// <summary>Permanently deletes all of the user's trashed files.</summary>
        IEmptyTrashRequest EmptyTrash();

        /// <summary>Exports a Google Doc to the requested MIME type and returns the exported content.</summary>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="mimeType">The MIME type of the format
        /// requested for this export.</param>
        IExportRequest Export(string fileId, string mimeType);

        /// <summary>Generates a set of file IDs which can be provided in create requests.</summary>
        IGenerateIdsRequest GenerateIds();

        /// <summary>Gets a file's metadata or content by ID.</summary>
        /// <param name="fileId">The ID of the file.</param>
        IGetRequest Get(string fileId);

        /// <summary>Lists or searches files.</summary>
        IListRequest List();

        /// <summary>Updates a file's metadata and/or content with patch semantics.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID of the file.</param>
        IUpdateRequest Update(IFile body, string fileId);

        /// <summary>Updates a file's metadata and/or content with patch semantics.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="stream">The stream to upload.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        IUpdateMediaUpload Update(IFile body, string fileId, Stream stream, string contentType);

        /// <summary>Subscribes to changes to a file</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="fileId">The ID of the file.</param>
        IWatchRequest Watch(IChannel body, string fileId);

        FilesResource Impl { get; }
    }

    public class FilesResourceWrapper : IFilesResource
    {
        public FilesResourceWrapper(FilesResource impl)
        {
            Impl = impl;
        }

        public FilesResource Impl { get; }

        public ICopyRequest Copy(IFile body, string fileId)
        {
            return new CopyRequestWrapper(Impl.Copy(body.Impl, fileId));
        }

        public ICreateRequest Create(IFile body)
        {
            return new CreateRequestWrapper(Impl.Create(body.Impl));
        }

        public ICreateMediaUpload Create(IFile body, Stream stream, string contentType)
        {
            return new CreateMediaUploadWrapper(Impl.Create(body.Impl, stream, contentType));
        }

        public IDeleteRequest Delete(string fileId)
        {
            return new DeleteRequestWrapper(Impl.Delete(fileId));
        }

        public IEmptyTrashRequest EmptyTrash()
        {
            return new EmptyTrashRequestWrapper(Impl.EmptyTrash());
        }

        public IExportRequest Export(string fileId, string mimeType)
        {
            return new ExportRequestWrapper(Impl.Export(fileId, mimeType));
        }

        public IGenerateIdsRequest GenerateIds()
        {
            return new GenerateIdsRequestWrapper(Impl.GenerateIds());
        }

        public IGetRequest Get(string fileId)
        {
            return new GetRequestWrapper(Impl.Get(fileId));
        }

        public IListRequest List()
        {
            return new ListRequestWrapper(Impl.List());
        }

        public IUpdateRequest Update(IFile body, string fileId)
        {
            return new UpdateRequestWrapper(Impl.Update(body.Impl, fileId));
        }

        public IUpdateMediaUpload Update(IFile body, string fileId, Stream stream, string contentType)
        {
            return new UpdateMediaUploadWrapper(Impl.Update(body.Impl, fileId, stream, contentType));
        }

        public IWatchRequest Watch(IChannel body, string fileId)
        {
            return new WatchRequestWrapper(Impl.Watch(body.Impl, fileId));
        }
    }
}