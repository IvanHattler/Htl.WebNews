using Htl.Services.ServiceInterfaces;
using Htl.WebNews.Infrastructure;
using Htl.WebNews.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
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
        private readonly IUpdateService _updateService;
        private readonly PagingOptions _pagingOptions;

        public HomeController(ILogger<HomeController> logger, IUpdateService updateService,
            PagingOptions pagingOptions)
        {
            _pagingOptions = pagingOptions 
                ?? throw new ArgumentNullException(nameof(pagingOptions));
            _logger = logger
                ?? throw new ArgumentNullException(nameof(logger));
            _updateService = updateService
                ?? throw new ArgumentNullException(nameof(updateService));
        }

        public IActionResult Index()
        {
            var updatesViewModel = new UpdatesViewModel(
                _updateService.GetUpdates(_pagingOptions.CountOnPage).Select(u => new UpdateViewModel(u)));
            return View(updatesViewModel);
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
