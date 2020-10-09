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
    public partial class ResidentsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Residents
        public ActionResult Index()
        {
            return View(db.Residents.ToList());
        }
        public ActionResult ListOfApplication()
        {
            return View(db.Residents.Where(i => i.AppStatus == "Pending").ToList());
        }
        public ActionResult ListOfApprovedApplication()
        {
            return View(db.Residents.Where(i => i.AppStatus == "Approved").ToList());
        }
        public ActionResult ListOfDeclinedApplication()
        {
            return View(db.Residents.Where(i => i.AppStatus == "Declined").ToList());
        }
        public string Confirm(int? ID)
        {
            Residents customer = db.Residents.Find(ID);
            customer.AppStatus = "Confirmed";
            db.SaveChanges();
            return "Application has been Confirmed";
        }
        public ActionResult Confirmed(int? id)
        {
            Residents customer = db.Residents.Find(id);
            string search = null;
            search = Confirm(id);
            ViewBag.Seacrh = search;

            return View(customer);
        }
        public ActionResult ConfirmForUser(int? id)
        {
            Residents customer = db.Residents.Find(id);
            string search = "";
            search = Confirm(id);
            ViewBag.Seacrh = search;
            Residents b = db.Residents.ToList().Last();
            return View(customer);
        }
        public ActionResult Declined(int? id)
        {
            Residents customer = db.Residents.Find(id);
            string search = "";
            search =
            Decline(id);
            ViewBag.Search = search;
            return View(customer);
        }
        public ActionResult DeclineForUser(int? id)
        {
            Residents customer = db.Residents.Find(id);
            string search = "";
            search =
            Decline(id);
            ViewBag.Search = search;
            return View(customer);
        }

        public string Decline(int? CustId)
        {
            Residents a = db.Residents.Find(CustId);
            a.AppStatus = "Declined";
            db.SaveChanges();
            return "Appointment has been Declined.";
        }
        // GET: Residents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Residents residents = db.Residents.Find(id);
            if (residents == null)
            {
                return HttpNotFound();
            }
            return View(residents);
        }
        public ActionResult ViewStatus()
        {
            string m = HttpContext.User.Identity.Name;
            List<Residents> b = db.Residents.ToList().FindAll(p => p.CustomerProfile.IDNumber == m);
            foreach (var item in b)
            {
                if (item.AppStatus == "Confirmed")
                {
                    ViewBag.c = "Confirmed";
                }
                if (item.AppStatus == "Pending")
                {
                    ViewBag.n = "Pending";
                }
            }
            return View(b);
        }
        // GET: Residents/Create
        public ActionResult Create()
        {
          
            CustomerProfile customerProfile = db.CustomerProfiles.ToList().Find(x => x.UserId == User.Identity.GetUserId());
           
            Residents residents = new Residents()
            {
                CustomerProfile = customerProfile
                 // residents.EmployementType = EmployementType.FullTime;


        };
            ViewBag.Id = new SelectList(db.CircuitBreakers, "Id", "size");
            ViewBag.ID = new SelectList(db.ApplicationTypes, "ID", "TypeOfApplication");
            return View(residents);
        }

        // POST: Residents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,UserType,meterType,title,Name,surname,IdType,IDno,cellNumber,Landline,faxNumber,email,Address,line2,Postalcode,streetName,suburb,code,vat,voltage,circuit,resTarrif")] Residents residents)
        {
            //foreach(var c in residents.voltage)
            //{

            //}
            residents.AppStatus = "Pending";
            if (ModelState.IsValid)
            {
                //var nres = new Residents()
                //{
                //    ID=residents.ID,
                //    UserType=residents.UserType,
                //    meterType=residents.meterType,
                    
                //}
                db.Residents.Add(residents);
                db.SaveChanges();
                return RedirectToAction("ListOfApplication");
            }

            ViewBag.ID = new SelectList(db.ApplicationTypes, "ID", "TypeOfApplication", residents.ID);
            ViewBag.Id = new SelectList(db.CircuitBreakers, "Id", "size",residents.ID);
            return View(residents);
        }

        // GET: Residents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Residents residents = db.Residents.Find(id);
            if (residents == null)
            {
                return HttpNotFound();
            }
            return View(residents);
        }

        // POST: Residents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,UserType,meterType,title,Name,surname,IdType,IDno,cellNumber,Landline,faxNumber,email,Address,line2,Postalcode,streetName,suburb,code,vat,voltage,circuit,resTarrif")] Residents residents)
        {
            if (ModelState.IsValid)
            {
                db.Entry(residents).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(residents);
        }

        // GET: Residents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Residents residents = db.Residents.Find(id);
            if (residents == null)
            {
                return HttpNotFound();
            }
            return View(residents);
        }

        // POST: Residents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Residents residents = db.Residents.Find(id);
            db.Residents.Remove(residents);
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
