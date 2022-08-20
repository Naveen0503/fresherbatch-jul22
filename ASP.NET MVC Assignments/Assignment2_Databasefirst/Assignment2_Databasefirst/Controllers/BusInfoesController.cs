using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Assignment2_Databasefirst.Models;

namespace Assignment2_Databasefirst.Controllers
{
    public class BusInfoesController : Controller
    {
        private BusInfoEntities db = new BusInfoEntities();

        // GET: BusInfoes
        public ActionResult Index()
        {
            return View(db.BusInfoes.ToList());
        }

        // GET: BusInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusInfo busInfo = db.BusInfoes.Find(id);
            if (busInfo == null)
            {
                return HttpNotFound();
            }
            return View(busInfo);
        }

        // GET: BusInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BusInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BusId,BoardingPoint,TravelDate,Amount,Rating")] BusInfo busInfo)
        {
            if (ModelState.IsValid)
            {
                db.BusInfoes.Add(busInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(busInfo);
        }

        // GET: BusInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusInfo busInfo = db.BusInfoes.Find(id);
            if (busInfo == null)
            {
                return HttpNotFound();
            }
            return View(busInfo);
        }

        // POST: BusInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BusId,BoardingPoint,TravelDate,Amount,Rating")] BusInfo busInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(busInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(busInfo);
        }

        // GET: BusInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusInfo busInfo = db.BusInfoes.Find(id);
            if (busInfo == null)
            {
                return HttpNotFound();
            }
            return View(busInfo);
        }

        // POST: BusInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BusInfo busInfo = db.BusInfoes.Find(id);
            db.BusInfoes.Remove(busInfo);
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
