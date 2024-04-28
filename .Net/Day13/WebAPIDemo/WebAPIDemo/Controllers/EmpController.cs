using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [EnableCors]
    public class EmpController : ControllerBase
    {
        [HttpGet]
        public List<Emp> GetEmps()
        {
            List<Emp> list = new List<Emp>();
            using (var db = new empdbContext())
            {
                list = db.Emps.ToList();
            }
            return list;
        }

        [HttpGet]
        public Emp? GetEmp(int id)
        {
            Emp? emp = new Emp();
            using (var db = new empdbContext())
            {
                emp = db.Emps.Find(id);
            }
            return emp;
        }

        [HttpPost] 
        public string SaveEmp(Emp emp) { 
            using (var db = new empdbContext())
            {
                db.Emps.Add(emp);
                db.SaveChanges();//save changes into database
            }
            return "Emp saved Successfully!";
        }

        [HttpDelete]
        public string DeleteEmp(int id) {
            Emp? emp = new Emp();
            using (var db = new empdbContext())
            {
                emp = db.Emps.Find(id);
                db.Emps.Remove(emp);
                db.SaveChanges();
            }
            return "Emp Deleted Successfully";
        }

        [HttpPost]
        public string UpdateEmp(Emp emp)
        {
            Emp? em = new Emp();
            using (var db = new empdbContext())
            {
                em = db.Emps.Find(emp.Id);
                em.Ename = emp.Ename;
                em.Salary = emp.Salary;
                em.Gender = emp.Gender;
                em.Address = emp.Address;
                db.SaveChanges();
            }
            return "Emp Updated Successfully!";
        }
    }
}
