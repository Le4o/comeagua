using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace comeagua.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Caio é gado.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Lis é chupeta";

            return View();
        }
    }
}