using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Suivi_des_vols.DAL;
using Suivi_des_vols.Models;

namespace Suivi_des_vols.Controllers
{
    public class VolsController : Controller
    {
        private VolsContext db = new VolsContext();

        // GET: Vols
        public ActionResult Index()
        {
            return View(db.Vols.ToList());
        }

        // GET: Vols/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vols vols = db.Vols.Find(id);
            if (vols == null)
            {
                return HttpNotFound();
            }
            return View(vols);
        }

        // GET: Vols/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vols/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VolId,DepartAirport,DepartLatAirport,DepartLogAirport,DestinationAirport,DestinationtLatAirport,DestinationLogAirport,Distance,QuantiteKerosene")] Vols vols)
        {
            if (ModelState.IsValid)
            {
                db.Vols.Add(vols);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vols);
        }

        // GET: Vols/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vols vols = db.Vols.Find(id);
            if (vols == null)
            {
                return HttpNotFound();
            }
            return View(vols);
        }

        // POST: Vols/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VolId,DepartAirport,DepartLatAirport,DepartLogAirport,DestinationAirport,DestinationtLatAirport,DestinationLogAirport,Distance,QuantiteKerosene")] Vols vols)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vols).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vols);
        }

        // GET: Vols/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vols vols = db.Vols.Find(id);
            if (vols == null)
            {
                return HttpNotFound();
            }
            return View(vols);
        }

        // POST: Vols/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vols vols = db.Vols.Find(id);
            db.Vols.Remove(vols);
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
