using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using week4day1lab.Models;

namespace week4day1lab.Controllers
{
    public class ClassMateController : Controller
    {
        // GET: ClassMate
        public ActionResult ListClassMates()
        {
            var students = new List<Student>()
            {
                new Student() { Name = "Jason Williams", Height = 70, HairColor = "Black" },
                new Student() { Name = "Mike" , Height = 60, HairColor = "Bonde"},
                new Student() { Name = "Aaron", Height = 75, HairColor = "Black"},
                new Student() { Name = "David" , Height = 40, HairColor = "Blonde"},
                new Student() { Name = "Scott" , Height = 30, HairColor = "Black"},
                new Student() { Name = "Brandon" , Height = 50, HairColor = "Black"}
            };
            
            return View(students);
            
        }
    }
}