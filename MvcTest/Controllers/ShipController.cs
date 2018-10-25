using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Model;
using ServicePrs;

namespace MvcTest.Controllers
{
    public class ShipController : Controller
    {
        private ModelPrs db = new ModelPrs();

        // GET: Ships
        public ActionResult Index()
        {
            return View(db.tblShips.ToList());
        }

        // GET: Ships/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblShip tblShip = db.tblShips.Find(id);
            if (tblShip == null)
            {
                return HttpNotFound();
            }
            return View(tblShip);
        }

        // GET: Ships/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ships/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ship_id,ship_status,ship_receive_status,ship_doc,ship_date,request_location,location_id,ship_sum_item,ship_sum_cost,update_date,update_by,note")] tblShip tblShip)
        {
            if (ModelState.IsValid)
            {
                tblShip.ship_id = Guid.NewGuid();
                db.tblShips.Add(tblShip);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblShip);
        }

        // GET: Ships/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblShip tblShip = db.tblShips.Find(id);
            if (tblShip == null)
            {
                return HttpNotFound();
            }
            return View(tblShip);
        }

        // POST: Ships/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ship_id,ship_status,ship_receive_status,ship_doc,ship_date,request_location,location_id,ship_sum_item,ship_sum_cost,update_date,update_by,note")] tblShip tblShip)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblShip).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblShip);
        }

        // GET: Ships/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblShip tblShip = db.tblShips.Find(id);
            if (tblShip == null)
            {
                return HttpNotFound();
            }
            return View(tblShip);
        }

        // POST: Ships/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            tblShip tblShip = db.tblShips.Find(id);
            db.tblShips.Remove(tblShip);
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
