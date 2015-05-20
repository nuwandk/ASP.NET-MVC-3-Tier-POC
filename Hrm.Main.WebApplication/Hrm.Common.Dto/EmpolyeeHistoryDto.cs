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
    /// Represents Employee History DTO
    /// </summary>
    public class EmpolyeeHistoryDto : BaseDto
    {
        /// <summary>
        /// Gets or sets the emp identifier.
        /// </summary>
        /// <value>
        /// The emp identifier.
        /// </value>
        public int EmpId { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>
        /// The start date.
        /// </value>
        public Nullable<System.DateTime> StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>
        /// The end date.
        /// </value>
        public Nullable<System.DateTime> EndDate { get; set; }

        /// <summary>
        /// Gets or sets the designation identifier.
        /// </summary>
        /// <value>
        /// The designation identifier.
        /// </value>
        public Nullable<int> DesignationId { get; set; }

        /// <summary>
        /// Gets or sets the department identifier.
        /// </summary>
        /// <value>
        /// The department identifier.
        /// </value>
        public Nullable<int> DepartmentId { get; set; }

        /// <summary>
        /// Gets or sets the department.
        /// </summary>
        /// <value>
        /// The department.
        /// </value>
        public virtual DepartmentDto Department { get; set; }

        /// <summary>
        /// Gets or sets the designation.
        /// </summary>
        /// <value>
        /// The designation.
        /// </value>
        public virtual DesignationDto Designation { get; set; }

        /// <summary>
        /// Gets or sets the employee.
        /// </summary>
        /// <value>
        /// The employee.
        /// </value>
        public virtual EmployeeDto Employee { get; set; }

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
