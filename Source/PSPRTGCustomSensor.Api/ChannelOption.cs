namespace PSPRTGCustomSensor.Api {
    public class ChannelOption {
        public OptionalProperty Warning(bool enable) => 
            new OptionalProperty("Warning", enable);
        public OptionalProperty ShowChart(bool enable) => 
            new OptionalProperty("ShowChart", enable);
        public OptionalProperty ShowTable(bool enable) => 
            new OptionalProperty("ShowTable", enable);

        public OptionalProperty NotifyChanged(bool enable) => 
            new OptionalProperty("NotifyChanged", enable);

        public OptionalProperty ValueLookup(bool enable) => 
            new OptionalProperty("ValueLookup", enable);
        public OptionalProperty Float(bool enable) => 
            new OptionalProperty("Float", enable);
    }
}