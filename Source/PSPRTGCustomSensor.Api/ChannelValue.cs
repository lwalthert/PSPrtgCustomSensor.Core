using System.Globalization;
using Newtonsoft.Json.Linq;

namespace PSPRTGCustomSensor.Api {
    public class ChannelValue {
        public string Value {get;}
        public static implicit operator ChannelValue(int value) => Integer(value);
        public static implicit operator ChannelValue(float value) => Float(value);
        private static ChannelValue Integer(int value) =>
            new ChannelValue (value.ToString(CultureInfo.InvariantCulture));
        private static ChannelValue Float(float value) =>
            new ChannelValue (value.ToString(CultureInfo.InvariantCulture));
        private ChannelValue (string value){
            Value = value;
        }
        public JProperty FromObject() => new JProperty("value", Value);
    }
}
