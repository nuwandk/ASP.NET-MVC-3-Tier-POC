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
    
    public partial class LocationsInfo
    {
        public LocationsInfo()
        {
            this.DepartmentInfoes = new HashSet<DepartmentInfo>();
        }
    
        public int LocationId { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdateUserId { get; set; }
    
        public virtual ICollection<DepartmentInfo> DepartmentInfoes { get; set; }
    }
}