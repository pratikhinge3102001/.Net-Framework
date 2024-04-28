using ActionsAndModel.DAL;
using ActionsAndModel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic.FileIO;

namespace ActionsAndModel.Controllers
{   
    public class EmpController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DisplayEmp(int id,string ename,float sal,string add,string gender) { 

            Employee employee = new Employee() { Id=id,Name=ename,Salary=sal,Gender=gender,Address=add};
            EmpDbMethods obj = new EmpDbMethods();
            int res = obj.InsertEmp(employee);
            if (res > 0)
                return View(employee);
            else
                return Content("<h1> AAyein</h1>","text/html");

        }

        public IActionResult DisplayEmpWithPassport()
        {
            Employee employee = new Employee()
            { Id = 34, Name = "Vinod", Address = "Pune", Gender = "Male", Salary = 5765 };
            Passport ps = new Passport() {PassportId=16765,Nationality="Indian", ExpiryDate = DateTime.Now };
            EmpPassport empPassport = new EmpPassport() { Employee = employee, Passport = ps };
            return View(empPassport);
        }
        
    }


}
