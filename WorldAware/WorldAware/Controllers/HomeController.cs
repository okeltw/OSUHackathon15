using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorldAware.Models;

using TweetSharp;

namespace WorldAware.Controllers
{
    public class HomeController : Controller
    {
        private List<Incident> Incidents;


        private string _consumerKey = "CkS3Z5nSq2sJhbHvbJoWnjIv3";
        private string _consumerSecret = "UEXe3wV368AxpbqJfipvsEpTqtz5gIb4PBL0TOWWg6YQPHqZbh";
        private string _accessToken = "3352091764-TK0F9oYIFfYMimWes0foT7AjdmpSNZJmatMouLM";
        private string _accessTokenSecret = "qy9DxsWX4IbA05qZK6RieoFtbrLl8SVAumskQN5wjzkg6";

        public ActionResult Index()
        {
            //This sln will be completely local; additions will be discarded upon exit.
            //To persist, a database will be required.
            if(Incidents == null)
            {
                Incidents = new List<Incident>();
            }

            Incident inc;
            //Or Hardcode specific values
            for(int i = 0; i <= 4; i++)
            {
                inc = new Incident();
                inc.Event = "Event" + i;
                inc.Description = "Desc" + i;
                inc.Location = "Loc" + i;

                Incidents.Add(inc);
            }
            ViewBag.LayoutTag = 0;
                        
            return View();
        }

        public ActionResult Report()
        {
            ViewBag.LayoutTag = 1;
            ViewBag.Message = "Report an Incident.";

            return View();
        }

        [HttpPost]
        public ActionResult ListInc(Incident model)
        {

            // In v1.1, all API calls require authentication
            var service = new TwitterService(_consumerKey, _consumerSecret);
            service.AuthenticateWith(_accessToken, _accessTokenSecret);

            IEnumerable<TwitterStatus> tweets = service.ListTweetsOnHomeTimeline(new ListTweetsOnHomeTimelineOptions());
            foreach (TwitterStatus tweet in tweets)
            {
                ViewBag.Tweet = tweet.Text;
            }

            return ListInc();
        }

        public ActionResult ListInc()
        {
            // In v1.1, all API calls require authentication
            var service = new TwitterService(_consumerKey, _consumerSecret);
            service.AuthenticateWith(_accessToken, _accessTokenSecret);

            IEnumerable<TwitterStatus> tweets = service.ListTweetsOnHomeTimeline(new ListTweetsOnHomeTimelineOptions());
            foreach (TwitterStatus tweet in tweets)
            {
                ViewBag.Tweet = tweet.Text;
            }

            return View();
        }

        public ActionResult Find()
        {
            ViewBag.LayoutTag = 2;
            ViewBag.Message = "Request shelter.";

            return View();
        }

        [HttpPost]
        public ActionResult ListShelter(Shelter model)
        {
            ViewBag.Name = model.name;
            ViewBag.Location = model.location;
            ViewBag.Contact = "mailto:" + model.contact;

            return View();
        }

        public ActionResult ListShelter()
        {
            ViewBag.Message = "List Shelters.";

            
            return View();
        }

        /*****
        Mail
        *****/
        public ActionResult Mail(string address, string name)
        {
            ViewBag.LayoutTag = 0;
            ViewBag.Address = address;
            ViewBag.Name = name;

            return View();
        }
    }
}