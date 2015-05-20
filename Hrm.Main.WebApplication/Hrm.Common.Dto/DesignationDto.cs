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
    /// Represents Designation DTO
    /// </summary>
    public class DesignationDto : BaseDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DesignationDto"/> class.
        /// </summary>
        public DesignationDto()
        {
            this.Employees = new HashSet<EmployeeDto>();
            this.EmpolyeeHistories = new HashSet<EmpolyeeHistoryDto>();
        }

        /// <summary>
        /// Gets or sets the designation identifier.
        /// </summary>
        /// <value>
        /// The designation identifier.
        /// </value>
        public int DesignationId { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the minimum salary.
        /// </summary>
        /// <value>
        /// The minimum salary.
        /// </value>
        public Nullable<int> MinSalary { get; set; }

        /// <summary>
        /// Gets or sets the maximum salary.
        /// </summary>
        /// <value>
        /// The maximum salary.
        /// </value>
        public Nullable<int> MaxSalary { get; set; }

        /// <summary>
        /// Gets or sets the employees.
        /// </summary>
        /// <value>
        /// The employees.
        /// </value>
        public virtual ICollection<EmployeeDto> Employees { get; set; }

        /// <summary>
        /// Gets or sets the empolyee histories.
        /// </summary>
        /// <value>
        /// The empolyee histories.
        /// </value>
        public virtual ICollection<EmpolyeeHistoryDto> EmpolyeeHistories { get; set; }

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
