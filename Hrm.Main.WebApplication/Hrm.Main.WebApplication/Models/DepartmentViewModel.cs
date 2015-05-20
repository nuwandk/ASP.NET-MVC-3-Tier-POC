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
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// Department Model object which used to bind to the UI
    /// </summary>
    public class DepartmentViewModel
    {
        public DepartmentViewModel()
        {
           // this.EmpolyeeHistoryInfoes = new HashSet<EmpolyeeHistoryInfo>();
            this.EmployeesInfoes = new HashSet<EmployeeViewModel>();
        }

        /// <summary>
        /// Gets or sets the department identifier.
        /// </summary>
        /// <value>
        /// The department identifier.
        /// </value>
        [DisplayName("Department Id")]
        public int DepartmentId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [DisplayName("Department Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the manager identifier.
        /// </summary>
        /// <value>
        /// The manager identifier.
        /// </value>
        [DisplayName("Manager Id")]
        public int ManagerId { get; set; }

        /// <summary>
        /// Gets or sets the location identifier.
        /// </summary>
        /// <value>
        /// The location identifier.
        /// </value>
        [DisplayName("Location Id")]
        public Nullable<int> LocationId { get; set; }
    
       // public virtual ICollection<EmpolyeeHistoryInfo> EmpolyeeHistoryInfoes { get; set; }
        /// <summary>
        /// Gets or sets the employees information.
        /// </summary>
        /// <value>
        /// The employees information.
        /// </value>
        public virtual EmployeeViewModel EmployeesInfo { get; set; }

        //public virtual LocationsInfo LocationsInfo { get; set; }
        /// <summary>
        /// Gets or sets the employees infoes.
        /// </summary>
        /// <value>
        /// The employees infoes.
        /// </value>
        public virtual ICollection<EmployeeViewModel> EmployeesInfoes { get; set; }
    }
}