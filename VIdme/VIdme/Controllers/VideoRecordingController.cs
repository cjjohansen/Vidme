using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VIdme.Controllers
{
    public class VideoRecordingController : Controller
    {
        //
        // GET: /VideoRecording/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /VideoRecording/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /VideoRecording/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /VideoRecording/Create
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
        // GET: /VideoRecording/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /VideoRecording/Edit/5
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
        // GET: /VideoRecording/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /VideoRecording/Delete/5
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
