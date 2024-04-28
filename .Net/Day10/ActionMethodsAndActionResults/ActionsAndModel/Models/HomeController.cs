using Microsoft.AspNetCore.Mvc;

namespace ActionsAndModel.Models
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
