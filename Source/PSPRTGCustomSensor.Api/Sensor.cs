using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace PSPRTGCustomSensor.Api{
    public interface ISensor {
        JObject FromObject();
    }
    public class Sensor {
        public ICollection<Channel> Channels {get;}
        public string Text {get;}
        public ICollection<OptionalProperty> Options {get;}
        public Sensor(ICollection<Channel> channels, string text = null) {
            Channels = channels;
            Text = text;
        }
        public void SetError(string message) {
            Options.Add(new OptionalProperty("text", message));
            Options.Add(new OptionalProperty("error",false));
        }
        public void AddChannel(Channel channel) {
            Channels.Add(channel);
        }
        public JObject FromObject() => new JObject(
                new JProperty("prtg",
                    new JObject(Options.Select(option => option.FromObject()),
                    new JProperty("result",
                        new JArray(Channels.Select(channel => channel.FromObject()))))));
    }
}