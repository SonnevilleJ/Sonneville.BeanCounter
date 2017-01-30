using Google.Apis.Drive.v3;

namespace Sonneville.Google.Wrappers.Channels
{
    public interface IChannelsResource
    {
        /// <summary>Stop watching resources through this channel</summary>
        /// <param name="body">The body of the request.</param>
        IStopRequest Stop(IChannel body);

        ChannelsResource Impl { get; }
    }

    public class ChannelsResourceWrapper : IChannelsResource
    {
        public ChannelsResourceWrapper(ChannelsResource impl)
        {
            Impl = impl;
        }

        public ChannelsResource Impl { get; }

        public IStopRequest Stop(IChannel body)
        {
            return new StopRequestWrapper(Impl.Stop(body.Impl));
        }
    }
}