namespace PSPRTGCustomSensor.Api {
    public static class DecimalMode {
        public static OptionalProperty Auto => SetDecimalMode("Auto");
        public static OptionalProperty All  => SetDecimalMode("All");
        private static OptionalProperty SetDecimalMode(string value) => 
            new OptionalProperty("Mode", value);
    }
}

