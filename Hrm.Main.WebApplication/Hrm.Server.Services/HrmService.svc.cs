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

    using Hrm.Common.Dto;
    using Hrm.Common.ExceptionHandling;
    using Hrm.Server.Business;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using System.Text;

    #endregion

    /// <summary>
    /// Represents the WCF HrmService.
    /// </summary>
    public class HrmService : IHrmService
    {
        #region Constants

        private const string UnhandleExceptionMessage = "Unhandle Exception - ";

        #endregion

        #region Private Members

        // Service facade for business entities.
        private HrDataServiceFacade hrDataServiceFacade = new HrDataServiceFacade();

        #endregion

        #region Service Contract Implementation Methods

        /// <summary>
        /// Used to retrieve all employee information.
        /// </summary>
        /// <returns>List of EmployeeDto</returns>
        public IList<EmployeeDto> GetEmployees(BaseDto baseDto)
        {
            try
            {
                return hrDataServiceFacade.GetEmployees(baseDto);
            }
            catch (HrmDalException ex)
            {
                ex.Handle();
                throw new FaultException<ServiceFaultExceptionDto>(new ServiceFaultExceptionDto(ex.Message));
            }
            catch (HrmBusinessException ex)
            {
                ex.Handle();
                throw new FaultException<ServiceFaultExceptionDto>(new ServiceFaultExceptionDto(ex.Message));
            }
            catch (HrmException ex)
            {
                ex.Handle();
                throw new FaultException<ServiceFaultExceptionDto>(new ServiceFaultExceptionDto(ex.Message));
            }
            catch (Exception ex)
            {
                HrmServiceException HrmServiceException = new HrmServiceException(ex.Message, ex);
                HrmServiceException.Handle();
                throw new FaultException<ServiceFaultExceptionDto>(new ServiceFaultExceptionDto(ex.Message));
            }
        }

        /// <summary>
        /// Used to retrieve all department information.
        /// </summary>
        /// <returns>List of EmployeeDto</returns>
        public IList<DepartmentDto> GetDepartments()
        {
            try
            {
                Department department = new Department();
                return department.GetAllDepartments();
            }
            catch (HrmDalException ex)
            {
                ex.Handle();
                throw new FaultException<ServiceFaultExceptionDto>(new ServiceFaultExceptionDto(ex.Message));
            }
            catch (HrmBusinessException ex)
            {
                ex.Handle();
                throw new FaultException<ServiceFaultExceptionDto>(new ServiceFaultExceptionDto(ex.Message));
            }
            catch (HrmException ex)
            {
                ex.Handle();
                throw new FaultException<ServiceFaultExceptionDto>(new ServiceFaultExceptionDto(ex.Message));
            }
            catch (Exception ex)
            {
                HrmServiceException HrmServiceException = new HrmServiceException(ex.Message, ex);
                HrmServiceException.Handle();
                throw new FaultException<ServiceFaultExceptionDto>(new ServiceFaultExceptionDto(ex.Message));
            }
        }

        /// <summary>
        /// Used to retrieve all designation information.
        /// </summary>
        /// <returns>List of EmployeeDto</returns>
        public IList<DesignationDto> GetDesignations()
        {
            try
            {
                Designation designation = new Designation();
                return designation.GetAllDesignation();
            }
            catch (HrmDalException ex)
            {
                ex.Handle();
                throw new FaultException<ServiceFaultExceptionDto>(new ServiceFaultExceptionDto(ex.Message));
            }
            catch (HrmBusinessException ex)
            {
                ex.Handle();
                throw new FaultException<ServiceFaultExceptionDto>(new ServiceFaultExceptionDto(ex.Message));
            }
            catch (HrmException ex)
            {
                ex.Handle();
                throw new FaultException<ServiceFaultExceptionDto>(new ServiceFaultExceptionDto(ex.Message));
            }
            catch (Exception ex)
            {
                HrmServiceException HrmServiceException = new HrmServiceException(ex.Message, ex);
                HrmServiceException.Handle();
                throw new FaultException<ServiceFaultExceptionDto>(new ServiceFaultExceptionDto(ex.Message));
            }
        }

        /// <summary>
        /// Used to create employee.
        /// </summary>
        /// <returns>List of EmployeeDto</returns>
        public void CreateEmployee(EmployeeDto employeeDto)
        {
            try
            {
                hrDataServiceFacade.CreateEmployee(employeeDto);
            }
            catch (HrmDalException ex)
            {
                ex.Handle();
                throw new FaultException<ServiceFaultExceptionDto>(new ServiceFaultExceptionDto(ex.Message));
            }
            catch (HrmBusinessException ex)
            {
                ex.Handle();
                throw new FaultException<ServiceFaultExceptionDto>(new ServiceFaultExceptionDto(ex.Message));
            }
            catch (HrmException ex)
            {
                ex.Handle();
                throw new FaultException<ServiceFaultExceptionDto>(new ServiceFaultExceptionDto(ex.Message));
            }
            catch (Exception ex)
            {
                HrmServiceException HrmServiceException = new HrmServiceException(ex.Message, ex);
                HrmServiceException.Handle();
                throw new FaultException<ServiceFaultExceptionDto>(new ServiceFaultExceptionDto(ex.Message));
            }
        }

        /// <summary>
        /// Used to delete an employee.
        /// </summary>
        /// <param name="EmployeeId">Employee Id</param>
        public void DeleteEmployee(EmployeeDto employeeDto)
        {
            try
            {
                hrDataServiceFacade.DeleteEmployee(employeeDto);
            }
            catch (HrmDalException ex)
            {
                ex.Handle();
                throw new FaultException<ServiceFaultExceptionDto>(new ServiceFaultExceptionDto(ex.Message));
            }
            catch (HrmBusinessException ex)
            {
                ex.Handle();
                throw new FaultException<ServiceFaultExceptionDto>(new ServiceFaultExceptionDto(ex.Message));
            }
            catch (HrmException ex)
            {
                ex.Handle();
                throw new FaultException<ServiceFaultExceptionDto>(new ServiceFaultExceptionDto(ex.Message));
            }
            catch (Exception ex)
            {
                HrmServiceException HrmServiceException = new HrmServiceException(ex.Message, ex);
                HrmServiceException.Handle();
                throw new FaultException<ServiceFaultExceptionDto>(new ServiceFaultExceptionDto(ex.Message));
            }
        }

        /// <summary>
        /// Used to edit employee.
        /// </summary>
        /// <returns>List of EmployeeDto</returns>
        public void EditEmployee(EmployeeDto employeeDto)
        {
            try
            {
                hrDataServiceFacade.EditEmployee(employeeDto);
            }
            catch (HrmDalException ex)
            {
                ex.Handle();
                throw new FaultException<ServiceFaultExceptionDto>(new ServiceFaultExceptionDto(ex.Message));
            }
            catch (HrmBusinessException ex)
            {
                ex.Handle();
                throw new FaultException<ServiceFaultExceptionDto>(new ServiceFaultExceptionDto(ex.Message));
            }
            catch (HrmException ex)
            {
                ex.Handle();
                throw new FaultException<ServiceFaultExceptionDto>(new ServiceFaultExceptionDto(ex.Message));
            }
            catch (Exception ex)
            {
                HrmServiceException HrmServiceException = new HrmServiceException(ex.Message, ex);
                HrmServiceException.Handle();
                throw new FaultException<ServiceFaultExceptionDto>(new ServiceFaultExceptionDto(ex.Message));
            }
        }

        #endregion
    }
}
