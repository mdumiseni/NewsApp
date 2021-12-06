using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NewsAnalyzer.Gateway.Markets.Models
{
    public class Exchange
    {
        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }

        [JsonPropertyName("data")]
        public ExchangeDetails ExchangeDetails { get; set; }


    }
}
