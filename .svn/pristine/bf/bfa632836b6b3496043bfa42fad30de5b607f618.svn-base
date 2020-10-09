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
    public partial class TarrifsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Tarrifs
        public ActionResult Index()
        {
            return View(db.Tarrifs.ToList());
        }

        // GET: Tarrifs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tarrifs tarrifs = db.Tarrifs.Find(id);
            if (tarrifs == null)
            {
                return HttpNotFound();
            }
            return View(tarrifs);
        }

        // GET: Tarrifs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tarrifs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "tarrifID,Btarrif,ResTarrif")] Tarrifs tarrifs)
        {
            if (ModelState.IsValid)
            {
                db.Tarrifs.Add(tarrifs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tarrifs);
        }

        // GET: Tarrifs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tarrifs tarrifs = db.Tarrifs.Find(id);
            if (tarrifs == null)
            {
                return HttpNotFound();
            }
            return View(tarrifs);
        }

        // POST: Tarrifs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "tarrifID,Btarrif,ResTarrif")] Tarrifs tarrifs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tarrifs).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tarrifs);
        }

        // GET: Tarrifs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tarrifs tarrifs = db.Tarrifs.Find(id);
            if (tarrifs == null)
            {
                return HttpNotFound();
            }
            return View(tarrifs);
        }

        // POST: Tarrifs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Tarrifs tarrifs = db.Tarrifs.Find(id);
            db.Tarrifs.Remove(tarrifs);
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
