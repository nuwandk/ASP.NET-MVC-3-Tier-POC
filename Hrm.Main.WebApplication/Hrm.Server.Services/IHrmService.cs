#region Copyright
//------------------------------------------------------------------------
// Copyright (C) Hrm. All Rights Reserved.
//------------------------------------------------------------------------
// Project: HR Management System
// Author : Nuwan K
//------------------------------------------------------------------------
#endregion

namespace Hrm.Server.Services
{
    #region Using Directives

    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using System.Text;
    using Hrm.Common.Dto;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    /// <summary>
    /// Represents HRMService Contract
    /// </summary>
    [ServiceContract]
    public interface IHrmService
    {
        #region WCF HrmService Contracts

        /// <summary>
        /// WCF Contract which used to retrieve all employee information
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [FaultContract(typeof(ServiceFaultExceptionDto))]
        IList<EmployeeDto> GetEmployees(BaseDto baseDto);

        /// <summary>
        /// WCF Contract which used to retrieve all departmet information
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [FaultContract(typeof(ServiceFaultExceptionDto))]
        IList<DepartmentDto> GetDepartments();

        /// <summary>
        /// WCF Contract which used to retrieve all designation information
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [FaultContract(typeof(ServiceFaultExceptionDto))]
        IList<DesignationDto> GetDesignations();

        /// <summary>
        /// WCF Contract which used to create an employee
        /// </summary>
        [OperationContract]
        [FaultContract(typeof(ServiceFaultExceptionDto))]
        void CreateEmployee(EmployeeDto employeeDto);

        /// <summary>
        /// WCF Contract which used to edit an employee
        /// </summary>
        [OperationContract]
        [FaultContract(typeof(ServiceFaultExceptionDto))]
        void EditEmployee(EmployeeDto employeeDto);

        /// <summary>
        /// WCF Contract which used to delete an employee
        /// </summary>
        [OperationContract]
        [FaultContract(typeof(ServiceFaultExceptionDto))]
        void DeleteEmployee(EmployeeDto employeeDto);

        #endregion

    }
}
