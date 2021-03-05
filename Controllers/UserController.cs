using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVC.Models;
using System.Data.Entity;

namespace WebApplicationMVC.Controllers
{
    public class UserController : Controller
    {
        ReleaseManagementContext db = new ReleaseManagementContext();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(LoginDetails loginDetails)
        {
            //ReleaseManagementContext db = new ReleaseManagementContext();
            try
            {
                db.EloginDetails.Add(loginDetails);
                db.SaveChanges();
                ViewBag.msg = "User created";
            }
            catch (Exception ex)
            {

                ViewBag.msg = ex.Message;
            }
            return View();
        }

       
       
            [HttpGet] // Set the attribute to Read 
            public ActionResult Read()
            {
                var data = db.EloginDetails.ToList();
                return View(data);
            
            }
        

        //public ActionResult Update()
        //{
        //    return View();
        //}


        public ActionResult Update(string id)
        {
            
                LoginDetails selecteddata = db.EloginDetails.Where(x => x.Username == id).SingleOrDefault();
                return View(selecteddata);
                
            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(LoginDetails model)
        {
          
                

                LoginDetails data = db.EloginDetails.FirstOrDefault(x => x.Username == model.Username);

                
                if (data != null)
                {
                    data.Password = model.Password;
                    data.Role = model.Role;

                    db.SaveChanges();
                ViewBag.msg = "updated";
                    //return RedirectToAction("Read");
                }
                
                    return View();
            
        }

        public ActionResult Delete(string id)
        {
            LoginDetails data = db.EloginDetails.FirstOrDefault(x => x.Username == id);
            return View(data);
        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForm(string id)
        {
            
                LoginDetails data = db.EloginDetails.FirstOrDefault(x => x.Username == id);
                if (data != null)
                {
                    db.EloginDetails.Remove(data);
                    db.SaveChanges();
                    return RedirectToAction("Read");
                }
            ViewBag.de = "sorry";
                return View();
            
        }

        public ActionResult LoginUser(string id)
        {
            LoginDetails data = db.EloginDetails.FirstOrDefault(x => x.Username == id);
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LoginUser(LoginDetails details)
        {

            LoginDetails data = db.EloginDetails.FirstOrDefault(x => x.Username == details.Username);
            if (data != null)
            {
                
                if (data.Password == details.Password)
                {
                    TempData["welcome"] = "Welcome";
                    TempData["Username"] = data.Username;
                    TempData["role"] = data.Role;
                    //return RedirectToAction("Read");
                    //db.EloginDetails.Remove(data);
                    //db.SaveChanges();

                    return RedirectToAction("Read");
                }
            }

            if (data.Role == "manager")
            {
                ViewBag.p = "Welcome Manager!";
                return RedirectToAction("Read");
            }
            else if (data.Role == "developer")
            {
                ViewBag.p = "Welcome developer!";
                return RedirectToAction("Read");
            }
            else if (data.Role == "tester")
            {
                ViewBag.p = "Welcome tester!";
                return RedirectToAction("Read");
            }
            ViewBag.de = "invalid user";
            return View();

        }



    }
}