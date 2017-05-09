namespace PSPRTGCustomSensor.Api {
    public class Time {
        public static OptionalProperty Second   => SetTime("Second");
        public static OptionalProperty Minute   => SetTime("Minute");
        public static OptionalProperty Hour     => SetTime("Hour");
        public static OptionalProperty Day      => SetTime("Day");
        private static OptionalProperty SetTime(string value) => 
            new OptionalProperty("SpeedTime", value);
    }
}
