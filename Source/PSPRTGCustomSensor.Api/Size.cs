namespace PSPRTGCustomSensor.Api {
    public class Size {
        public static OptionalProperty One      => SetSize("One");
        public static OptionalProperty Kilo     => SetSize("Kilo");
        public static OptionalProperty Mega     => SetSize("Mega");
        public static OptionalProperty Giga     => SetSize("Giga");
        public static OptionalProperty Tera     => SetSize("Tera");
        public static OptionalProperty Byte     => SetSize("Byte");
        public static OptionalProperty KiloByte => SetSize("KiloByte");
        public static OptionalProperty MegaByte => SetSize("MegaByte");
        public static OptionalProperty Gigabyte => SetSize("Gigabyte");
        public static OptionalProperty TeraByte => SetSize("TeraByte");
        public static OptionalProperty Bit      => SetSize("Bit");
        public static OptionalProperty KiloBit  => SetSize("KiloBit");
        public static OptionalProperty MegaBit  => SetSize("MegaBit");
        public static OptionalProperty GigaBit  => SetSize("GigaBit");
        public static OptionalProperty TeraBit  => SetSize("TeraBit");
        protected static OptionalProperty SetSize(string value) => 
            new OptionalProperty("Size", value);

    }
}
