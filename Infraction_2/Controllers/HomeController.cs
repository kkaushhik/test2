using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Infraction_2.Controllers
{
    public class HomeController : Controller
    {
        [RequireHttps]
        public ActionResult Index()
        {
            return View();
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


        public ActionResult MedicalClaims()
        {
            ViewBag.Message = "Medical Claims";

            return View();
        }
        public ActionResult Electronicrejection()
        {
            ViewBag.Message = "ER Info";

            return View();
        }

        public ActionResult Medicare()
        {
            ViewBag.Message = "Medicare collections";

            return View();
        }

        public ActionResult Payorchange()
        {
            ViewBag.Message = "Payor Change";

            return View();
        }

        public ActionResult Infraction1()
        {
           return View();
        }
        public ActionResult Infraction2()
        {
            return View();
        }


    }
}