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
    using Hrm.Common.Dto;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    /// <summary>
    /// This class represents Controller functionality for Home View.
    /// </summary>
    public class HomeController : Controller
    {
        #region Private Properties

        private ReportGenerationServiceReference.ReportGenerationServiceClient reportService = new ReportGenerationServiceReference.ReportGenerationServiceClient();

        //TODO: This has to be retrieved from User Login Session.
        private const string LoginUserName = "TestUser";

        #endregion

        #region Public Methods

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        /// <summary>
        /// Create New Joinee Report Action.
        /// </summary>
        /// <returns>ActionResult view</returns>
        public ActionResult CreateNewJoineeReport()
        {
            //TODO: ReportDataDto required to be populated based on actual data.
            ReportDataDto reportDataDto = new ReportDataDto()
            {
                Operation = OperationList.GenerateReport.ToString(),
                UserName = LoginUserName,
                ReportAuthor = LoginUserName,
                ReportId = 10,
                ReportStatus = "New",
                ReportTypeId = "1"
            };
            // Call report generation WCF service method.
            reportService.GenerateReport(reportDataDto);

            return View("Index");
        }

        /// <summary>
        /// Create New Joinee Report Action.
        /// </summary>
        /// <returns>ActionResult view</returns>
        public ActionResult CreateMonthlyRecruitementReport()
        {
            //TODO: ReportDataDto required to be populated based on actual data.
            ReportDataDto reportDataDto = new ReportDataDto()
            {
                Operation = OperationList.GenerateReport.ToString(),
                UserName = LoginUserName,
                ReportAuthor = LoginUserName,
                ReportId = 10,
                ReportStatus = "New",
                ReportTypeId = "1"
            };
            // Call report generation WCF service method.
            reportService.GenerateReport(reportDataDto);

            return View("Index");
        }

        /// <summary>
        /// Create New Joinee Report Action.
        /// </summary>
        /// <returns>ActionResult view</returns>
        public ActionResult CreateEmployeeResignReport()
        {
            //TODO: ReportDataDto required to be populated based on actual data.
            ReportDataDto reportDataDto = new ReportDataDto()
            {
                Operation = OperationList.GenerateReport.ToString(),
                UserName = LoginUserName,
                ReportAuthor = LoginUserName,
                ReportId = 10,
                ReportStatus = "New",
                ReportTypeId = "1"
            };
            // Call report generation WCF service method.
            reportService.GenerateReport(reportDataDto);

            return View("Index");
        }
        #endregion
    }
}