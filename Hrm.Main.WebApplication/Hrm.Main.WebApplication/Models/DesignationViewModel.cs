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
    /// Designation Model object which used to bind to the UI
    /// </summary>
    public  class DesignationViewModel
    {
        public DesignationViewModel()
        {
            this.EmployeesInfoes = new HashSet<EmployeeViewModel>();
           // this.EmpolyeeHistoryInfoes = new HashSet<EmpolyeeHistoryInfo>();
        }

        /// <summary>
        /// Gets or sets the designation identifier.
        /// </summary>
        /// <value>
        /// The designation identifier.
        /// </value>
        [DisplayName("Designation Id")]
        public int DesignationId { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [DisplayName("Designation")]
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
    
        public virtual ICollection<EmployeeViewModel> EmployeesInfoes { get; set; }
       // public virtual ICollection<EmpolyeeHistoryInfo> EmpolyeeHistoryInfoes { get; set; }
    }
}