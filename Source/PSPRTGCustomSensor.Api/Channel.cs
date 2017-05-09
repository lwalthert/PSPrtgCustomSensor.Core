using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace PSPRTGCustomSensor.Api {
    public class Channel {
        public string Name {get;}
        public ChannelValue Value {get;}
        public IEnumerable<OptionalProperty> OptionalProperties { get; }
        public Channel(string name, ChannelValue value, params OptionalProperty[] optionalProperties) {
            Name = name;
            Value = value;
            OptionalProperties = optionalProperties;
        }

        public JObject FromObject() => new JObject(
            new JProperty("result",
                new JObject(
                    new JProperty("channel",Name),
                    Value.FromObject(),
                    OptionalProperties.Select(property => property.FromObject())
                )
            )
        );
    }
}
