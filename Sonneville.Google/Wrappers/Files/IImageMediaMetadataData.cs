namespace Sonneville.Google.Wrappers.Files
{
    public interface IImageMediaMetadataData
    {
        /// <summary>The aperture used to create the photo (f-number).</summary>
        float? Aperture { get; set; }

        /// <summary>The make of the camera used to create the photo.</summary>
        string CameraMake { get; set; }

        /// <summary>The model of the camera used to create the photo.</summary>
        string CameraModel { get; set; }

        /// <summary>The color space of the photo.</summary>
        string ColorSpace { get; set; }

        /// <summary>The exposure bias of the photo (APEX value).</summary>
        float? ExposureBias { get; set; }

        /// <summary>The exposure mode used to create the photo.</summary>
        string ExposureMode { get; set; }

        /// <summary>The length of the exposure, in seconds.</summary>
        float? ExposureTime { get; set; }

        /// <summary>Whether a flash was used to create the photo.</summary>
        bool? FlashUsed { get; set; }

        /// <summary>The focal length used to create the photo, in millimeters.</summary>
        float? FocalLength { get; set; }

        /// <summary>The height of the image in pixels.</summary>
        int? Height { get; set; }

        /// <summary>The ISO speed used to create the photo.</summary>
        int? IsoSpeed { get; set; }

        /// <summary>The lens used to create the photo.</summary>
        string Lens { get; set; }

        /// <summary>Geographic location information stored in the image.</summary>
        ILocationData Location { get; set; }

        /// <summary>The smallest f-number of the lens at the focal length used to create the photo (APEX
        /// value).</summary>
        float? MaxApertureValue { get; set; }

        /// <summary>The metering mode used to create the photo.</summary>
        string MeteringMode { get; set; }

        /// <summary>The rotation in clockwise degrees from the image's original orientation.</summary>
        int? Rotation { get; set; }

        /// <summary>The type of sensor used to create the photo.</summary>
        string Sensor { get; set; }

        /// <summary>The distance to the subject of the photo, in meters.</summary>
        int? SubjectDistance { get; set; }

        /// <summary>The date and time the photo was taken (EXIF DateTime).</summary>
        string Time { get; set; }

        /// <summary>The white balance mode used to create the photo.</summary>
        string WhiteBalance { get; set; }

        /// <summary>The width of the image in pixels.</summary>
        int? Width { get; set; }
    }
}