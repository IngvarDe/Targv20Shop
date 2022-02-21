using Newtonsoft.Json;


namespace Targv20Shop.Core.Dtos.Weather
{
    public class SunDto
    {
        [JsonProperty("Rise")]
        public string Rise { get; set; }

        [JsonProperty("EpochRise")]
        public int EpochRise { get; set; }

        [JsonProperty("Set")]
        public string Set { get; set; }

        [JsonProperty("EpochSet")]
        public int EpochSet { get; set; }
    }
}
