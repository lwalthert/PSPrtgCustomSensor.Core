namespace PSPRTGCustomSensor.Api {
    public class Limit {
       public OptionalProperty SetLimitMaxError(int value) =>
            new OptionalProperty ("LimitMaxError", value);
        public OptionalProperty SetLimitMinError(int value) =>
            new OptionalProperty ("LimitMinError", value);
        public OptionalProperty SetLimitMaxWarning(int value) =>
            new OptionalProperty ("LimitMaxWarning", value);
        public OptionalProperty SetLimitMinWarning(int value) =>
            new OptionalProperty ("LimitMinWarning", value);
        public OptionalProperty SetLimitErrorMsg(string value) =>
            new OptionalProperty ("LimitErrorMsg", value);
        public OptionalProperty SetLimitWarningMsg(string value) =>
            new OptionalProperty ("LimitWarningMsg", value);
        public OptionalProperty SetLimitMode(bool enable) =>
            new OptionalProperty ("LimitMode", enable);
    }
}