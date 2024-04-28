using DBFirstEF.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DBFirstEF.Controllers
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
            try
            {
                _logger.LogInformation("Home/Index is called .... No error");
                throw new Exception("Error in Application");
             
            }
            catch (Exception ex)
            {

                _logger.LogInformation(ex.Message);
            }
            return View();

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
