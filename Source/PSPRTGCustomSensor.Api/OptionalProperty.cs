using System;
using System.Globalization;
using Newtonsoft.Json.Linq;

namespace PSPRTGCustomSensor.Api
{
    public class OptionalProperty {
        public string Name  {get;}
        public string Value {get;}
        public OptionalProperty (string name, string value) {
            Name = name;
            Value = value;
        }
        public OptionalProperty (string name, int value) {
            Name = name;
            Value = value.ToString(CultureInfo.InvariantCulture);
        }
        public OptionalProperty (string name, bool value) {
            Name = name;
            // 1 stands for true and 0 for false
            if (value)
                Value = "1";
            else
                Value = "0";
        }
        public JProperty FromObject() => new JProperty(Name,Value);
    }
}