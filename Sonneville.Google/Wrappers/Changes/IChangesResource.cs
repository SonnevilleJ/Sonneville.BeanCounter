using Google.Apis.Drive.v3;
using Sonneville.Google.Wrappers.Data;

namespace Sonneville.Google.Wrappers.Changes
{
    public interface IChangesResource
    {
        /// <summary>Gets the starting pageToken for listing future changes.</summary>
        IGetStartPageTokenRequest GetStartPageToken();

        /// <summary>Lists changes for a user.</summary>
        /// <param name="pageToken">The token for continuing a previous list request on the next page. This should be set to the
        /// value of 'nextPageToken' from the previous response or to the response from the getStartPageToken
        /// method.</param>
        IListRequest List(string pageToken);

        /// <summary>Subscribes to changes for a user.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="pageToken">The token for continuing a previous list request on the next page. This should be set to the
        /// value of 'nextPageToken' from the previous response or to the response from the getStartPageToken
        /// method.</param>
        IWatchRequest Watch(IChannel body, string pageToken);

        ChangesResource Impl { get; }
    }

    public class ChangesResourceWrapper : IChangesResource
    {
        public ChangesResourceWrapper(ChangesResource impl)
        {
            Impl = impl;
        }

        public ChangesResource Impl { get; }

        public IGetStartPageTokenRequest GetStartPageToken()
        {
            return new GetStartPageTokenRequestWrapper(Impl.GetStartPageToken());
        }

        public IListRequest List(string pageToken)
        {
            return new ListRequestWrapper(Impl.List(pageToken));
        }

        public IWatchRequest Watch(IChannel body, string pageToken)
        {
            return new WatchRequestWrapper(Impl.Watch(body.Impl, pageToken));
        }
    }
}