//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hrm.Server.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class DepartmentInfo
    {
        public DepartmentInfo()
        {
            this.EmpolyeeHistoryInfoes = new HashSet<EmpolyeeHistoryInfo>();
            this.EmployeesInfoes = new HashSet<EmployeesInfo>();
        }
    
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public Nullable<int> ManagerId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdateUserId { get; set; }
    
        public virtual ICollection<EmpolyeeHistoryInfo> EmpolyeeHistoryInfoes { get; set; }
        public virtual EmployeesInfo EmployeesInfo { get; set; }
        public virtual LocationsInfo LocationsInfo { get; set; }
        public virtual ICollection<EmployeesInfo> EmployeesInfoes { get; set; }
    }
}
