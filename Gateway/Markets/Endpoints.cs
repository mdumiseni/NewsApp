using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAnalyzer.Gateway.Markets
{
    public class Endpoints
    {
        public static string _baseUrl = "http://api.marketstack.com/v1/";
        public static string _secreteKey = "";
        public static string _symbol = "";

        // End-of-Day Data
        /*      You can use the API's eod endpoint in order to obtain end-of-day data for one or multiple stock tickers. A      single or multiple comma-separated ticker symbols are passed to the API using the symbols parameter.
         *      
         */
        public string END_OF_DAY { get; set; } = $"{_baseUrl}eod?access_key={_secreteKey}&symbols={_symbol}";
        public string INTER_DAY { get; set; } = $"{_baseUrl}intraday?access_key={_secreteKey}&symbols={_symbol}";
        public string HISTORICAL_DATA { get; set; } = $"{_baseUrl}eod?access_key={_secreteKey}&symbols={_symbol}& date_from=2021-11-01&date_to=2021-11-11";
        public string MyProperty { get; set; }
    }
}
