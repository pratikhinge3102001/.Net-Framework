using Filters.CustomFilters;
using Filters.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Filters.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //[RequireHttps]
        //[HttpsOnly]
        [TimeElapsed]
        public string Index()
        {
            return "This is the Index action on the Home controller";
        }

        //[ChangeViewAsync]
        [ChangeView]
        public IActionResult Message() => View();

        [HybridActRes]
        public IActionResult List() => View();

        //[CatchError]
        [TypeFilter(typeof(CatchErrorMessage))]
        public IActionResult Exception(int? id)
        {
            if (id == null)
                throw new Exception("Error Id cannot be null");
            else
                return View((object)$"The value is {id}");
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