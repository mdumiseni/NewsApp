using NewsAPI.Models;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace NewsAnalyzer.Gateway
{
    public static class HttpActions
    {
        private readonly static string _baseUrl = "https://newsapi.org/v2/";
        private readonly static string _secretKey = "72023eacc1a544519c6e33989df0c598";

        public static ArticlesResult GetEverything(string url)
        {
            ArticlesResult articles = new ArticlesResult();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                var request = client.GetAsync(url + _secretKey).ConfigureAwait(false).GetAwaiter().GetResult();
                if (request.IsSuccessStatusCode)
                {
                    string response = request.Content.ReadAsStringAsync().ConfigureAwait(false).GetAwaiter().GetResult();
                    articles = JsonConvert.DeserializeObject<ArticlesResult>(response);
                    return articles;
                }
                return new ArticlesResult() { TotalResults = 0};              
            }
        }

      
        public static ArticlesResult Categories(string country, string category)
        {
            //top-headlines?country=us&category=business&apiKey=72023eacc1a544519c6e33989df0c598
            ArticlesResult articles = new ArticlesResult();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                var request = client.GetAsync(_baseUrl + $"top-headlines?country={country}&category={category}&apiKey={_secretKey}").ConfigureAwait(false).GetAwaiter().GetResult();
                if (request.IsSuccessStatusCode)
                {
                    string response = request.Content.ReadAsStringAsync().ConfigureAwait(false).GetAwaiter().GetResult();
                    articles = JsonConvert.DeserializeObject<ArticlesResult>(response);
                    return articles;
                }
                return new ArticlesResult() { TotalResults = 0 };
            }

        }

        public static ArticlesResult GetByCountry(string country)
        {
            //top-headlines?country=us&category=business&apiKey=72023eacc1a544519c6e33989df0c598
            ArticlesResult articles = new ArticlesResult();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                var request = client.GetAsync(_baseUrl+$"top-headlines?country={country}&apiKey={_secretKey}").ConfigureAwait(false).GetAwaiter().GetResult();
                if (request.IsSuccessStatusCode)
                {
                    string response = request.Content.ReadAsStringAsync().ConfigureAwait(false).GetAwaiter().GetResult();
                    articles = JsonConvert.DeserializeObject<ArticlesResult>(response);
                    return articles;
                }
                return new ArticlesResult() { TotalResults = 0 };
            }
        }
    }
}
