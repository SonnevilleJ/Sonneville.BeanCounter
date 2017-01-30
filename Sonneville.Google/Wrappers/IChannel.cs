using System.Collections.Generic;

namespace Sonneville.Google.Wrappers
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
    }
}