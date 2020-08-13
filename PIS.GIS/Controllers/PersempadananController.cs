using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PIS.GIS.Controllers
{
    public class PersempadananController : Controller
    {
        // GET: Persempadanan
        public ActionResult Index()
        {
            return View();
        }

        // GET: Persempadanan/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Persempadanan/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Persempadanan/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Persempadanan/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Persempadanan/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: Persempadanan/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Persempadanan/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
