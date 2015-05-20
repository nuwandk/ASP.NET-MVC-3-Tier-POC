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
    public class DesignationController : Controller
    {
        //private HrManagementDbEntities db = new HrManagementDbEntities();

        //// GET: /Designation/
        //public ActionResult Index()
        //{
        //    return View(db.DesignationsInfoes.ToList());
        //}

        //// GET: /Designation/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    DesignationsInfo designationsinfo = db.DesignationsInfoes.Find(id);
        //    if (designationsinfo == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(designationsinfo);
        //}

        //// GET: /Designation/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: /Designation/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include="DesignationId,Title,MinSalary,MaxSalary")] DesignationsInfo designationsinfo)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.DesignationsInfoes.Add(designationsinfo);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(designationsinfo);
        //}

        //// GET: /Designation/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    DesignationsInfo designationsinfo = db.DesignationsInfoes.Find(id);
        //    if (designationsinfo == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(designationsinfo);
        //}

        //// POST: /Designation/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include="DesignationId,Title,MinSalary,MaxSalary")] DesignationsInfo designationsinfo)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(designationsinfo).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(designationsinfo);
        //}

        //// GET: /Designation/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    DesignationsInfo designationsinfo = db.DesignationsInfoes.Find(id);
        //    if (designationsinfo == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(designationsinfo);
        //}

        //// POST: /Designation/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    DesignationsInfo designationsinfo = db.DesignationsInfoes.Find(id);
        //    db.DesignationsInfoes.Remove(designationsinfo);
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
