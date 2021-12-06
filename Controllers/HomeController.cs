using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using NewsAnalyzer.Gateway;
using NewsAnalyzer.Models;
using NewsAPI.Constants;
using NewsAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace NewsAnalyzer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public IActionResult Investments()
        {
            ArticlesResult myInvestmentsArticles = new ArticlesResult();
            string endpoint = $"https://newsapi.org/v2/top-headlines?country=za&apiKey=";
            return View(HttpActions.GetEverything(endpoint));
        }

        public IActionResult Sports()
        {
            ArticlesResult sportsArticle = new ArticlesResult();
            string country = "za";
            return View(HttpActions.Categories(country,"entertainment"));
        }

        
        public IActionResult Category(string query)
        {
            ArticlesResult sportsArticle = new ArticlesResult();
            string country = "za";
            return View(HttpActions.Categories(country, query));
        }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult ReadMore(string url)
        {
            return View();
        }

        public IActionResult Index()
        {           
            string endpoint = $"top-headlines?country=za&apiKey=";
            return View(HttpActions.GetEverything(endpoint));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
