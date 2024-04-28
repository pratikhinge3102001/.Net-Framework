using Microsoft.AspNetCore.Mvc;

namespace ActionsAndModel.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult index(JobApplication jobApplication)
        {
            return View("Accepted", jobApplication);
        }
    }
}
