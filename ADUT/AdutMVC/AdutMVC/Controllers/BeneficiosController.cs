using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdutMVC.Controllers
{
    public class BeneficiosController : Controller
    {
        //
        // GET: /Beneficios/

        public ActionResult Index()
        {
            RedirectToAction("Hoteles");
            return View();
        }

        //
        // GET: /Beneficios/Details/5

        public ActionResult Hoteles()
        {

            return View();
        }

        //
        // GET: /Beneficios/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Beneficios/Create

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
        // GET: /Beneficios/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Beneficios/Edit/5

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
        // GET: /Beneficios/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Beneficios/Delete/5

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
