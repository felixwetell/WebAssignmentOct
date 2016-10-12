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
        WebsiteDB DataBase;
        List<Property> PropertyList;

        public HomeController()
        {
            DataBase = new WebsiteDB();
            PropertyList = new List<Property>();
            foreach (var item in DataBase.Properties)
            {
                PropertyList.Add(item);
            }
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