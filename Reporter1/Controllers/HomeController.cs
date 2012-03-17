using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reporter1.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Добро пожаловать в Work time report Creator v.1.1!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
