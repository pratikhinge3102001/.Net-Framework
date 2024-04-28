using DBFirstEF.Models;
using Microsoft.AspNetCore.Mvc;

namespace DBFirstEF.Controllers
{
    public class DepartmentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var db = new OrganizationContext();
            List<Department> departmentList = db.Departments.ToList();
            return View(departmentList);
        }
        [HttpGet]
        public IActionResult SaveDept()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SaveDept(Department dept)
        {
            var db = new OrganizationContext();
            db.Departments.Add(dept);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdateDept(int id)
        {
            var db = new OrganizationContext();
            Department dept = db.Departments.Find(id);
            return View(dept);
        }
        [HttpPost]
        public IActionResult UpdateDept(Department dept)
        {
            var db = new OrganizationContext();
            Department dept1 = db.Departments.Find(dept.Id);
            dept1.Name = dept.Name;
            db.SaveChanges();

            return RedirectToAction("Index"); ;
        }

        [HttpGet]
        public IActionResult DeleteDept(int id)
        {
            var db = new OrganizationContext();
        Department dept1 = db.Departments.Find(id);
        db.Departments.Remove(dept1);
            db.SaveChanges();

            return RedirectToAction("Index"); ;
        }
    }
}
