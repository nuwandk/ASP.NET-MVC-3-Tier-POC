#region Copyright
//------------------------------------------------------------------------
// Copyright (C) Hrm. All Rights Reserved.
//------------------------------------------------------------------------
// Project: HR Management System
// Author : Nuwan K
//------------------------------------------------------------------------
#endregion

namespace Hrm.Common.Dto
{

    #region using directives

    using System;
    using System.Collections.Generic;

    #endregion

    /// <summary>
    /// Represents Department DTO
    /// </summary>
    public class DepartmentDto : BaseDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DepartmentDto"/> class.
        /// </summary>
        public DepartmentDto()
        {
            this.EmpolyeeHistories = new HashSet<EmpolyeeHistoryDto>();
            this.Employees = new HashSet<EmployeeDto>();
        }

        /// <summary>
        /// Gets or sets the department identifier.
        /// </summary>
        /// <value>
        /// The department identifier.
        /// </value>
        public int DepartmentId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the manager identifier.
        /// </summary>
        /// <value>
        /// The manager identifier.
        /// </value>
        public Nullable<int> ManagerId { get; set; }

        /// <summary>
        /// Gets or sets the location identifier.
        /// </summary>
        /// <value>
        /// The location identifier.
        /// </value>
        public Nullable<int> LocationId { get; set; }

        /// <summary>
        /// Gets or sets the empolyee histories.
        /// </summary>
        /// <value>
        /// The empolyee histories.
        /// </value>
        public virtual ICollection<EmpolyeeHistoryDto> EmpolyeeHistories { get; set; }

        /// <summary>
        /// Gets or sets the employee.
        /// </summary>
        /// <value>
        /// The employee.
        /// </value>
        public virtual EmployeeDto Employee { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        /// <value>
        /// The location.
        /// </value>
        public virtual LocationDto Location { get; set; }

        /// <summary>
        /// Gets or sets the employees.
        /// </summary>
        /// <value>
        /// The employees.
        /// </value>
        public virtual ICollection<EmployeeDto> Employees { get; set; }

        /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        /// <value>
        /// The create date.
        /// </value>
        public Nullable<System.DateTime> CreateDate { get; set; }

        /// <summary>
        /// Gets or sets the create user identifier.
        /// </summary>
        /// <value>
        /// The create user identifier.
        /// </value>
        public string CreateUserId { get; set; }

        /// <summary>
        /// Gets or sets the update date.
        /// </summary>
        /// <value>
        /// The update date.
        /// </value>
        public Nullable<System.DateTime> UpdateDate { get; set; }

        /// <summary>
        /// Gets or sets the update user identifier.
        /// </summary>
        /// <value>
        /// The update user identifier.
        /// </value>
        public string UpdateUserId { get; set; }
    }
}
