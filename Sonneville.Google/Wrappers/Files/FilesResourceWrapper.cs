using System.IO;
using Google.Apis.Drive.v3;

namespace Sonneville.Google.Wrappers.Files
{
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
            return Impl.Create(body.Impl, stream, contentType);
        }

        public IDeleteRequest Delete(string fileId)
        {
            return Impl.Delete(fileId);
        }

        public IEmptyTrashRequest EmptyTrash()
        {
            return Impl.EmptyTrash();
        }

        public IExportRequest Export(string fileId, string mimeType)
        {
            return Impl.Export(fileId, mimeType);
        }

        public IGenerateIdsRequest GenerateIds()
        {
            return Impl.GenerateIds();
        }

        public IGetRequest Get(string fileId)
        {
            return Impl.Get(fileId);
        }

        public IListRequest List()
        {
            return Impl.List();
        }

        public IUpdateRequest Update(IFile body, string fileId)
        {
            return Impl.Update(body.Impl, fileId);
        }

        public IUpdateMediaUpload Update(IFile body, string fileId, Stream stream, string contentType)
        {
            return Impl.Update(body.Impl, fileId, stream, contentType);
        }

        public IWatchRequest Watch(IChannel body, string fileId)
        {
            return Impl.Watch(body.Impl, fileId);
        }
    }
}