using System.Collections.Generic;
using Google.Apis.Drive.v3;
using Sonneville.Google.Wrappers.About;
using Sonneville.Google.Wrappers.Changes;
using Sonneville.Google.Wrappers.Files;

namespace Sonneville.Google.Wrappers
{
    public class DriveServiceWrapper : IDriveService
    {
        private DriveService _impl;

        public DriveServiceWrapper(DriveService impl)
        {
            _impl = impl;
        }

        public IList<string> Features => _impl.Features;

        public string Name => _impl.Name;

        public string BaseUri => _impl.BaseUri;

        public string BasePath => _impl.BasePath;

        public IAboutResource About => new AboutResourceWrapper(_impl.About);

        public IChangesResource Changes => _impl.Changes;

        public ChannelsResource Channels => _impl.Channels;

        public CommentsResource Comments => _impl.Comments;

        public IFilesResource Files => _impl.Files;

        public PermissionsResource Permissions => _impl.Permissions;

        public RepliesResource Replies => _impl.Replies;

        public RevisionsResource Revisions => _impl.Revisions;
    }
}