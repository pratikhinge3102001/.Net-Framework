using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RazorApp.DAL;
using RazorApp.Models;

namespace RazorApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult EmpList()
        {
            EmpDAL empDAL = new EmpDAL();
            List<Employee> emps = empDAL.GetEmpList();
            return View(emps);
        }

        [HttpGet]
        public IActionResult AddEmp()
        {   
            return View();
        }

        [HttpPost]
        public IActionResult AddEmp(Employee emp)
        {
            //Custom Validations
            if (emp.Name == "xyz")
            {
                ModelState.AddModelError("Name", "XYZ is not allowed in db");
            }
            if (ModelState.IsValid)
            {
                EmpDAL empDAL = new EmpDAL();
                int res = empDAL.InsertEmp(emp);

                if (res > 0)
                {
                    return RedirectToAction("EmpList");
                }
                else
                    return Content("Could not Save ! Pls try again");
            }
            else
                return View();

        }
        [HttpGet]
        public IActionResult UpdateEmp(int id)
        {

            EmpDAL empdal = new EmpDAL();
            Employee emp = empdal.GetEmp(id);
            return View(emp);

        }

        [HttpPost]
        public IActionResult UpdateEmp(Employee emp)
        {

            EmpDAL empdal = new EmpDAL();
            int res = empdal.UpdateEmp(emp);
            if (res > 0)
            {
                return RedirectToAction("EmpList");
            }
            return Content("Could Not Update the record!!");

        }

        [HttpGet]
        public IActionResult DeleteEmp(int id)
        {
            EmpDAL empDAL = new EmpDAL();
            int res = empDAL.DeleteEmp(id);
            if (res > 0)
            {
                return RedirectToAction("EmpList");
            }
            else
                return Content("Couldnt Delete the record!!");
        }
    }

}
