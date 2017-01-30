using System.Collections.Generic;
using Google.Apis.Drive.v3.Data;

namespace Sonneville.Google.Wrappers
{
    public class ChannelWrapper : IChannel
    {
        public ChannelWrapper(Channel impl)
        {
            Impl = impl;
        }

        public Channel Impl { get; }

        public string Address
        {
            get { return Impl.Address; }
            set { Impl.Address = value; }
        }

        public long? Expiration
        {
            get { return Impl.Expiration; }
            set { Impl.Expiration = value; }
        }

        public string Id
        {
            get { return Impl.Id; }
            set { Impl.Id = value; }
        }

        public string Kind
        {
            get { return Impl.Kind; }
            set { Impl.Kind = value; }
        }

        public IDictionary<string, string> Params__
        {
            get { return Impl.Params__; }
            set { Impl.Params__ = value; }
        }

        public bool? Payload
        {
            get { return Impl.Payload; }
            set { Impl.Payload = value; }
        }

        public string ResourceId
        {
            get { return Impl.ResourceId; }
            set { Impl.ResourceId = value; }
        }

        public string ResourceUri
        {
            get { return Impl.ResourceUri; }
            set { Impl.ResourceUri = value; }
        }

        public string Token
        {
            get { return Impl.Token; }
            set { Impl.Token = value; }
        }

        public string Type
        {
            get { return Impl.Type; }
            set { Impl.Type = value; }
        }

        public string ETag
        {
            get { return Impl.ETag; }
            set { Impl.ETag = value; }
        }
    }
}