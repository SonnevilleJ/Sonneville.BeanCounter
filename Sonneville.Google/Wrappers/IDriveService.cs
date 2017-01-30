using System.Collections.Generic;
using Sonneville.Google.Wrappers.About;
using Sonneville.Google.Wrappers.Changes;
using Sonneville.Google.Wrappers.Channels;
using Sonneville.Google.Wrappers.Comments;
using Sonneville.Google.Wrappers.Files;
using Sonneville.Google.Wrappers.Permissions;
using Sonneville.Google.Wrappers.Replies;
using Sonneville.Google.Wrappers.Revisions;

namespace Sonneville.Google.Wrappers
{
    public interface IDriveService
    {
        /// <summary>Gets the service supported features.</summary>
        IList<string> Features { get; }

        /// <summary>Gets the service name.</summary>
        string Name { get; }

        /// <summary>Gets the service base URI.</summary>
        string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        string BasePath { get; }

        /// <summary>Gets the About resource.</summary>
        IAboutResource About { get; }

        /// <summary>Gets the Changes resource.</summary>
        IChangesResource Changes { get; }

        /// <summary>Gets the Channels resource.</summary>
        IChannelsResource Channels { get; }

        /// <summary>Gets the Comments resource.</summary>
        ICommentsResource Comments { get; }

        /// <summary>Gets the Files resource.</summary>
        IFilesResource Files { get; }

        /// <summary>Gets the Permissions resource.</summary>
        IPermissionsResource Permissions { get; }

        /// <summary>Gets the Replies resource.</summary>
        IRepliesResource Replies { get; }

        /// <summary>Gets the Revisions resource.</summary>
        IRevisionsResource Revisions { get; }
    }
}