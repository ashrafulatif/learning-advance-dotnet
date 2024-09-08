using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Labtask4CRUDEFF.Context;


namespace Labtask4CRUDEFF.Controllers
{
    public class StudentController : Controller 
    {
        AspDBEntitiesContext _dbContext;
        public StudentController() {
            _dbContext =new AspDBEntitiesContext();
        }


        // GET: Student
        public ActionResult Index()
        {
            var studentList = _dbContext.Students.ToList();

            return View(studentList);
        }

        public ActionResult AddStudent(Student e)
        {
            // pass department
            List<Department> DeptList = _dbContext.Departments.ToList();
            ViewBag.DeptList = new SelectList(DeptList, "DepartmentId", "Department1");

            if (e.Id > 0)
                return View(e);
            else
            {
                ModelState.Clear();
                ViewBag.NoData = 0;
                return View();
            }
        }

        [HttpPost]
        public ActionResult CerateStudent(Student std)
        {
            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                if (std.Id<=0)
                {
                    _dbContext.Students.Add(std);
                    _dbContext.SaveChanges();
                    TempData["msgAdd"] = "Student added sucessfully!";
                }
                else
                {
                    _dbContext.Entry(std).State = EntityState.Modified;
                    _dbContext.SaveChanges ();
                    TempData["msgMod"] = "Student Modified sucessfully!";
                }


                return RedirectToAction("Index");
            }

            return RedirectToAction("AddStudent");
        }

        public ActionResult Delete(int id)
        {

            var data = _dbContext.Students.Where(x => x.Id == id).First();
            _dbContext.Students.Remove(data);
            _dbContext.SaveChanges();

            TempData["MsgRem"] = "Student information removed successfully";

            return RedirectToAction("Index");
        }



    }
}