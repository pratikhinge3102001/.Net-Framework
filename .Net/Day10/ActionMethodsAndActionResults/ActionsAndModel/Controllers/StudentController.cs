susing Microsoft.AspNetCore.Mvc;

namespace ActionsAndModel.Controllers
{
    public class StudentController : Controller
    {
        public string GetMessage()
        {
            return "Welcome";
        }
        #region     
        [NonAction]
        public string GetPersonalMessage()
        {
            return "This is secret password";
        }

        [ActionName("NewName")]
        public string GetMyMessage()
        {
            return "This is My password";
        }

        [HttpGet]
        public string HttpGetMessage()
        {
            return "Hi from Get";
        }

        [HttpPost]
        public string HttpPostMessage()
        {
            return "Hi from Post";
        }
        #endregion ActionSelectors

        public IActionResult Index()
        {
            //return View();//By default ActionMethod name ..e.g Index
            //return View("DisplayStudent"); //Name of Another View
            string msg = "Welcome ALL....";
            //return View("DisplayStudent",msg);//sending Model with view

            return View((object)msg);// 


        }

        public ContentResult GetContent()
        {
            //return Content(" Welcome ");
            return Content(" <h1> Welcome <h1>","text/html");
        }

        public JsonResult GetJson() {
            var data = new { Id = 10, Name = "Rima" };
            return Json(data);
        
        }

        public IActionResult RedirectResult() {
            //return Redirect("/Home/Index");
            return RedirectToAction("GetContent");//ACtion Name if within same controller
            //return RedirectToAction("Index","Home"); //Action and Controller


        }

        public FileResult DownloadFile() {
            //Keep this file in WWWroot folder/Files
            return File("Files/Result.pdf", "application/pdf", "Resultset.pdf");
        }

        public IActionResult MyStatusCodes()
        {
            return StatusCode(StatusCodes.Status401Unauthorized);
        }
    }
}
