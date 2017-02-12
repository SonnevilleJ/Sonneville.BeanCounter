using System.Collections.Generic;
using Google.Apis.Drive.v3.Data;

namespace Sonneville.Google.Wrappers.Data
{
    public interface IChannel
    {
        /// <summary>The address where notifications are delivered for this channel.</summary>
        string Address { get; set; }

        /// <summary>Date and time of notification channel expiration, expressed as a Unix timestamp, in milliseconds.
        /// Optional.</summary>
        long? Expiration { get; set; }

        /// <summary>A UUID or similar unique string that identifies this channel.</summary>
        string Id { get; set; }

        /// <summary>Identifies this as a notification channel used to watch for changes to a resource. Value: the fixed
        /// string "api#channel".</summary>
        string Kind { get; set; }

        /// <summary>Additional parameters controlling delivery channel behavior. Optional.</summary>
        IDictionary<string, string> Params__ { get; set; }

        /// <summary>A Boolean value to indicate whether payload is wanted. Optional.</summary>
        bool? Payload { get; set; }

        /// <summary>An opaque ID that identifies the resource being watched on this channel. Stable across different
        /// API versions.</summary>
        string ResourceId { get; set; }

        /// <summary>A version-specific identifier for the watched resource.</summary>
        string ResourceUri { get; set; }

        /// <summary>An arbitrary string delivered to the target address with each notification delivered over this
        /// channel. Optional.</summary>
        string Token { get; set; }

        /// <summary>The type of delivery mechanism used for this channel.</summary>
        string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        string ETag { get; set; }

        Channel Impl { get; }
    }

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