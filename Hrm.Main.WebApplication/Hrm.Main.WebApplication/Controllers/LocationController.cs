using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Hrm.Main.WebApplication.Models;

namespace Hrm.Main.WebApplication.Controllers
{
    public class LocationController : Controller
    {
        //private HrManagementDbEntities db = new HrManagementDbEntities();

        //// GET: /Location/
        //public ActionResult Index()
        //{
        //    return View(db.LocationsInfoes.ToList());
        //}

        //// GET: /Location/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    LocationsInfo locationsinfo = db.LocationsInfoes.Find(id);
        //    if (locationsinfo == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(locationsinfo);
        //}

        //// GET: /Location/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: /Location/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include="LocationId,Address,Country,PostalCode")] LocationsInfo locationsinfo)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.LocationsInfoes.Add(locationsinfo);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(locationsinfo);
        //}

        //// GET: /Location/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    LocationsInfo locationsinfo = db.LocationsInfoes.Find(id);
        //    if (locationsinfo == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(locationsinfo);
        //}

        //// POST: /Location/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include="LocationId,Address,Country,PostalCode")] LocationsInfo locationsinfo)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(locationsinfo).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(locationsinfo);
        //}

        //// GET: /Location/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    LocationsInfo locationsinfo = db.LocationsInfoes.Find(id);
        //    if (locationsinfo == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(locationsinfo);
        //}

        //// POST: /Location/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    LocationsInfo locationsinfo = db.LocationsInfoes.Find(id);
        //    db.LocationsInfoes.Remove(locationsinfo);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
