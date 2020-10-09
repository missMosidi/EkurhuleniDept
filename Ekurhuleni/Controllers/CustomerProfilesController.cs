using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ekurhuleni.Models;
using Microsoft.AspNet.Identity;

namespace Ekurhuleni.Controllers
{
    public partial class CustomerProfilesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CustomerProfiles
        public ActionResult Index()
        {
            //var customerProfiles = db.CustomerProfiles.Include(c => c.ApplicationUser);
            return View(db.CustomerProfiles.ToList());
        }

        // GET: CustomerProfiles/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerProfile customerProfile = db.CustomerProfiles.Find(id);
            if (customerProfile == null)
            {
                return HttpNotFound();
            }
            return View(customerProfile);
        }

        // GET: CustomerProfiles/Create
        public ActionResult Create()
        {
            //ViewBag.UserId = new SelectList(db.ApplicationUsers, "Id", "Email");
            
            return View();
        }

        // POST: CustomerProfiles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TypeOfCustomer,FName,LName,Title,IDNumber,Gender,Cell_Phone,Work_Phone,Unit_Number,Block_Complex_Name,Street_Name,Suburb,Postal_Code,UserId")] CustomerProfile customerProfile)
        {
            if (ModelState.IsValid)
            {
                var appyser = User.Identity.GetUserId();
                customerProfile.Id = Guid.NewGuid();
                customerProfile.UserId = appyser;
                db.CustomerProfiles.Add(customerProfile);
                db.SaveChanges();
                return RedirectToAction("Create", "Residents");
            }

            //iewBag.UserId = new SelectList(db.ApplicationUsers, "Id", "Email", customerProfile.UserId);
            return View(customerProfile);
        }

        // GET: CustomerProfiles/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerProfile customerProfile = db.CustomerProfiles.Find(id);
            if (customerProfile == null)
            {
                return HttpNotFound();
            }
           // ViewBag.UserId = new SelectList(db.ApplicationUsers, "Id", "Email", customerProfile.UserId);
            return View(customerProfile);
        }

        // POST: CustomerProfiles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TypeOfCustomer,FName,LName,Title,IDNumber,Gender,Cell_Phone,Work_Phone,Unit_Number,Block_Complex_Name,Street_Name,Suburb,Postal_Code,UserId")] CustomerProfile customerProfile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customerProfile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
           // ViewBag.UserId = new SelectList(db.ApplicationUsers, "Id", "Email", customerProfile.UserId);
            return View(customerProfile);
        }

        // GET: CustomerProfiles/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerProfile customerProfile = db.CustomerProfiles.Find(id);
            if (customerProfile == null)
            {
                return HttpNotFound();
            }
            return View(customerProfile);
        }

        // POST: CustomerProfiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            CustomerProfile customerProfile = db.CustomerProfiles.Find(id);
            db.CustomerProfiles.Remove(customerProfile);
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
