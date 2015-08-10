using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication_EmailSharing.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Demo App";

            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Support information";

            return View();
        }
    }
}
