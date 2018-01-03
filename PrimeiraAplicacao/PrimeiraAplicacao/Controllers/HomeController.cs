using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrimeiraAplicacao.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Minha primeira aplicação com ASP.NET MVC 1";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Minha primeira aplicação com ASP.NET MVC 2";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Minha primeira aplicação com ASP.NET MVC 3";

            return View();
        }
    }
}