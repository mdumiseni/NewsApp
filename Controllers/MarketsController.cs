using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAnalyzer.Controllers
{
    public class MarketsController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
