namespace PSPRTGCustomSensor.Api {
    public static class Mode {
        public static OptionalProperty Absolute => SetMode("Absolute");
        public static OptionalProperty Difference => SetMode("Difference");
        private static OptionalProperty SetMode(string value) => 
            new OptionalProperty("Mode", value);
    }
}
