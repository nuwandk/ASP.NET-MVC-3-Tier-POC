#region Copyright
//------------------------------------------------------------------------
// Copyright (C) Hrm. All Rights Reserved.
//------------------------------------------------------------------------
// Project: HR Management System
// Author : Nuwan K
//------------------------------------------------------------------------
#endregion

namespace Hrm.Main.WebApplication.Models
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    #endregion

    /// <summary>
    /// Employee Model object which used to bind to the UI
    /// </summary>
    public class EmployeeViewModel
    {
        #region Public Constructors
 
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeViewModel"/> class.
        /// </summary>
        public EmployeeViewModel()
        {
            this.DepartmentInfoes = new HashSet<DepartmentViewModel>();
            this.EmployeesInfo1 = new HashSet<EmployeeViewModel>();
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the emp identifier.
        /// </summary>
        /// <value>
        /// The emp identifier.
        /// </value>
        [DisplayName("Employee Id")]
        public int EmpId { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [DisplayName("Email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the job designation identifier.
        /// </summary>
        /// <value>
        /// The job designation identifier.
        /// </value>
        [DisplayName("Designation")]
        public Nullable<int> JobDesignationId { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        [StringLength(10, ErrorMessage = "The {0} value cannot exceed 10 characters. ")]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the salary.
        /// </summary>
        /// <value>
        /// The salary.
        /// </value>
        [DisplayName("Salary")]
        public Nullable<int> Salary { get; set; }

        /// <summary>
        /// Gets or sets the department identifier.
        /// </summary>
        /// <value>
        /// The department identifier.
        /// </value>
        [DisplayName("Department")]
        public Nullable<int> DepartmentId { get; set; }

        /// <summary>
        /// Gets or sets the manager identifier.
        /// </summary>
        /// <value>
        /// The manager identifier.
        /// </value>
        [DisplayName("Manager Id")]
        public Nullable<int> ManagerId { get; set; }

        /// <summary>
        /// Gets or sets the date of join.
        /// </summary>
        /// <value>
        /// The date of join.
        /// </value>
        [DisplayName("Date Of Join")]
        public Nullable<System.DateTime> DateOfJoin { get; set; }


        /// <summary>
        /// Gets or sets the department infoes.
        /// </summary>
        /// <value>
        /// The department infoes.
        /// </value>
        public virtual ICollection<DepartmentViewModel> DepartmentInfoes { get; set; }
        /// <summary>
        /// Gets or sets the department information.
        /// </summary>
        /// <value>
        /// The department information.
        /// </value>
        public virtual DepartmentViewModel DepartmentInfo { get; set; }
        /// <summary>
        /// Gets or sets the designations information.
        /// </summary>
        /// <value>
        /// The designations information.
        /// </value>
        public virtual DesignationViewModel DesignationsInfo { get; set; }
        //public virtual EmpolyeeHistoryInfo EmpolyeeHistoryInfo { get; set; }
        /// <summary>
        /// Gets or sets the employees info1.
        /// </summary>
        /// <value>
        /// The employees info1.
        /// </value>
        public virtual ICollection<EmployeeViewModel> EmployeesInfo1 { get; set; }
        /// <summary>
        /// Gets or sets the employees info2.
        /// </summary>
        /// <value>
        /// The employees info2.
        /// </value>
        public virtual EmployeeViewModel EmployeesInfo2 { get; set; }

        #endregion
    }
}