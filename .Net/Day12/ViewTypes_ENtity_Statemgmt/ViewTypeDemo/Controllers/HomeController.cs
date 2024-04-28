using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewTypeDemo.Models;

namespace ViewTypeDemo.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            //Cookies Demo
            Response.Cookies.Append("Name", "Snehal");
            Response.Cookies.Append("UserId", "12",new CookieOptions
            {
                Expires = DateTime.Now.AddDays(1)
            });

            //Session Demo
            HttpContext.Session.SetString("Name", "xyz");

            //Demo of ViewData/TempData /ViewBag
            ViewData["Msg1"] = "Welcome from ViewData";
            TempData["Msg"]= "Welcome from TempData";
            ViewBag.Msg = "Welcome from ViewBag";
            return View();
        }

        public IActionResult Index1()
        {
            return View("PageUnderConstruction");
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
