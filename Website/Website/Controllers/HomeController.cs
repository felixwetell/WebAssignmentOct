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
            PropertyList.Add(new Education() { Title = "IT-gymnasiet Södertörn", Description = "Technology Programme with Specialization in Information and Media Communication." });
            PropertyList.Add(new Education() { Title = "Östra gymnasiet", Description = "High School Engineer Education with Specialization in Back-end Programming." });
            PropertyList.Add(new Experience() { Title = "Website creation", Description = "Built a Website for a newly funded company." });
            PropertyList.Add(new Experience() { Title = "Leader", Description = "Management work focused on youth confirmation." });
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