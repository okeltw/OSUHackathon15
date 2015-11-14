using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorldAware.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Report()
        {
            ViewBag.Message = "Report an Incident.";

            return View();
        }

        public ActionResult ListInc()
        {
            ViewBag.Message = "List incidents";

            return View();
        }

        public ActionResult Find()
        {
            ViewBag.Message = "Request shelter.";

            return View();
        }

        public ActionResult ListShelter()
        {
            ViewBag.Message = "List Shelters.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}