#region Copyright
//------------------------------------------------------------------------
// Copyright (C) Hrm. All Rights Reserved.
//------------------------------------------------------------------------
// Project: HR Management System
// Author : Nuwan K
//------------------------------------------------------------------------
#endregion

namespace Hrm.Server.Business
{
    #region using Directives

    using Hrm.Common.Dto;
    using Hrm.Common.ExceptionHandling;
    using Hrm.Common.Logging;
    using SiemensEnergy.Frw.Base.Common.Utility;
    using SiemensEnergy.Frw.Main.Common.Business;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    #endregion

    /// <summary>
    /// This class is Facade for Hr mananagement related operations
    /// </summary>
    public class HrDataServiceFacade
    {
        #region Private Properties

        private AuthorizationManager authorizationManager = new AuthorizationManager();
        private TaskGenarator<bool> taskGenarator = new TaskGenarator<bool>();

        #endregion

        #region Public Methods - WCF HrmService

        /// <summary>
        /// Used to retrieve all employee information.
        /// </summary>
        /// <returns>List of EmployeeDto</returns>
        public IList<EmployeeDto> GetEmployees(BaseDto baseDto)
        {
            if (baseDto == null)
            {
                throw new ArgumentNullException("BaseDto is null");
            }

            if (string.IsNullOrWhiteSpace(baseDto.UserName))
            {
                throw new ArgumentNullException("BaseDto.UserName is null or empty");
            }

            string notification = string.Empty;
            OperationList operation = (OperationList)Enum.Parse(typeof(OperationList), baseDto.Operation);

            // Check authorization for the requested operation.
            bool isAuthorized = authorizationManager.IsAuthorized(baseDto.UserName, operation, out notification);

            if (isAuthorized)
            {
                Employee employee = new Employee();
                return employee.GetAllEmployees();
            }
            else
            {
                throw new HrmBusinessException(ServiceErrorCodes.AuthorizationFailed);
            }
        }

        /// <summary>
        /// Used to create employee.
        /// </summary>
        /// <returns>List of EmployeeDto</returns>
        public void CreateEmployee(EmployeeDto employeeDto)
        {
            if (employeeDto == null)
            {
                throw new ArgumentNullException("EmployeeDto is null");
            }

            if (string.IsNullOrWhiteSpace(employeeDto.UserName))
            {
                throw new ArgumentNullException("EmployeeDto.UserName is null or empty");
            }

            string notification = string.Empty;
            OperationList operation = (OperationList)Enum.Parse(typeof(OperationList), employeeDto.Operation);

            // Check authorization for the requested operation.
            bool isAuthorized = authorizationManager.IsAuthorized(employeeDto.UserName, operation, out notification);

            if (isAuthorized)
            {
                Employee employee = new Employee();
                employee.Create(employeeDto);
            }
            else
            {
                throw new HrmBusinessException(ServiceErrorCodes.AuthorizationFailed);
            }
        }

        /// <summary>
        /// Used to delete an employee
        /// </summary>
        /// <param name="EmployeeId">Employee Id</param>
        public void DeleteEmployee(EmployeeDto employeeDto)
        {
            if (employeeDto == null)
            {
                throw new ArgumentNullException("EmployeeDto is null");
            }

            if (string.IsNullOrWhiteSpace(employeeDto.UserName))
            {
                throw new ArgumentNullException("EmployeeDto.UserName is null or empty");
            }

            string notification = string.Empty;
            OperationList operation = (OperationList)Enum.Parse(typeof(OperationList), employeeDto.Operation);

            // Check authorization for the requested operation.
            bool isAuthorized = authorizationManager.IsAuthorized(employeeDto.UserName, operation, out notification);

            if (isAuthorized)
            {
                Employee employee = new Employee();
                employee.Delete(employeeDto.EmpId);
            }
            else
            {
                // Authorization failed.
                throw new HrmBusinessException(ServiceErrorCodes.AuthorizationFailed);
            }
        }

        /// <summary>
        /// Used to edit employee.
        /// </summary>
        /// <returns>List of EmployeeDto</returns>
        public void EditEmployee(EmployeeDto employeeDto)
        {
            if (employeeDto == null)
            {
                throw new ArgumentNullException("EmployeeDto is null");
            }

            if (string.IsNullOrWhiteSpace(employeeDto.UserName))
            {
                throw new ArgumentNullException("EmployeeDto.UserName is null or empty");
            }

            string notification = string.Empty;
            OperationList operation = (OperationList)Enum.Parse(typeof(OperationList), employeeDto.Operation);

            // Check authorization for the requested operation.
            bool isAuthorized = authorizationManager.IsAuthorized(employeeDto.UserName, operation, out notification);

            if (isAuthorized)
            {
                Employee employee = new Employee();
                employee.Edit(employeeDto);
            }
            else
            {
                // Authorization failed.
                throw new HrmBusinessException(ServiceErrorCodes.AuthorizationFailed);
            }
        }

        #endregion

        #region Public Methods - WCF ReportGenerationService

        /// <summary>
        ///  Used to generate PDF reports
        /// </summary>
        /// <param name="reportDataDto">Report Data dto</param>
        public void GenerateReport(ReportDataDto reportDataDto)
        {
            if (reportDataDto == null)
            {
                throw new ArgumentNullException("reportDataDto is null");
            }

            if (string.IsNullOrWhiteSpace(reportDataDto.UserName))
            {
                throw new ArgumentNullException("EmployeeDto.UserName is null or empty");
            }

            string notification = string.Empty;
            OperationList operation = (OperationList)Enum.Parse(typeof(OperationList), reportDataDto.Operation);
            Report report = null;

            // Check authorization for the requested operation.
            bool isAuthorized = authorizationManager.IsAuthorized(reportDataDto.UserName, operation, out notification);

            if (isAuthorized)
            {
                report = new Report();
                LogProvider.Log(typeof(HrDataServiceFacade), LogLevel.Debug, "Start thread : GenerateReport ,ReportId:" + reportDataDto.ReportId + " TimeStamp =" + DateTime.UtcNow, reportDataDto.UserName);

                //Assign a thread from .NET Thread Pool for PDF report generation process,
                // since PDF genration process is a long running process.
                taskGenarator.CreateVoidTask(() => report.GenerateReport(reportDataDto));

                LogProvider.Log(typeof(HrDataServiceFacade), LogLevel.Debug, "End thread : GenerateReport ,ReportId:" + reportDataDto.ReportId + " TimeStamp =" + DateTime.UtcNow, reportDataDto.UserName);
            }
            else
            {
                throw new HrmBusinessException(ServiceErrorCodes.AuthorizationFailed);
            }
        }

        #endregion
    }
}
