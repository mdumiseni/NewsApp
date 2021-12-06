using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NewsAnalyzer.Gateway.Markets.Models
{
    public class ExchangeDetails
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("acronym")]
        public string Acronym { get; set; }

        [JsonPropertyName("mic")]
        public string Mic { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("website")]
        public string Website { get; set; }
        [JsonPropertyName("timezone")]
        public Timezone timezone { get; set; }
    }
}
