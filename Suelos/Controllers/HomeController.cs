using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Suelos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sing_up()
        {
            ViewBag.Message = "Registro";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Ingreso";

            return View();
        }
    }
}