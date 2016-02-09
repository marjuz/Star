using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SentiosService.Service;
using SentiosData.Model;
using Microsoft.AspNet.SignalR;


namespace SentiosFrontEnd.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Login", "Account");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult RssReader()
        {  

            return View(RSSService.ReturnRSSfeed());
        }

    }
}