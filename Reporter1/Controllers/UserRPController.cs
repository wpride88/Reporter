using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reporter1.Models;
using Reporter1.Controllers;

namespace Reporter1.Controllers
{
    public class UserRPController : Controller
    {
        //
        // GET: /UserRP/
        REPORTEREntities1 db = new REPORTEREntities1();
        //string login = "wpride88";
        public ActionResult Index()
        {
            //var logins = from m in db.UsersRP
            //             where (m.Login == login)
            //             select m;
            //return View(logins.ToList());
            return View();
        }

        [HttpPost]

        public ActionResult Create(UsersRP newUsersRP)
        {
            if (ModelState.IsValid)
            {
                db.AddToUsersRP(newUsersRP);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(newUsersRP);
            }
        }
    }
}
