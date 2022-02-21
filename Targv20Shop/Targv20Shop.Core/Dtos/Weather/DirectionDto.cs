using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Targv20Shop.Core.Dtos.Weather
{
    public class DirectionDto
    {
        [JsonProperty("Degrees")]
        public double Degrees { get; set; }

        [JsonProperty("Localized")]
        public string Localized { get; set; }

        [JsonProperty("English")]
        public string English { get; set; }
    }
}
