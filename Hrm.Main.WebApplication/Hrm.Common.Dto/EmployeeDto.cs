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
    using System.Runtime.Serialization;

    #endregion

    /// <summary>
    /// Represents Employee DTO
    /// </summary>
    [DataContract]
    public class EmployeeDto : BaseDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeDto"/> class.
        /// </summary>
        public EmployeeDto()
        {
        }

        /// <summary>
        /// Gets or sets the emp identifier.
        /// </summary>
        /// <value>
        /// The emp identifier.
        /// </value>
        [DataMember]
        public int EmpId { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        [DataMember]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        [DataMember]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [DataMember]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the job designation identifier.
        /// </summary>
        /// <value>
        /// The job designation identifier.
        /// </value>
        [DataMember]
        public Nullable<int> JobDesignationId { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        [DataMember]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the salary.
        /// </summary>
        /// <value>
        /// The salary.
        /// </value>
        [DataMember]
        public Nullable<int> Salary { get; set; }

        /// <summary>
        /// Gets or sets the department identifier.
        /// </summary>
        /// <value>
        /// The department identifier.
        /// </value>
        [DataMember]
        public Nullable<int> DepartmentId { get; set; }

        /// <summary>
        /// Gets or sets the manager identifier.
        /// </summary>
        /// <value>
        /// The manager identifier.
        /// </value>
        [DataMember]
        public Nullable<int> ManagerId { get; set; }

        /// <summary>
        /// Gets or sets the date of join.
        /// </summary>
        /// <value>
        /// The date of join.
        /// </value>
        [DataMember]
        public Nullable<System.DateTime> DateOfJoin { get; set; }

        //public virtual ICollection<DepartmentDto> Departments { get; set; }
        /// <summary>
        /// Gets or sets the department.
        /// </summary>
        /// <value>
        /// The department.
        /// </value>
        [DataMember]
        public virtual DepartmentDto Department { get; set; }

        /// <summary>
        /// Gets or sets the designation.
        /// </summary>
        /// <value>
        /// The designation.
        /// </value>
        [DataMember]
        public virtual DesignationDto Designation { get; set; }

        /// <summary>
        /// Gets or sets the empolyee history.
        /// </summary>
        /// <value>
        /// The empolyee history.
        /// </value>
        [DataMember]
        public virtual EmpolyeeHistoryDto EmpolyeeHistory { get; set; }

        //  public virtual ICollection<EmployeeDto> Employees1 { get; set; }
        /// <summary>
        /// Gets or sets the employee1.
        /// </summary>
        /// <value>
        /// The employee1.
        /// </value>
        [DataMember]
        public virtual EmployeeDto Employee1 { get; set; }

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
