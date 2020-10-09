using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ekurhuleni.Models;

namespace Ekurhuleni.Controllers
{
    public class ApplicationTypesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ApplicationTypes
        public ActionResult Index()
        {
            return View(db.ApplicationTypes.ToList());
        }

        // GET: ApplicationTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationType applicationType = db.ApplicationTypes.Find(id);
            if (applicationType == null)
            {
                return HttpNotFound();
            }
            return View(applicationType);
        }

        // GET: ApplicationTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ApplicationTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TypeOfApplication")] ApplicationType applicationType)
        {
            if (ModelState.IsValid)
            {
                db.ApplicationTypes.Add(applicationType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(applicationType);
        }

        // GET: ApplicationTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationType applicationType = db.ApplicationTypes.Find(id);
            if (applicationType == null)
            {
                return HttpNotFound();
            }
            return View(applicationType);
        }

        // POST: ApplicationTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TypeOfApplication")] ApplicationType applicationType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(applicationType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(applicationType);
        }

        // GET: ApplicationTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationType applicationType = db.ApplicationTypes.Find(id);
            if (applicationType == null)
            {
                return HttpNotFound();
            }
            return View(applicationType);
        }

        // POST: ApplicationTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ApplicationType applicationType = db.ApplicationTypes.Find(id);
            db.ApplicationTypes.Remove(applicationType);
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
