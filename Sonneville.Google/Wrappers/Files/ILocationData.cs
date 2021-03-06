using Google.Apis.Drive.v3.Data;

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

        File.ImageMediaMetadataData.LocationData Impl { get; }
    }

    public class LocationDataWrapper : ILocationData
    {
        public LocationDataWrapper(File.ImageMediaMetadataData.LocationData impl)
        {
            Impl = impl;
        }

        public File.ImageMediaMetadataData.LocationData Impl { get; }

        public double? Altitude
        {
            get { return Impl.Altitude; }
            set { Impl.Altitude = value; }
        }

        public double? Latitude
        {
            get { return Impl.Latitude; }
            set { Impl.Latitude = value; }
        }

        public double? Longitude
        {
            get { return Impl.Longitude; }
            set { Impl.Longitude = value; }
        }
    }
}