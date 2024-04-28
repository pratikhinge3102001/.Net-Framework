using HTMLHelperDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HTMLHelperDemo.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Privacy(Employee emp)
        {
            return View();
        }


    }
}