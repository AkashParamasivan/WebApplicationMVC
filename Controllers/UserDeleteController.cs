//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using WebApplicationMVC.Models;

//namespace WebApplicationMVC.Controllers
//{
//    public class UserDeleteController : Controller
//    {
//        ReleaseManagementContext db = new ReleaseManagementContext();
//        // GET: UserDelete
//        //public ActionResult Index()
//        //{
//        //    return View();
//        //}
//        public ActionResult Delete()
//        {
//            return View();
//        }

//        [HttpDelete]
//        public ActionResult Delete(LoginDetails loginDetails)
//        {
//            try { 
//            db.EloginDetails.Remove(loginDetails);
//            db.Dispose();
//            ViewBag.msg = "User deleted";
//            }
//            catch (Exception ex)
//            {

//                ViewBag.msg = ex.Message;
//            }

//            return View();
//        }
//    }
//}