using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reporter1.Models;

namespace Reporter1.Controllers
{
    public class SummController : Controller
    {
        //
        // GET: /Summ/

        public ActionResult Index()
        {
            REPORTEREntities1 db = new REPORTEREntities1();
            //blablabla.where(ttt = > ttt.Project== "Project1")
            //выбрать все элементы, свойство Project которых равно "Poject1"
            //var movies = from m in db.Table1

            //var query = from o in db.jobs
            //IEnumerable<Reporter1.Models.REPORTEREntities1> query = from j in db.jobs
            //                                           where j.Uid == 1
            //                                           select j;
                        //where (o.Uid == 1)
                        //group o.Date by o.Date into o
                        //select o;
                        //od => od.UnitPrice*od.Quantity) >= 10000);
            //var query = db(object=>db.SumTimeview2)
            return View();
        }

    }
}
