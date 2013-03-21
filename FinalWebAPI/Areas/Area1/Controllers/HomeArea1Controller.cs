using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalWebAPI.Areas.Area1.Controllers
{
    public class HomeArea1Controller : Controller
    {
        //
        // GET: /Area1/HomeArea1/

        public ActionResult Index()
        {
            ViewBag.mytext = "Area1";
            return View();
        }

        public ActionResult Foo()
        {

            return View();

        }


    }
}
