using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EmailSharingDemoApp20140625WED1840.DAL;
using EmailSharingDemoApp20140625WED1840.Models;

namespace EmailSharingDemoApp20140625WED1840.Controllers
{
    public class EMPLController : Controller
    {
        private EMPLContext db = new EMPLContext();

        // GET: EMPL
        public ActionResult Index()
        {
            ViewBag.Message = "List Employees";
            return View(db.EMPL.ToList());
        }

        // GET: EMPL/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPL eMPL = db.EMPL.Find(id);
            if (eMPL == null)
            {
                return HttpNotFound();
            }
            ViewBag.Message = "Display Emloyee Details";
            return View(eMPL);
        }

        // GET: EMPL/Create
        public ActionResult Create()
        {
            ViewBag.Message = "Add New Employee Records";
            return View();
        }

        // POST: EMPL/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,LastName,FirstName,Email")] EMPL eMPL)
        {
            if (ModelState.IsValid)
            {
                db.EMPL.Add(eMPL);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eMPL);
        }

        // GET: EMPL/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPL eMPL = db.EMPL.Find(id);
            if (eMPL == null)
            {
                return HttpNotFound();
            }
            ViewBag.Message = "Modify Employee Information";
            return View(eMPL);
        }

        // POST: EMPL/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,LastName,FirstName,Email")] EMPL eMPL)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eMPL).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eMPL);
        }

        // GET: EMPL/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPL eMPL = db.EMPL.Find(id);
            if (eMPL == null)
            {
                return HttpNotFound();
            }
            ViewBag.Message = "Delete Employee Records";
            return View(eMPL);
        }

        // POST: EMPL/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EMPL eMPL = db.EMPL.Find(id);
            db.EMPL.Remove(eMPL);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
