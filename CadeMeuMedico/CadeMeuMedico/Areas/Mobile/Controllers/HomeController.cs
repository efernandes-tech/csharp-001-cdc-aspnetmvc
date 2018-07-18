using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadeMeuMedico.Areas.Mobile.Controllers
{
    public class HomeController : Controller
    {
        // GET: Mobile/Home
        public ActionResult Index()
        {
            return Content("teste");
        }
    }
}