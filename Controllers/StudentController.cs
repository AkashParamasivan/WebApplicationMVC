using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        //public ActionResult AnotherForCheck()
        //{
        //    ViewData["Studentname"] = "raj";
        //    int[] nums = { 1, 2, 3, 4, 5 };
        //    //ViewData["numbers"] = nums;
        //    ViewBag.numbers = nums;

        //    return  View();
        //}
        public ActionResult studentdetails()
        {
            Student student = new Student(101,"Jack", 21);
            return View(student);
        }
    }
}