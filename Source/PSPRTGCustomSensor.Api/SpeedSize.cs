namespace PSPRTGCustomSensor.Api {
    public class SpeedSize : Size {
        new private static OptionalProperty SetSize(string value) => 
            new OptionalProperty("SpeedSize", value);
    }
}