using Google.Apis.Drive.v3.Data;

namespace Sonneville.Google.Wrappers.Files
{
    public class ImageMediaMetadataDataWrapper : IImageMediaMetadataData
    {
        public ImageMediaMetadataDataWrapper(File.ImageMediaMetadataData impl)
        {
            Impl = impl;
        }

        public File.ImageMediaMetadataData Impl { get; }

        public float? Aperture
        {
            get { return Impl.Aperture; }
            set { Impl.Aperture = value; }
        }

        public string CameraMake
        {
            get { return Impl.CameraMake; }
            set { Impl.CameraMake = value; }
        }

        public string CameraModel
        {
            get { return Impl.CameraModel; }
            set { Impl.CameraModel = value; }
        }

        public string ColorSpace
        {
            get { return Impl.ColorSpace; }
            set { Impl.ColorSpace = value; }
        }

        public float? ExposureBias
        {
            get { return Impl.ExposureBias; }
            set { Impl.ExposureBias = value; }
        }

        public string ExposureMode
        {
            get { return Impl.ExposureMode; }
            set { Impl.ExposureMode = value; }
        }

        public float? ExposureTime
        {
            get { return Impl.ExposureTime; }
            set { Impl.ExposureTime = value; }
        }

        public bool? FlashUsed
        {
            get { return Impl.FlashUsed; }
            set { Impl.FlashUsed = value; }
        }

        public float? FocalLength
        {
            get { return Impl.FocalLength; }
            set { Impl.FocalLength = value; }
        }

        public int? Height
        {
            get { return Impl.Height; }
            set { Impl.Height = value; }
        }

        public int? IsoSpeed
        {
            get { return Impl.IsoSpeed; }
            set { Impl.IsoSpeed = value; }
        }

        public string Lens
        {
            get { return Impl.Lens; }
            set { Impl.Lens = value; }
        }

        public ILocationData Location
        {
            get { return new LocationDataWrapper(Impl.Location); }
            set { Impl.Location = value.Impl; }
        }

        public float? MaxApertureValue
        {
            get { return Impl.MaxApertureValue; }
            set { Impl.MaxApertureValue = value; }
        }

        public string MeteringMode
        {
            get { return Impl.MeteringMode; }
            set { Impl.MeteringMode = value; }
        }

        public int? Rotation
        {
            get { return Impl.Rotation; }
            set { Impl.Rotation = value; }
        }

        public string Sensor
        {
            get { return Impl.Sensor; }
            set { Impl.Sensor = value; }
        }

        public int? SubjectDistance
        {
            get { return Impl.SubjectDistance; }
            set { Impl.SubjectDistance = value; }
        }

        public string Time
        {
            get { return Impl.Time; }
            set { Impl.Time = value; }
        }

        public string WhiteBalance
        {
            get { return Impl.WhiteBalance; }
            set { Impl.WhiteBalance = value; }
        }

        public int? Width
        {
            get { return Impl.Width; }
            set { Impl.Width = value; }
        }
    }
}