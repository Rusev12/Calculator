using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SalaryCalculator.Models;
using System.Globalization;


namespace SalaryCalculator.Controllers
{
    public class HomeController : Controller
    {
        private DailyHoursDBEntities db = new DailyHoursDBEntities();

        // GET: Home
        public ActionResult Index(string sortOrder, string startDate, string endDateFromJS)
        {
            var sortedByDates = from pay in db.DailyPayments
                    select pay;
            sortedByDates = sortedByDates.OrderByDescending(pay => pay.Date);

            if (startDate != null && endDateFromJS != null)
            {
                DateTime convertedStartDateFromJS = DateTime.ParseExact(startDate, "yyyyMMdd", new CultureInfo("en-US"));
                DateTime convertedEndDateFromJS = DateTime.ParseExact(endDateFromJS, "yyyyMMdd", new CultureInfo("en-US"));
                var dateRange = sortedByDates.Where(pay => pay.Date >= convertedStartDateFromJS && pay.Date <= convertedEndDateFromJS);

                return View(dateRange.ToList());
            }
            return View(sortedByDates.ToList());
            
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Date,TimeStart,TimeEnd,TotalMinutes,TotalHours,HourlyRate,DailyPayment1")] DailyPayment dailyPayment)
        {            
            if (ModelState.IsValid)
            {
                dailyPayment.DailyId = Guid.NewGuid();
                var minutesWorked = (dailyPayment.TimeEnd.Hours * 60 + dailyPayment.TimeEnd.Minutes) - (dailyPayment.TimeStart.Hours * 60 + dailyPayment.TimeStart.Minutes);
                double hoursWorked = (double)minutesWorked / 60;
                dailyPayment.TotalMinutes = minutesWorked;
                dailyPayment.TotalHours = hoursWorked;
                dailyPayment.DailyPayment1 = minutesWorked * (dailyPayment.HourlyRate / 60);
                db.DailyPayments.Add(dailyPayment);
                
                db.SaveChanges();
                TempData["dataSaved"] = "Entry successfully saved.";
                return RedirectToAction("Create");
                
            }

            return View(dailyPayment);
        }

        // GET: Home/Edit/5
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

        // POST: Home/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DailyId,Date,TimeStart,TimeEnd,TotalMinutes,TotalHours,HourlyRate,DailyPayment1")] DailyPayment dailyPayment)
        {

            if (ModelState.IsValid)
            {
                var minutesWorked = (dailyPayment.TimeEnd.Hours * 60 + dailyPayment.TimeEnd.Minutes) - (dailyPayment.TimeStart.Hours * 60 + dailyPayment.TimeStart.Minutes);
                double hoursWorked = (double)minutesWorked / 60;
                dailyPayment.TotalMinutes = minutesWorked;
                dailyPayment.TotalHours = hoursWorked;
                dailyPayment.DailyPayment1 = minutesWorked * (dailyPayment.HourlyRate / 60);
                db.DailyPayments.Add(dailyPayment);

                db.Entry(dailyPayment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dailyPayment);
        }

        // GET: Home/Delete/5
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

        // POST: Home/Delete/5
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
