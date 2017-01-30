using Google.Apis.Drive.v3.Data;

namespace Sonneville.Google.Wrappers.Files
{
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