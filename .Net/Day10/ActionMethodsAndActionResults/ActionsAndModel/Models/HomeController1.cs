using Microsoft.AspNetCore.Mvc;

namespace ActionsAndModel.Models
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
