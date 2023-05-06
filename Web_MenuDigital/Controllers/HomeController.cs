using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_MenuDigital.Services;

namespace Web_MenuDigital.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
