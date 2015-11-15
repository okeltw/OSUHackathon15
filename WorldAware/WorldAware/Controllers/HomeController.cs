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
            ViewBag.LayoutTag = 2;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.LayoutTag = 3;
            ViewBag.Message = "Your contact page.";
            ViewBag.LayoutTag = 0;

            return View();
        }

        /****
        Twitter API
        ****/
        public ActionResult Authorize()
        {
            // Retrieve OAuth Request Token
            TwitterService service = new TwitterService(_consumerKey, _consumerSecret);

            // Callback URL
            OAuthRequestToken requestToken = service.GetRequestToken("http://localhost:62488/AuthorizeCallback");

            // Redirect to the OAuth Authorization URL
            Uri uri = service.GetAuthorizationUri(requestToken);
            return new RedirectResult(uri.ToString(), false /*permanent*/);

        }

        // Registered @ http://dev.twitter.com
        public ActionResult AuthorizeCallback(string oauth_token, string oauth_verifier)
        {
            var requestToken = new OAuthRequestToken { Token = oauth_token };

            // Exchange the Request Token for an Access Token
            TwitterService service = new TwitterService(_consumerKey, _consumerSecret);
            OAuthAccessToken accessToken = service.GetAccessToken(requestToken, oauth_verifier);

            // User Authenticates using the Access Token
            service.AuthenticateWith(accessToken.Token, accessToken.TokenSecret);
            TwitterUser user = service.VerifyCredentials(new VerifyCredentialsOptions());
            ViewBag.TwitMessage = "Connected";
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