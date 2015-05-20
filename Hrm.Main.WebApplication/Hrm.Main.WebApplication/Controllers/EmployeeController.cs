#region Copyright
//------------------------------------------------------------------------
// Copyright (C) Hrm. All Rights Reserved.
//------------------------------------------------------------------------
// Project: HR Management System
// Author : Nuwan K
//------------------------------------------------------------------------
#endregion

namespace Hrm.Main.WebApplication.Controllers
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Entity;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Mvc;
    using Hrm.Main.WebApplication.Models;
    using System.Collections;
    using Hrm.Common.Dto;
    using System.ServiceModel;

    #endregion

    /// <summary>
    /// This class contains Employee Controller class logics.
    /// </summary>
    public class EmployeeController : BaseController
    {
        #region Private Properties

        private EmpServiceReference.HrmServiceClient hrmService = new EmpServiceReference.HrmServiceClient();

        //TODO: This has to be retrieved from User Login Session.
        private const string LoginUserName = "nkaduruwana";

        #endregion

        #region Public Methods

        /// <summary>
        /// Used to load all the employee details.
        /// </summary>
        /// <returns>Action result view with Employee details</returns>
        public ActionResult Index()
        {
            // Validate for employee details in temp data session.
            if (TempData[Constants.EmployeeListTempData] == null)
            {
                this.RetrieveEmployeeDetails();
            }

            return View(TempData[Constants.EmployeeListTempData] as List<EmployeeViewModel>);
        }

        /// <summary>
        /// Retrieve details of employee
        /// </summary>
        /// <param name="id">Employee Id</param>
        /// <returns>ActionResult of employee details view</returns>
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeViewModel employeeViewModel = null;

            // Validate for employee details in temp data session.
            if (TempData[Constants.EmployeeListTempData] == null)
            {
                this.RetrieveEmployeeDetails();
            }

            // Retrieve employee information from TempData session.
            List<EmployeeViewModel> employeeViewModels = TempData[Constants.EmployeeListTempData] as List<EmployeeViewModel>;

            if (employeeViewModels != null)
            {
                employeeViewModel = employeeViewModels.Where(e => e.EmpId == id).FirstOrDefault();
            }
            else
            {
                return HttpNotFound();
            }

            return View(employeeViewModel);
        }

        /// <summary>
        /// Used to load data for the Employee Create View.
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            // Validate for employee details in temp data session.
            if (TempData[Constants.EmployeeListTempData] == null)
            {
                this.RetrieveEmployeeDetails();
            }
            // Validate for department details in temp data session.
            if (TempData[Constants.DepartmentListTempData] == null)
            {
                RetrieveEmployeeDepartmentDetails();
            }
            // Validate for designation details in temp data session.
            if (TempData[Constants.DesignationListTempData] == null)
            {
                RetrieveEmployeeDesignationDetails();
            }

            // Bind data to the View.
            ViewBag.EmpId = new SelectList(TempData[Constants.EmployeeListTempData] as List<EmployeeViewModel>, "EmpId", "EmpId");
            ViewBag.ManagerId = new SelectList(TempData[Constants.EmployeeListTempData] as List<EmployeeViewModel>, "EmpId", "FirstName");
            ViewBag.DepartmentId = new SelectList(TempData[Constants.DepartmentListTempData] as List<DepartmentViewModel>, "DepartmentId", "Name");
            ViewBag.JobDesignationId = new SelectList(TempData[Constants.DesignationListTempData] as List<DesignationViewModel>, "DesignationId", "Title");

            return View();
        }

        // POST: /Employee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmpId,FirstName,LastName,Email,JobDesignationId,PhoneNumber,Salary,DepartmentId,ManagerId,DateOfJoin")] EmployeeViewModel employeesViewModel)
        {
            if (ModelState.IsValid)
            {
                EmployeeDto employeeDto = new EmployeeDto();
                employeeDto.DateOfJoin = employeesViewModel.DateOfJoin;
                employeeDto.DepartmentId = employeesViewModel.DepartmentId;
                employeeDto.Email = employeesViewModel.Email;
                employeeDto.EmpId = employeesViewModel.EmpId;
                employeeDto.FirstName = employeesViewModel.FirstName;
                employeeDto.JobDesignationId = employeesViewModel.JobDesignationId;
                employeeDto.LastName = employeesViewModel.LastName;
                employeeDto.ManagerId = employeesViewModel.ManagerId;
                employeeDto.PhoneNumber = employeesViewModel.PhoneNumber;
                employeeDto.Salary = employeesViewModel.Salary;

                employeeDto.UserName = LoginUserName;
                employeeDto.Operation = OperationList.CreateEmployee.ToString();

                EmpServiceReference.HrmServiceClient hrmService = new EmpServiceReference.HrmServiceClient();
                hrmService.CreateEmployee(employeeDto);

                if (TempData[Constants.EmployeeListTempData] != null)
                {
                    // Add new EmployeeData ViewModel to the TempData session.
                    List<EmployeeViewModel> employeeViewModelList = TempData[Constants.EmployeeListTempData] as List<EmployeeViewModel>;
                    employeeViewModelList.Add(employeesViewModel);
                    TempData[Constants.EmployeeListTempData] = employeeViewModelList;
                }

                return RedirectToAction("Index");
            }

            // Validate for employee details in temp data session.
            if (TempData[Constants.EmployeeListTempData] == null)
            {
                this.RetrieveEmployeeDetails();
            }
            // Validate for department details in temp data session.
            if (TempData[Constants.DepartmentListTempData] == null)
            {
                RetrieveEmployeeDepartmentDetails();
            }

            // Validate for designation details in temp data session.
            if (TempData[Constants.DesignationListTempData] == null)
            {
                RetrieveEmployeeDesignationDetails();
            }

            // Bind data to the View.
            ViewBag.EmpId = new SelectList(TempData[Constants.EmployeeListTempData] as List<EmployeeViewModel>, "EmpId", "EmpId");
            ViewBag.ManagerId = new SelectList(TempData[Constants.EmployeeListTempData] as List<EmployeeViewModel>, "EmpId", "FirstName");
            ViewBag.DepartmentId = new SelectList(TempData[Constants.DepartmentListTempData] as List<DepartmentViewModel>, "DepartmentId", "Name");
            ViewBag.JobDesignationId = new SelectList(TempData[Constants.DesignationListTempData] as List<DesignationViewModel>, "DesignationId", "Title");

            return View(employeesViewModel);
        }

        /// <summary>
        /// Loads the Employee edit view.
        /// </summary>
        /// <param name="id">Employee Id</param>
        /// <returns>Employee edit ActionResult View</returns>
        public ActionResult Edit(int? id)
        {
            EmployeeViewModel employeeViewModel = null;

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (TempData[Constants.EmployeeListTempData] == null)
            {
                // Retrieve Employee Details and populate TempData session if is it null.
                this.RetrieveEmployeeDetails();
            }

            // Retrieve employee information from TempData session.
            List<EmployeeViewModel> employeeViewModels = TempData[Constants.EmployeeListTempData] as List<EmployeeViewModel>;

            if (employeeViewModels != null)
            {
                employeeViewModel = employeeViewModels.Where(e => e.EmpId == id).FirstOrDefault();
            }
            else
            {
                return HttpNotFound();
            }

            // Validate for employee details in temp data session.
            if (TempData[Constants.EmployeeListTempData] == null)
            {
                this.RetrieveEmployeeDetails();
            }
            // Validate for department details in temp data session.
            if (TempData[Constants.DepartmentListTempData] == null)
            {
                RetrieveEmployeeDepartmentDetails();
            }
            // Validate for designation details in temp data session.
            if (TempData[Constants.DesignationListTempData] == null)
            {
                RetrieveEmployeeDesignationDetails();
            }

            // Bind data to the View.
            ViewBag.EmpId = new SelectList(TempData[Constants.EmployeeListTempData] as List<EmployeeViewModel>, "EmpId", "EmpId");
            ViewBag.ManagerId = new SelectList(TempData[Constants.EmployeeListTempData] as List<EmployeeViewModel>, "EmpId", "FirstName");
            ViewBag.DepartmentId = new SelectList(TempData[Constants.DepartmentListTempData] as List<DepartmentViewModel>, "DepartmentId", "Name");
            ViewBag.JobDesignationId = new SelectList(TempData[Constants.DesignationListTempData] as List<DesignationViewModel>, "DesignationId", "Title");

            return View(employeeViewModel);
        }

        /// <summary>
        /// Used to edit employee information
        /// </summary>
        /// <param name="employeesViewModel">Employees ViewModel object</param>
        /// <returns>ActionResult of Edit view</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmpId,FirstName,LastName,Email,JobDesignationId,PhoneNumber,Salary,DepartmentId,ManagerId,DateOfJoin")] EmployeeViewModel employeesViewModel)
        {
            if (ModelState.IsValid)
            {
                EmployeeDto employeeDto = new EmployeeDto();
                employeeDto.DateOfJoin = employeesViewModel.DateOfJoin;
                employeeDto.DepartmentId = employeesViewModel.DepartmentId;
                employeeDto.Email = employeesViewModel.Email;
                employeeDto.EmpId = employeesViewModel.EmpId;
                employeeDto.FirstName = employeesViewModel.FirstName;
                employeeDto.JobDesignationId = employeesViewModel.JobDesignationId;
                employeeDto.LastName = employeesViewModel.LastName;
                employeeDto.ManagerId = employeesViewModel.ManagerId;
                employeeDto.PhoneNumber = employeesViewModel.PhoneNumber;
                employeeDto.Salary = employeesViewModel.Salary;

                employeeDto.UserName = LoginUserName;
                employeeDto.Operation = OperationList.CreateEmployee.ToString();

                hrmService.EditEmployee(employeeDto);

                if (TempData[Constants.EmployeeListTempData] != null)
                {
                    RetrieveEmployeeDetails();
                }

                return RedirectToAction("Index");
            }

            // Validate for employee details in temp data session.
            if (TempData[Constants.EmployeeListTempData] == null)
            {
                this.RetrieveEmployeeDetails();
            }
            // Validate for department details in temp data session.
            if (TempData[Constants.DepartmentListTempData] == null)
            {
                RetrieveEmployeeDepartmentDetails();
            }
            // Validate for designation details in temp data session.
            if (TempData[Constants.DesignationListTempData] == null)
            {
                RetrieveEmployeeDesignationDetails();
            }

            // Bind data to the View.
            ViewBag.EmpId = new SelectList(TempData[Constants.EmployeeListTempData] as List<EmployeeViewModel>, "EmpId", "EmpId");
            ViewBag.ManagerId = new SelectList(TempData[Constants.EmployeeListTempData] as List<EmployeeViewModel>, "EmpId", "FirstName");
            ViewBag.DepartmentId = new SelectList(TempData[Constants.DepartmentListTempData] as List<DepartmentViewModel>, "DepartmentId", "Name");
            ViewBag.JobDesignationId = new SelectList(TempData[Constants.DesignationListTempData] as List<DesignationViewModel>, "DesignationId", "Title");

            return View(employeesViewModel);
        }

        /// <summary>
        /// Delete employee record confirmation view.
        /// </summary>
        /// <param name="id">Employee Id</param>
        /// <returns>ActionResult of mployee record confirmation view</returns>
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            // Validate for employee details in temp data session.
            if (TempData[Constants.EmployeeListTempData] == null)
            {
                this.RetrieveEmployeeDetails();
            }

            // Find employee record.
            EmployeeViewModel employeeInfoViewModel = (TempData[Constants.EmployeeListTempData] as 
                List<EmployeeViewModel>).Find(e => e.EmpId == id);

            if (employeeInfoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(employeeInfoViewModel);
        }

        /// <summary>
        /// Delete employee record.
        /// </summary>
        /// <param name="id">Employee Id</param>
        /// <returns>ActionResult of main view</returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeDto employeeDto = new EmployeeDto()
            {
                UserName = LoginUserName,
                Operation = OperationList.DeleteEmployee.ToString(),
                EmpId = id
            };

            // Delete employee by invoking service method.
            hrmService.DeleteEmployee(employeeDto);

            // Validate for employee details in temp data session.
            if (TempData[Constants.EmployeeListTempData] == null)
            {
                this.RetrieveEmployeeDetails();
            }

            // Find employee record.
            EmployeeViewModel employeeInfoViewModel = (TempData[Constants.EmployeeListTempData] as List<EmployeeViewModel>).Find(e => e.EmpId == id);
            // Find and remove employee from TempSession object.
            (TempData[Constants.EmployeeListTempData] as List<EmployeeViewModel>).RemoveAll(e => e.EmpId == id);

            return RedirectToAction("Index");
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Used to retrieve employee details.
        /// </summary>
        private void RetrieveEmployeeDetails()
        {
            BaseDto baseDto = new BaseDto()
            {
                UserName = LoginUserName,
                Operation = OperationList.GetEmployee.ToString()
            };

            List<EmployeeDto> employeeList = null;

            // Retrieve employee details by invoking WCF Service.
            employeeList = hrmService.GetEmployees(baseDto).ToList();

            List<EmployeeViewModel> employeeViewModels = new List<EmployeeViewModel>();

            foreach (EmployeeDto employeeDto in employeeList)
            {
                EmployeeViewModel employeeViewModel = new EmployeeViewModel();
                employeeViewModel.EmpId = employeeDto.EmpId;
                employeeViewModel.FirstName = employeeDto.FirstName;
                employeeViewModel.LastName = employeeDto.LastName;
                employeeViewModel.Email = employeeDto.Email;
                employeeViewModel.PhoneNumber = employeeDto.PhoneNumber;
                employeeViewModel.Salary = employeeDto.Salary;
                employeeViewModel.DateOfJoin = employeeDto.DateOfJoin;
                employeeViewModel.DepartmentId = employeeDto.DepartmentId;

                employeeViewModel.DepartmentInfo = new DepartmentViewModel();

                if (employeeDto.Department != null)
                {
                    employeeViewModel.DepartmentInfo.DepartmentId = employeeDto.Department.DepartmentId;
                    employeeViewModel.DepartmentInfo.Name = employeeDto.Department.Name;
                }
                employeeViewModel.DesignationsInfo = new DesignationViewModel();

                if (employeeDto.Designation != null)
                {
                    employeeViewModel.DesignationsInfo.DesignationId = employeeDto.Designation.DesignationId;
                    employeeViewModel.DesignationsInfo.Title = employeeDto.Designation.Title;
                }
                employeeViewModels.Add(employeeViewModel);
            }

            // Store employee information in TempData Session.
            TempData[Constants.EmployeeListTempData] = employeeViewModels;
        }

        /// <summary>
        /// Used to retrieve employee department details
        /// </summary>
        private void RetrieveEmployeeDepartmentDetails()
        {
            List<DepartmentViewModel> departmentViewModels = new List<DepartmentViewModel>();

            // Retrieve Department details by invoking WCF Service.
            List<DepartmentDto> departmentList = hrmService.GetDepartments().ToList();

            foreach (DepartmentDto departmentDto in departmentList)
            {
                DepartmentViewModel departmentViewModel = new DepartmentViewModel();
                departmentViewModel.DepartmentId = departmentDto.DepartmentId;
                departmentViewModel.Name = departmentDto.Name;
                departmentViewModels.Add(departmentViewModel);
            }

            // Store department information in TempData Session.
            TempData[Constants.DepartmentListTempData] = departmentViewModels;
        }

        /// <summary>
        /// Used to retrieve employee designation details
        /// </summary>
        private void RetrieveEmployeeDesignationDetails()
        {
            List<DesignationViewModel> designationViewModels = new List<DesignationViewModel>();

            // Retrieve Designation details by invoking WCF Service.
            List<DesignationDto> designationtList = hrmService.GetDesignations().ToList();

            foreach (DesignationDto designationDto in designationtList)
            {
                DesignationViewModel designationViewModel = new DesignationViewModel();
                designationViewModel.DesignationId = designationDto.DesignationId;
                designationViewModel.MaxSalary = designationDto.MaxSalary;
                designationViewModel.MinSalary = designationDto.MinSalary;
                designationViewModel.Title = designationDto.Title;
                designationViewModels.Add(designationViewModel);
            }

            // Store destination information in TempData Session.
            TempData[Constants.DesignationListTempData] = designationViewModels;
        }
        #endregion
    }
}
