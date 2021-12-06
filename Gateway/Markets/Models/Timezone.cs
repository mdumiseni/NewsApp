using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NewsAnalyzer.Gateway.Markets.Models
{
    public class Timezone
    {
        [JsonPropertyName("timezone")]
        public string timezone { get; set; }
        [JsonPropertyName("abbr")]
        public string abbrivation { get; set; }
        [JsonPropertyName("abbr_dst")]
        public string abbr_dst { get; set; }
    }
}
