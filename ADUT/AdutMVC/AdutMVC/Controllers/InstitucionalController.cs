﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdutMVC.Controllers
{
    public class InstitucionalController : Controller
    {
        //
        // GET: /Institucional/

        public ActionResult Index()
        {
            RedirectToAction("Quienes_somos");
            return View();
        }

        public ActionResult Seccionales() {
            return View();
        }

        public ActionResult Quienes_somos() {
            return View();
        }
        //
        // GET: /Institucional/Details/5

        public ActionResult Autoridades()
        {
            return View();
        }

        //
        // GET: /Institucional/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Institucional/Create

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
        // GET: /Institucional/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Institucional/Edit/5

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
        // GET: /Institucional/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Institucional/Delete/5

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
