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
            ViewBag.LayoutTag = 0;
            return View();
        }

        public ActionResult Report()
        {
            ViewBag.Message = "Report an Incident.";
            ViewBag.LayoutTag = 1;

            return View();
        }

        public ActionResult ListInc()
        {
            ViewBag.Message = "List incidents";
            ViewBag.LayoutTag = 1;

            return View();
        }

        public ActionResult Find()
        {
            ViewBag.Message = "Request shelter.";
            ViewBag.LayoutTag = 2;

            return View();
        }

        public ActionResult ListShelter()
        {
            ViewBag.Message = "List Shelters.";
            ViewBag.LayoutTag = 3;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.LayoutTag = 0;

            return View();
        }
    }
}