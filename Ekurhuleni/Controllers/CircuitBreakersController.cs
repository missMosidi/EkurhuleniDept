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
    public partial class CircuitBreakersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CircuitBreakers
        public ActionResult Index()
        {
            return View(db.CircuitBreakers.ToList());
        }

        // GET: CircuitBreakers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CircuitBreaker circuitBreaker = db.CircuitBreakers.Find(id);
            if (circuitBreaker == null)
            {
                return HttpNotFound();
            }
            return View(circuitBreaker);
        }

        // GET: CircuitBreakers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CircuitBreakers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,size")] CircuitBreaker circuitBreaker)
        {
            if (ModelState.IsValid)
            {
                db.CircuitBreakers.Add(circuitBreaker);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(circuitBreaker);
        }

        // GET: CircuitBreakers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CircuitBreaker circuitBreaker = db.CircuitBreakers.Find(id);
            if (circuitBreaker == null)
            {
                return HttpNotFound();
            }
            return View(circuitBreaker);
        }

        // POST: CircuitBreakers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,size")] CircuitBreaker circuitBreaker)
        {
            if (ModelState.IsValid)
            {
                db.Entry(circuitBreaker).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(circuitBreaker);
        }

        // GET: CircuitBreakers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CircuitBreaker circuitBreaker = db.CircuitBreakers.Find(id);
            if (circuitBreaker == null)
            {
                return HttpNotFound();
            }
            return View(circuitBreaker);
        }

        // POST: CircuitBreakers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CircuitBreaker circuitBreaker = db.CircuitBreakers.Find(id);
            db.CircuitBreakers.Remove(circuitBreaker);
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
