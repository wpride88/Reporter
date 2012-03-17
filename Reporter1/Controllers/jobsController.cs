using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Reporter1.Models;
using LinqToSqlShared;

namespace Reporter1.Controllers
{
    [HandleError(Order = 2)]
    [Authorize] 
    public class jobsController : Controller
    {
        //
        // GET: /jobs/
        public ActionResult Index()
        {
            REPORTEREntities1 db = new REPORTEREntities1();
            
            //string login = "wpride88";
            //List<UserRPController> usrp = new List<UserRPController>();
            //ViewData
            //var jobs = from m in db.jobs
            //             where (m.Jid > 0)
            //             select m;
            //return View(jobs.ToList());
            return View();

            //var query =
            //from t1 in db.tReturnDoc
            //from t2 in db.tTopicality
            //where
            //t1.Topicality_ID == t2.Topicality_ID
            //select new
            //{
            //    t1.Comments,
            //    t1.Theme,
            //    t1.Topicality_ID,
            //    t2.Topicality_Name
            //};
            //var query =
            //    from t1 in db.jobs
            //    from t2 in db.jtype
            //    where t1.Jtid == t2.Jtid
            //    select new
            //    {
            //        t1.Jname,
            //        t1.Jtimeh,
            //        t1.Jtid,
            //        t2.Jtname
            //    };
            //return View(query.ToList);
        }

        // 
        // GET: /Product/Details
        [HandleError(View = "NoSuchRecordError", ExceptionType = typeof(NoSuchRecordException))] 
        public ActionResult Details(int id) { 
            REPORTEREntities1 db = new REPORTEREntities1 ();
            //var data = db.jobs.Where(e => e.Jid == id).Select(e => e).Single();
            var data = db.jobs.Where(e => e.Jid == id).Select(e => e);
            if (data.Count() == 0)
            {
                throw new NoSuchRecordException();
            }
            else
            {
                jobs jbrecord = data.Single();
                return View(jbrecord);
            } 

            //return View(data); 
        }
        
        //методы функций — Edit и Delete — используются парами, подобно  
        //методам Create. один метод вызывается, когда пользователь 
        //желает запустить процесс Edit или Delete, а второй, когда пользователь завершает 
        //процесс и хочет изменить данные.
        
        //
        // GET: /jobs/Create
        public ActionResult Create()
        {
            return View(new jobs());
        }
        //
        // POST: /jobs/Create
        [HttpPost]
        public ActionResult Create(jobs jb)
        {
            try
            {
                REPORTEREntities1 db = new REPORTEREntities1();
                db.AddTojobs(jb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            } 
        }

        //
        // GET: /jobs/Edit/5
        public ActionResult Edit(int id)
        {
            REPORTEREntities1 db = new REPORTEREntities1();
            var data = db.jobs.Where(e => e.Jid == id).Select(e => e).Single();
            return View(data); 
        }
        //
        // POST: /jobs/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                REPORTEREntities1 db = new REPORTEREntities1();
                jobs jb = db.jobs.Where(e => e.Jid== id).Select(e => e).Single();
                UpdateModel(jb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(); 
            }
        }

        //
        // GET: /jobs/Delete/5
        [Authorize]
        //[Authorize(Users="wpride88")] 
        public ActionResult Delete(int id)
        {
            REPORTEREntities1 db = new REPORTEREntities1();
            var data = db.jobs.Where(e => e.Jid == id).Select(e => e).Single();
            return View(data); 
        }
        //
        // POST: /jobs/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            { 
                    REPORTEREntities1 db = new REPORTEREntities1(); 
                    jobs jb = db.jobs.Where(e => e.Jid == id).Select(e => e).Single(); 
                    db.jobs.DeleteObject(jb); 
                    db.SaveChanges(); 
                    return RedirectToAction("Index"); 
            } catch 
            { 
                    return View(); 
            }
        }
    }

    class ReporterAccessConsolidator
    {
        private REPORTEREntities1 db = new REPORTEREntities1(); 
        
        public IEnumerable<jobs> Listjobs() { 
            return db.jobs; 
        } 
        
        public jobs Getjobs(int id) {
            IEnumerable<jobs> data = db.jobs 
            .Where (e => e.Jid == id) 
            .Select(e => e) ; 
        return data.Count() > 0 ? data.Single() : null; 
        } 
        
        public void DeleteProduct(int id) {
            jobs jb = Getjobs(id); 
            if (jb != null)
            {
                db.jobs.DeleteObject(jb); 
            SaveChanges();
            } 
        }
        public void StoreNewProduct(jobs jb)
        {
            db.jobs.AddObject(jb); 
            SaveChanges(); 
        } 
 
        public void SaveChanges () { 
            db.SaveChanges ();
        }
    }
        
    class NoSuchRecordException : Exception
    {
    } 
}
