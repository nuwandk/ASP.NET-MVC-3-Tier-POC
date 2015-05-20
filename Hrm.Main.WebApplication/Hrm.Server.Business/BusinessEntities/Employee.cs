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
    #region Using Directives

    using Hrm.Common.Dto;
    using Hrm.Common.ExceptionHandling;
    using Hrm.Server.Data;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    #endregion

    /// <summary>
    /// This class represents Employee Business Entity
    /// </summary>
    public class Employee : BaseBusinessEntity
    {
        #region Private Members

        private UnitOfWork unitOfWork = new UnitOfWork();

        #endregion

        #region Publick Methods

        /// <summary>
        /// Used to get all employees.
        /// </summary>
        /// <returns>Employee list</returns>
        public IList<EmployeeDto> GetAllEmployees()
        {
            IList<EmployeeDto> employeeDtos = null;

            // Retrieve all employees
            var employeesinfoes = unitOfWork.EmployeeRepository.Get(includeProperties: "DepartmentInfo, EmpolyeeHistoryInfo, EmployeesInfo2").ToList();

            if (employeesinfoes != null)
            {
                employeeDtos = new List<EmployeeDto>();
                // employeeDtos = ObjectCloner.CloneEmpObject(employeesinfoes);

                foreach (var employeeInfo in employeesinfoes)
                {
                    EmployeeDto employeeDto = new EmployeeDto();
                    employeeDto.EmpId = employeeInfo.EmpId;
                    employeeDto.FirstName = employeeInfo.FirstName;
                    employeeDto.LastName = employeeInfo.LastName;
                    employeeDto.Email = employeeInfo.Email;
                    employeeDto.PhoneNumber = employeeInfo.PhoneNumber;
                    employeeDto.Salary = employeeInfo.Salary;
                    employeeDto.DateOfJoin = employeeInfo.DateOfJoin;
                    employeeDto.DepartmentId = employeeInfo.DepartmentId;

                    employeeDto.Department = new DepartmentDto();

                    if (employeeInfo.DepartmentInfo != null)
                    {
                        employeeDto.Department.DepartmentId = employeeInfo.DepartmentInfo.DepartmentId;
                        employeeDto.Department.Name = employeeInfo.DepartmentInfo.Name;
                    }
                    employeeDto.Designation = new DesignationDto();

                    if (employeeInfo.DesignationsInfo != null)
                    {
                        employeeDto.Designation.DesignationId = employeeInfo.DesignationsInfo.DesignationId;
                        employeeDto.Designation.Title = employeeInfo.DesignationsInfo.Title;
                    }
                    employeeDtos.Add(employeeDto);
                }
            }

            return employeeDtos;
        }

        /// <summary>
        /// Used to create employee record.
        /// </summary>
        /// <param name="employeeDto">Employee DTO</param>
        public void Create(EmployeeDto employeeDto)
        {
            EmployeesInfo employeeInfo = new EmployeesInfo();
            employeeInfo.DateOfJoin = employeeDto.DateOfJoin;
            employeeInfo.DepartmentId = employeeDto.DepartmentId;
            employeeInfo.Email = employeeDto.Email;
            employeeInfo.EmpId = employeeDto.EmpId;
            employeeInfo.FirstName = employeeDto.FirstName;
            employeeInfo.JobDesignationId = employeeDto.JobDesignationId;
            employeeInfo.LastName = employeeDto.LastName;
            employeeInfo.ManagerId = employeeDto.ManagerId;
            employeeInfo.PhoneNumber = employeeDto.PhoneNumber;
            employeeInfo.Salary = employeeDto.Salary;

            unitOfWork.EmployeeRepository.Insert(employeeInfo);
            unitOfWork.Save();
        }

        /// <summary>
        /// Used to edit employee record.
        /// </summary>
        /// <param name="employeeDto">Employee DTO</param>
        public void Edit(EmployeeDto employeeDto)
        {
            EmployeesInfo employeeInfo = new EmployeesInfo();
            employeeInfo.DateOfJoin = employeeDto.DateOfJoin;
            employeeInfo.DepartmentId = employeeDto.DepartmentId;
            employeeInfo.Email = employeeDto.Email;
            employeeInfo.EmpId = employeeDto.EmpId;
            employeeInfo.FirstName = employeeDto.FirstName;
            employeeInfo.JobDesignationId = employeeDto.JobDesignationId;
            employeeInfo.LastName = employeeDto.LastName;
            employeeInfo.ManagerId = employeeDto.ManagerId;
            employeeInfo.PhoneNumber = employeeDto.PhoneNumber;
            employeeInfo.Salary = employeeDto.Salary;

            unitOfWork.EmployeeRepository.Update(employeeInfo);
            unitOfWork.Save();
        }

        /// <summary>
        /// Used to delete an department
        /// </summary>
        /// <param name="id">Employee ID</param>
        public void Delete(int id)
        {
            Department department = new Department();
            IList<DepartmentDto> departmentDtos = department.GetAllDepartments();
            departmentDtos = departmentDtos.Where(i => i.ManagerId == id).ToList();

            foreach(DepartmentDto departmentDto in departmentDtos)
            {
                departmentDto.ManagerId = null;
                department.Edit(departmentDto);
            }

            var employeesinfoes = unitOfWork.EmployeeRepository.Get(includeProperties: "").ToList();
            EmployeesInfo employeesinfo = employeesinfoes.Where(e => e.EmpId == id).FirstOrDefault();
            unitOfWork.EmployeeRepository.Delete(employeesinfo);
            unitOfWork.Save();
        }

        #endregion
    }
}
