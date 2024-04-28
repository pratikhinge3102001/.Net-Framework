using Microsoft.AspNetCore.Mvc;

namespace ActionsAndModel.Models
{
    public class HomeController2 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(JobApplication jobApplication)
        {
            return View("Accepted", jobApplication);
        }
    }
}
