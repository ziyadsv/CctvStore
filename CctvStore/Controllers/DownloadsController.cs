﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CctvStore.Models;

namespace CctvStore.Controllers
{
    public class DownloadsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Downloads
        public ActionResult Index()
        {
            return View(db.Downloads.ToList());
        }

        // GET: Downloads/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Download download = db.Downloads.Find(id);
            if (download == null)
            {
                return HttpNotFound();
            }
            return View(download);
        }

        // GET: Downloads/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Downloads/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DownloadId,Name,Version,Introduction,FeaturesfromSDK,DownloadUrl")] Download download)
        {
            if (ModelState.IsValid)
            {
                db.Downloads.Add(download);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(download);
        }

        // GET: Downloads/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Download download = db.Downloads.Find(id);
            if (download == null)
            {
                return HttpNotFound();
            }
            return View(download);
        }

        // POST: Downloads/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DownloadId,Name,Version,Introduction,FeaturesfromSDK,DownloadUrl")] Download download)
        {
            if (ModelState.IsValid)
            {
                db.Entry(download).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(download);
        }

        // GET: Downloads/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Download download = db.Downloads.Find(id);
            if (download == null)
            {
                return HttpNotFound();
            }
            return View(download);
        }

        // POST: Downloads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Download download = db.Downloads.Find(id);
            db.Downloads.Remove(download);
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
