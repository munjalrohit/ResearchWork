using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalWebAPI.Models;

namespace FinalWebAPI.Controllers
{
    public class NewEmployeeController : Controller
    {
        private EmployeeContext db = new EmployeeContext();

        //
        // GET: /NewEmployee/

        public ActionResult Index()
        {
            return View(db.NewEmployees.ToList());
        }

        //
        // GET: /NewEmployee/Details/5

        public ActionResult Details(int id = 0)
        {
            NewEmployee newemployee = db.NewEmployees.Find(id);
            if (newemployee == null)
            {
                return HttpNotFound();
            }
            return View(newemployee);
        }

        //
        // GET: /NewEmployee/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /NewEmployee/Create

        [HttpPost]
        public ActionResult Create(NewEmployee newemployee)
        {
            if (ModelState.IsValid)
            {
                db.NewEmployees.Add(newemployee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(newemployee);
        }

        //
        // GET: /NewEmployee/Edit/5

        public ActionResult Edit(int id = 0)
        {
            NewEmployee newemployee = db.NewEmployees.Find(id);
            if (newemployee == null)
            {
                return HttpNotFound();
            }
            return View(newemployee);
        }

        //
        // POST: /NewEmployee/Edit/5

        [HttpPost]
        public ActionResult Edit(NewEmployee newemployee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(newemployee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(newemployee);
        }

        //
        // GET: /NewEmployee/Delete/5

        public ActionResult Delete(int id = 0)
        {
            NewEmployee newemployee = db.NewEmployees.Find(id);
            if (newemployee == null)
            {
                return HttpNotFound();
            }
            return View(newemployee);
        }

        //
        // POST: /NewEmployee/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            NewEmployee newemployee = db.NewEmployees.Find(id);
            db.NewEmployees.Remove(newemployee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}