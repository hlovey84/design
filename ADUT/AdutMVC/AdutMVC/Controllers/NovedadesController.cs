using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdutMVC.Controllers
{
    public class NovedadesController : Controller
    {
        //
        // GET: /Novedades/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Novedades/Details/5

        public ActionResult Novedad()
        {
            return View();
        }

        //
        // GET: /Novedades/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Novedades/Create

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

        //
        // GET: /Novedades/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Novedades/Edit/5

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

        //
        // GET: /Novedades/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Novedades/Delete/5

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
