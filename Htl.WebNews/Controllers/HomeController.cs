using Htl.Core.Domain;
using Htl.WebNews.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Htl.WebNews.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(new UpdatesViewModel(
                new List<Update>() {
                    new Update("1.0", "1", "i.nefedov", "Первая версия"),
                    new Update("1.0", "2", "i.nefedov", ""),
                    new Update("1.0", "3", "i.nefedov", ""),
                    new Update("1.0", "4", "i.nefedov", ""),
                    new Update("1.0", "5", "i.nefedov", ""),
                    new Update("1.0", "7", "i.nefedov", ""),
                }));
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
