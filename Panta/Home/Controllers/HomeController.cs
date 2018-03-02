using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Panta.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //if user is admin
            ViewBag.Title = "Stjornbord";
            return View("Index-Admin");

            //if not admin

            //if costumer
        }
    }
}