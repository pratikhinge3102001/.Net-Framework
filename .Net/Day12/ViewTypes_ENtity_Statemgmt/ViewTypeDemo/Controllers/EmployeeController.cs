using Microsoft.AspNetCore.Mvc;

namespace ViewTypeDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            //Cookies Demo
            var res = Request.Cookies["Name"];
            var uid = Request.Cookies["UserId"];

            //Session Demo
            var nm = HttpContext.Session.GetString("Name");

            //Demo of ViewData/TempData /ViewBag
            var data = ViewData["Msg1"];
            var msg = TempData["Msg"] ;
            TempData.Keep(); //Used to prevent the data 
            var data1= ViewBag.Msg;

            return View();
        }

        public IActionResult EmpList()
        {
            return View();
        }

        public IActionResult GetEmp()
        {
            return View("PageUnderConstruction");
        }
    }
}
