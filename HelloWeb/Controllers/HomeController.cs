using HelloLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var greeting = new Greeting("Helloooo, World!");

            return View(greeting);
        }
    }
}
