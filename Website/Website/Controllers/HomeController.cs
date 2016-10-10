using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        List<Property> PropertyList;

        public HomeController()
        {
            PropertyList = new List<Property>();
            PropertyList.Add(new Job() { Title = "Printer", Description = "Preparing paper rolls for printing newspaper." });
            PropertyList.Add(new Job() { Title = "Play leader", Description = "Leader for groups of mentally challenged people." });
            PropertyList.Add(new Skill() { Title = "HTML5", Precentage = 80, Description = "I feel secure using HTML5." });
            PropertyList.Add(new Skill() { Title = "CSS3", Precentage = 80, Description = "Knownledgeable in CSS3." });
            PropertyList.Add(new Skill() { Title = "C#", Precentage = 50, Description = "Getting better and better." });
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View(PropertyList);
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}