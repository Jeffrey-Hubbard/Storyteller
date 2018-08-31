using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Storyteller.DAL;
using Storyteller.Models;

namespace Storyteller.Controllers
{
    public class PCController : Controller
    {
        private StorytellerContext db = new StorytellerContext();

        // GET: PC
        public ActionResult Index()
        {
            return View(db.PCs.ToList());
        }

        // GET: PC/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PC pC = db.PCs.Find(id);
            if (pC == null)
            {
                return HttpNotFound();
            }
            return View(pC);
        }

        // GET: PC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PC/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Title,Race,Class,Description,Level,Player")] PC pC)
        {
            if (ModelState.IsValid)
            {
                db.PCs.Add(pC);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pC);
        }

        // GET: PC/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PC pC = db.PCs.Find(id);
            if (pC == null)
            {
                return HttpNotFound();
            }
            return View(pC);
        }

        // POST: PC/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Title,Race,Class,Description,Level,Player")] PC pC)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pC).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pC);
        }

        // GET: PC/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PC pC = db.PCs.Find(id);
            if (pC == null)
            {
                return HttpNotFound();
            }
            return View(pC);
        }

        // POST: PC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PC pC = db.PCs.Find(id);
            db.PCs.Remove(pC);
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
