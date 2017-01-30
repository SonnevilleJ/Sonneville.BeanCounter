namespace Sonneville.Google.Wrappers.Channels
{
    public interface IChannelsResource
    {
        /// <summary>Stop watching resources through this channel</summary>
        /// <param name="body">The body of the request.</param>
        IStopRequest Stop(IChannel body);
    }
}