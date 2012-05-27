using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections;
using Mvcef.Db;

namespace Mvcef.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC_!";
            var db = new AgiContext();
            var u = new Employer() { Id=1, Name = "hhhh----" };
            //hhhhhhhhhh
            db.Employers.Add(u);
            db.SaveChanges();
            var z = db.Employers.ToList();


            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
