namespace PSPRTGCustomSensor.Api
{
    public class VolumeSize : Size {
        new private static OptionalProperty SetSize(string value) =>
            new OptionalProperty("VolumeSize", value);           

    }
}
