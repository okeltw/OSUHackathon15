using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorldAware.Models;

namespace WorldAware.Controllers
{
    public class HomeController : Controller
    {
        private List<Incident> Incidents;

        public ActionResult Index()
        {
            ViewBag.LayoutTag = 0;
            return View();
        }

        public ActionResult Report()
<<<<<<< HEAD
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
=======
        {
            ViewBag.Message = "Report an Incident.";

            return View();
        }

        [HttpPost]
        public ActionResult ListInc(Incident model)
        {
            if(Incidents == null)
            {
                Incidents = new List<Incident>();
            }

            Incidents.Add(model);

            return ListInc();
        }

        public ActionResult ListInc()
        {
            ViewBag.Message = "List incidents";

            if (Incidents != null)
            {
                ViewBag.Incidents = Incidents;
            }

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
>>>>>>> origin/master

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