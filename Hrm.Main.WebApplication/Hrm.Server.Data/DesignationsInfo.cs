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
    
    public partial class DesignationsInfo
    {
        public DesignationsInfo()
        {
            this.EmployeesInfoes = new HashSet<EmployeesInfo>();
            this.EmpolyeeHistoryInfoes = new HashSet<EmpolyeeHistoryInfo>();
        }
    
        public int DesignationId { get; set; }
        public string Title { get; set; }
        public Nullable<int> MinSalary { get; set; }
        public Nullable<int> MaxSalary { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdateUserId { get; set; }
    
        public virtual ICollection<EmployeesInfo> EmployeesInfoes { get; set; }
        public virtual ICollection<EmpolyeeHistoryInfo> EmpolyeeHistoryInfoes { get; set; }
    }
}
