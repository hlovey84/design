﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdutMVC.Controllers
{
    public class ContactoController : Controller
    {
        //
        // GET: /Contacto/

        public ActionResult Index()
        {
            
            return View();
        }


        public ActionResult Contacto()
        {
            return View();
        }

        //
        // GET: /Contacto/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Contacto/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Contacto/Create

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
        // GET: /Contacto/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Contacto/Edit/5

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
        // GET: /Contacto/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Contacto/Delete/5

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
