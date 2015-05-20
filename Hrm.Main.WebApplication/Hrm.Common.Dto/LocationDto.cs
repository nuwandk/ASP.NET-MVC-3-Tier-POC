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
    /// Represents Location DTO
    /// </summary>
    public partial class LocationDto : BaseDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationDto"/> class.
        /// </summary>
        public LocationDto()
        {
            this.Departments = new HashSet<DepartmentDto>();
        }

        /// <summary>
        /// Gets or sets the location identifier.
        /// </summary>
        /// <value>
        /// The location identifier.
        /// </value>
        public int LocationId { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        /// <value>
        /// The postal code.
        /// </value>
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the departments.
        /// </summary>
        /// <value>
        /// The departments.
        /// </value>
        public virtual ICollection<DepartmentDto> Departments { get; set; }

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
