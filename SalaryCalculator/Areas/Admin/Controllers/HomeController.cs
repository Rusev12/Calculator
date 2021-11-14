using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SalaryCalculator.Models;

namespace SalaryCalculator.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        private DailyHoursDBEntities db = new DailyHoursDBEntities();

        // GET: Admin/Home
        public ActionResult Index()
        {
            return View(db.DailyPayments.ToList());
        }

        // GET: Admin/Home/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailyPayment dailyPayment = db.DailyPayments.Find(id);
            if (dailyPayment == null)
            {
                return HttpNotFound();
            }
            return View(dailyPayment);
        }

        // GET: Admin/Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Home/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DailyId,Date,TimeStart,TimeEnd,TotalMinutes,TotalHours,HourlyRate,DailyPayment1")] DailyPayment dailyPayment)
        {
            if (ModelState.IsValid)
            {
                dailyPayment.DailyId = Guid.NewGuid();
                db.DailyPayments.Add(dailyPayment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dailyPayment);
        }

        // GET: Admin/Home/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailyPayment dailyPayment = db.DailyPayments.Find(id);
            if (dailyPayment == null)
            {
                return HttpNotFound();
            }
            return View(dailyPayment);
        }

        // POST: Admin/Home/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DailyId,Date,TimeStart,TimeEnd,TotalMinutes,TotalHours,HourlyRate,DailyPayment1")] DailyPayment dailyPayment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dailyPayment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dailyPayment);
        }

        // GET: Admin/Home/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailyPayment dailyPayment = db.DailyPayments.Find(id);
            if (dailyPayment == null)
            {
                return HttpNotFound();
            }
            return View(dailyPayment);
        }

        // POST: Admin/Home/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            DailyPayment dailyPayment = db.DailyPayments.Find(id);
            db.DailyPayments.Remove(dailyPayment);
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
