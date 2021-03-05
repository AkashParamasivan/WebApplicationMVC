using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Employeedetails()
        {
            Employee employee = new Employee(101, "Jack", 21,1234);
            return View(employee);
        }
    }
}