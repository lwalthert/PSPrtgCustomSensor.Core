namespace PSPRTGCustomSensor.Api {
    public static class Unit {
        public static OptionalProperty BytesBandwidth    => SetUnit("BytesBandwidth");
        public static OptionalProperty BytesMemory       => SetUnit("BytesMemory");
        public static OptionalProperty BytesDisk         => SetUnit("BytesDisk");
        public static OptionalProperty BytesFile         => SetUnit("BytesFile");
        public static OptionalProperty Temperature       => SetUnit("Temperature");
        public static OptionalProperty Percent           => SetUnit("Percent");
        public static OptionalProperty TimeResponse      => SetUnit("TimeResponse");
        public static OptionalProperty TimeSeconds       => SetUnit("TimeSeconds");
        public static OptionalProperty Count             => SetUnit("Count");
        public static OptionalProperty CPU               => SetUnit("CPU");
        public static OptionalProperty SpeedDisk         => SetUnit("SpeedDisk");
        public static OptionalProperty SpeedNet          => SetUnit("SpeedNet");
        public static OptionalProperty TimeHours         => SetUnit("TimeHours");

        public static OptionalProperty SetCustomUnit(string value) =>
            new OptionalProperty ("CustomUnit", value);

        private static OptionalProperty SetUnit(string value) =>
            new OptionalProperty ("Unit", value);
    }
}
