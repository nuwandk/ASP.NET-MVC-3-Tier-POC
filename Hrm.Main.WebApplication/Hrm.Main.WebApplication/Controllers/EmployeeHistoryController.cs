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
    public class EmployeeHistoryController : Controller
    {
        //private HrManagementDbEntities db = new HrManagementDbEntities();

        //// GET: /EmployeeHistory/
        //public ActionResult Index()
        //{
        //    var empolyeehistoryinfoes = db.EmpolyeeHistoryInfoes.Include(e => e.DepartmentInfo).Include(e => e.DesignationsInfo).Include(e => e.EmployeesInfo);
        //    return View(empolyeehistoryinfoes.ToList());
        //}

        //// GET: /EmployeeHistory/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    EmpolyeeHistoryInfo empolyeehistoryinfo = db.EmpolyeeHistoryInfoes.Find(id);
        //    if (empolyeehistoryinfo == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(empolyeehistoryinfo);
        //}

        //// GET: /EmployeeHistory/Create
        //public ActionResult Create()
        //{
        //    ViewBag.DepartmentId = new SelectList(db.DepartmentInfoes, "DepartmentId", "Name");
        //    ViewBag.DesignationId = new SelectList(db.DesignationsInfoes, "DesignationId", "Title");
        //    ViewBag.EmpId = new SelectList(db.EmployeesInfoes, "EmpId", "FirstName");
        //    return View();
        //}

        //// POST: /EmployeeHistory/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include="EmpId,StartDate,EndDate,DesignationId,DepartmentId")] EmpolyeeHistoryInfo empolyeehistoryinfo)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.EmpolyeeHistoryInfoes.Add(empolyeehistoryinfo);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.DepartmentId = new SelectList(db.DepartmentInfoes, "DepartmentId", "Name", empolyeehistoryinfo.DepartmentId);
        //    ViewBag.DesignationId = new SelectList(db.DesignationsInfoes, "DesignationId", "Title", empolyeehistoryinfo.DesignationId);
        //    ViewBag.EmpId = new SelectList(db.EmployeesInfoes, "EmpId", "FirstName", empolyeehistoryinfo.EmpId);
        //    return View(empolyeehistoryinfo);
        //}

        //// GET: /EmployeeHistory/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    EmpolyeeHistoryInfo empolyeehistoryinfo = db.EmpolyeeHistoryInfoes.Find(id);
        //    if (empolyeehistoryinfo == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.DepartmentId = new SelectList(db.DepartmentInfoes, "DepartmentId", "Name", empolyeehistoryinfo.DepartmentId);
        //    ViewBag.DesignationId = new SelectList(db.DesignationsInfoes, "DesignationId", "Title", empolyeehistoryinfo.DesignationId);
        //    ViewBag.EmpId = new SelectList(db.EmployeesInfoes, "EmpId", "FirstName", empolyeehistoryinfo.EmpId);
        //    return View(empolyeehistoryinfo);
        //}

        //// POST: /EmployeeHistory/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include="EmpId,StartDate,EndDate,DesignationId,DepartmentId")] EmpolyeeHistoryInfo empolyeehistoryinfo)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(empolyeehistoryinfo).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.DepartmentId = new SelectList(db.DepartmentInfoes, "DepartmentId", "Name", empolyeehistoryinfo.DepartmentId);
        //    ViewBag.DesignationId = new SelectList(db.DesignationsInfoes, "DesignationId", "Title", empolyeehistoryinfo.DesignationId);
        //    ViewBag.EmpId = new SelectList(db.EmployeesInfoes, "EmpId", "FirstName", empolyeehistoryinfo.EmpId);
        //    return View(empolyeehistoryinfo);
        //}

        //// GET: /EmployeeHistory/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    EmpolyeeHistoryInfo empolyeehistoryinfo = db.EmpolyeeHistoryInfoes.Find(id);
        //    if (empolyeehistoryinfo == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(empolyeehistoryinfo);
        //}

        //// POST: /EmployeeHistory/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    EmpolyeeHistoryInfo empolyeehistoryinfo = db.EmpolyeeHistoryInfoes.Find(id);
        //    db.EmpolyeeHistoryInfoes.Remove(empolyeehistoryinfo);
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
