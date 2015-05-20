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
    public class DepartmentController : Controller
    {
        //private HrManagementDbEntities db = new HrManagementDbEntities();

        //// GET: /Department/
        //public ActionResult Index()
        //{
        //    var departmentinfoes = db.DepartmentInfoes.Include(d => d.EmployeesInfo).Include(d => d.LocationsInfo);
        //    return View(departmentinfoes.ToList());
        //}

        //// GET: /Department/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    DepartmentInfo departmentinfo = db.DepartmentInfoes.Find(id);
        //    if (departmentinfo == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(departmentinfo);
        //}

        //// GET: /Department/Create
        //public ActionResult Create()
        //{
        //    ViewBag.ManagerId = new SelectList(db.EmployeesInfoes, "EmpId", "FirstName");
        //    ViewBag.LocationId = new SelectList(db.LocationsInfoes, "LocationId", "Address");
        //    return View();
        //}

        //// POST: /Department/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include="DepartmentId,Name,ManagerId,LocationId")] DepartmentInfo departmentinfo)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.DepartmentInfoes.Add(departmentinfo);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.ManagerId = new SelectList(db.EmployeesInfoes, "EmpId", "FirstName", departmentinfo.ManagerId);
        //    ViewBag.LocationId = new SelectList(db.LocationsInfoes, "LocationId", "Address", departmentinfo.LocationId);
        //    return View(departmentinfo);
        //}

        //// GET: /Department/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    DepartmentInfo departmentinfo = db.DepartmentInfoes.Find(id);
        //    if (departmentinfo == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.ManagerId = new SelectList(db.EmployeesInfoes, "EmpId", "FirstName", departmentinfo.ManagerId);
        //    ViewBag.LocationId = new SelectList(db.LocationsInfoes, "LocationId", "Address", departmentinfo.LocationId);
        //    return View(departmentinfo);
        //}

        //// POST: /Department/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include="DepartmentId,Name,ManagerId,LocationId")] DepartmentInfo departmentinfo)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(departmentinfo).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.ManagerId = new SelectList(db.EmployeesInfoes, "EmpId", "FirstName", departmentinfo.ManagerId);
        //    ViewBag.LocationId = new SelectList(db.LocationsInfoes, "LocationId", "Address", departmentinfo.LocationId);
        //    return View(departmentinfo);
        //}

        //// GET: /Department/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    DepartmentInfo departmentinfo = db.DepartmentInfoes.Find(id);
        //    if (departmentinfo == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(departmentinfo);
        //}

        //// POST: /Department/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    DepartmentInfo departmentinfo = db.DepartmentInfoes.Find(id);
        //    db.DepartmentInfoes.Remove(departmentinfo);
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
