using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IBFree.Models;

namespace IBFree.Controllers
{
    public class BadFoodsController : Controller
    {
        private IBFreeContext db = new IBFreeContext();

        // GET: /BadFoods/
        public ActionResult Index()
        {
            return View(db.BoldFoods.ToList());
        }

        // GET: /BadFoods/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BadFoods badfoods = db.BoldFoods.Find(id);
            if (badfoods == null)
            {
                return HttpNotFound();
            }
            return View(badfoods);
        }

        // GET: /BadFoods/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /BadFoods/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="NameID,Fructan,Sorbitol,Mannitol,Fructose,GOS,Lactose")] BadFoods badfoods)
        {
            if (ModelState.IsValid)
            {
                db.BoldFoods.Add(badfoods);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(badfoods);
        }

        // GET: /BadFoods/Edit/5
        public ActionResult Edit(string NameId)
        {
            if (NameId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BadFoods badfoods = db.BoldFoods.Find(NameId);
            if (badfoods == null)
            {
                return HttpNotFound();
            }
            return View(badfoods);
        }

        // POST: /BadFoods/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="NameID,Fructan,Sorbitol,Mannitol,Fructose,GOS,Lactose")] BadFoods badfoods)
        {
            if (ModelState.IsValid)
            {
                db.Entry(badfoods).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(badfoods);
        }

        // GET: /BadFoods/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BadFoods badfoods = db.BoldFoods.Find(id);
            if (badfoods == null)
            {
                return HttpNotFound();
            }
            return View(badfoods);
        }

        // POST: /BadFoods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            BadFoods badfoods = db.BoldFoods.Find(id);
            db.BoldFoods.Remove(badfoods);
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
