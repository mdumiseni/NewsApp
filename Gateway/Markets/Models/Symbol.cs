
using System;
using System.Text.Json.Serialization;

namespace NewsAnalyzer.Gateway.Markets.Models
{
    public class Symbol
    {
       
        [JsonPropertyName("open")]
        public int Open { get; set; }
        [JsonPropertyName("high")]
        public int High { get; set; }
        [JsonPropertyName("low")]
        public int Low { get; set; }
        [JsonPropertyName("close")]
        public decimal Close { get; set; }


        [JsonPropertyName("volume")]
        public decimal Volume { get; set; }

        [JsonPropertyName("adj_high")]
        public decimal AdjustedHigh { get; set; }


        [JsonPropertyName("adj_low")]
        public decimal AdjustedLow { get; set; }


        [JsonPropertyName("adj_close")]
        public decimal AdjustedClose { get; set; }


        [JsonPropertyName("adj_open")]
        public decimal AdjustedOpen { get; set; }


        [JsonPropertyName("adj_volume")]
        public decimal AdjustedVolume { get; set; }


        [JsonPropertyName("split_factor")]
        public int Splitfactor { get; set; }


        [JsonPropertyName("dividend")]
        public decimal Dividend { get; set; }
        [JsonPropertyName("symbol")]
        public string symbol { get; set; }


        [JsonPropertyName("exchange")]
        public string Exchange { get; set; }
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }
    }
}
