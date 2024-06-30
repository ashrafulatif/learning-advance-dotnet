using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppCRUDEF.Context;

namespace WebAppCRUDEF.Controllers
{
    public class EmployeeController : Controller
    {
        AspDBEntitiesContext _dbContext;

        public EmployeeController()
        {
            _dbContext = new AspDBEntitiesContext();
        }

        // GET: Employee
        public ActionResult Index()
        {
            var empList = _dbContext.Employees.ToList();

            return View(empList);
        }

        
        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CerateEmployee(Employee emp)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Employees.Add(emp);
                _dbContext.SaveChanges();
                TempData["msgAdd"] = "Employee Information added sucessfully!";

                return RedirectToAction("Index");
            }
            
            return RedirectToAction("AddEmployee");
        }

        public ActionResult Delete(int id)
        {
            var emp = _dbContext.Employees.Where(x=>x.Id==id).FirstOrDefault();
            _dbContext.Employees.Remove(emp);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
} 