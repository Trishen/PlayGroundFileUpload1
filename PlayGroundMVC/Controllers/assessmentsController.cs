using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PlayGroundMVC.Models;
using PlayGroundMVC.Models.Assessments;

namespace PlayGroundMVC.Controllers
{
    public class assessmentsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: assessments
        public ActionResult Index()
        {
            return View(db.assessments.ToList());
        }

        // GET: assessments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            assessments assessments = db.assessments.Find(id);
            if (assessments == null)
            {
                return HttpNotFound();
            }
            return View(assessments);
        }

        // GET: assessments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: assessments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AssessmentID,Grade,StartTime,EndTime,AssessmentDate,AssessmentVenue,Term,Type")] assessments assessments)
        {
            if (ModelState.IsValid)
            {
                db.assessments.Add(assessments);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(assessments);
        }

        // GET: assessments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            assessments assessments = db.assessments.Find(id);
            if (assessments == null)
            {
                return HttpNotFound();
            }
            return View(assessments);
        }

        // POST: assessments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AssessmentID,Grade,StartTime,EndTime,AssessmentDate,AssessmentVenue,Term,Type")] assessments assessments)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assessments).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(assessments);
        }

        // GET: assessments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            assessments assessments = db.assessments.Find(id);
            if (assessments == null)
            {
                return HttpNotFound();
            }
            return View(assessments);
        }

        // POST: assessments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            assessments assessments = db.assessments.Find(id);
            db.assessments.Remove(assessments);
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
