using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServicePrs;
using Model;

namespace MvcTest.Controllers
{
    public class ItemProductsController : Controller
    {
        UnitOfWorkPrs unit = new UnitOfWorkPrs();

        // GET: ItemProducts
        public ActionResult Index()
        {
            tblItem i1 = unit.tblItemRepository.Get(m => m.item_name== "longdoo1", null, "").SingleOrDefault();

            var l1 = i1 .tblLocation;

            //var items = unit.tblItemRepository.GetAll();

            //var l = items.Last().tblLocation;

            return View(i1);
        }

        // GET: ItemProducts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ItemProducts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ItemProducts/Create
        [HttpPost]
        public ActionResult Create(tblItem item)
        {
            try
            {
                // TODO: Add insert logic here
                item.item_id = Guid.NewGuid();
                item.update_date = DateTime.Now;


                unit.tblItemRepository.Insert(item);
                unit.Save();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ItemProducts/Edit/5
        public ActionResult Edit(Guid id)
        {
            var item = unit.tblItemRepository.Get(q => q.item_id == id).SingleOrDefault();

            return View(item);
        }

        // POST: ItemProducts/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ItemProducts/Delete/5
        public ActionResult Delete(Guid id)
        {
            var item = unit.tblItemRepository.Get(q => q.item_id == id).SingleOrDefault();

            return View(item);
        }

        // POST: ItemProducts/Delete/5
        [HttpPost]
        public ActionResult Delete(tblItem item)
        {
            try
            {
                // TODO: Add delete logic here
                var itemDelete = unit.tblItemRepository.Get(q => q.item_id == item.item_id).SingleOrDefault();

                unit.tblItemRepository.Delete(itemDelete);
                unit.Save();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
