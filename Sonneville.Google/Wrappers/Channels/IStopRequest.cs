using Google.Apis.Drive.v3;

namespace Sonneville.Google.Wrappers.Channels
{
    public interface IStopRequest
    {
        /// <summary>Gets the method name.</summary>
        string MethodName { get; }

        /// <summary>Gets the HTTP method.</summary>
        string HttpMethod { get; }

        /// <summary>Gets the REST path.</summary>
        string RestPath { get; }

        ChannelsResource.StopRequest Impl { get; }
    }

    public class StopRequestWrapper : IStopRequest
    {
        public StopRequestWrapper(ChannelsResource.StopRequest impl)
        {
            Impl = impl;
        }

        public ChannelsResource.StopRequest Impl { get; }

        public string MethodName => Impl.MethodName;

        public string HttpMethod => Impl.HttpMethod;

        public string RestPath => Impl.RestPath;
    }
}