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
    /// This class represents Department Business Entity.
    /// </summary>
    public class Department : BaseBusinessEntity
    {
        #region Private members

        private UnitOfWork unitOfWork = new UnitOfWork();

        #endregion

        #region Public Methods

        /// <summary>
        /// Used to get all departments.
        /// </summary>
        /// <returns>Employee list</returns>
        public IList<DepartmentDto> GetAllDepartments()
        {
            IList<DepartmentDto> departmentDtos = null;
            var departmentinfoes = unitOfWork.DepartmentRepository.Get(includeProperties: "EmployeesInfo, LocationsInfo").ToList();

            if (departmentinfoes != null)
            {
                departmentDtos = new List<DepartmentDto>();

                foreach (DepartmentInfo departmentInfo in departmentinfoes)
                {
                    DepartmentDto departmentDto = new DepartmentDto();
                    departmentDto.DepartmentId = departmentInfo.DepartmentId;
                    departmentDto.Name = departmentInfo.Name;
                    departmentDtos.Add(departmentDto);
                }
            }

            return departmentDtos;
        }

        /// <summary>
        /// Used to edit department record.
        /// </summary>
        /// <param name="employeeDto">Employee DTO</param>
        public void Edit(DepartmentDto departmentDto)
        {
            DepartmentInfo departmentInfo = new DepartmentInfo();
            departmentInfo.DepartmentId = departmentDto.DepartmentId;
            departmentInfo.LocationId = departmentDto.LocationId;
            departmentInfo.ManagerId = departmentDto.ManagerId;
            departmentDto.Name = departmentDto.Name;

            unitOfWork.DepartmentRepository.Update(departmentInfo);
            unitOfWork.Save();
        }

        #endregion
    }
}
