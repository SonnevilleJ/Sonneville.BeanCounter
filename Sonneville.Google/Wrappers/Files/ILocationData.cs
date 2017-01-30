namespace Sonneville.Google.Wrappers.Files
{
    public interface ILocationData
    {
        /// <summary>The altitude stored in the image.</summary>
        double? Altitude { get; set; }

        /// <summary>The latitude stored in the image.</summary>
        double? Latitude { get; set; }

        /// <summary>The longitude stored in the image.</summary>
        double? Longitude { get; set; }
    }
}