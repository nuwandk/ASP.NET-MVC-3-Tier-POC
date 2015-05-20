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
    #region Using Directives
    
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    
    #endregion
    
    /// <summary>
    /// This class represents UserRole DTO. 
    /// </summary>
    [DataContract (IsReference= true)]
    public partial class UserRoleDto : BaseDto
    {
    	/// <summary>
        /// Gets or sets the UserRolePk.
        /// </summary>
        /// <value>
        /// The UserRolePk.
        /// </value>
    	[DataMember]
        public long UserRolePk { get; set; }
      
    	/// <summary>
        /// Gets or sets the UserPk.
        /// </summary>
        /// <value>
        /// The UserPk.
        /// </value>
    	[DataMember]
        public Nullable<long> UserPk { get; set; }
      
    	/// <summary>
        /// Gets or sets the RolePk.
        /// </summary>
        /// <value>
        /// The RolePk.
        /// </value>
    	[DataMember]
        public Nullable<long> RolePk { get; set; }
      
    	/// <summary>
        /// Gets or sets the CreateDate.
        /// </summary>
        /// <value>
        /// The CreateDate.
        /// </value>
    	[DataMember]
        public Nullable<System.DateTime> CreateDate { get; set; }
      
    	/// <summary>
        /// Gets or sets the CreateUserid.
        /// </summary>
        /// <value>
        /// The CreateUserid.
        /// </value>
    	[DataMember]
        public string CreateUserid { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [DataMember]
        public string Description { get; set; }

    	/// <summary>
        /// Gets or sets the LstUpdDate.
        /// </summary>
        /// <value>
        /// The LstUpdDate.
        /// </value>
    	[DataMember]
        public Nullable<System.DateTime> LstUpdDate { get; set; }
      
    	/// <summary>
        /// Gets or sets the LstUpdUserid.
        /// </summary>
        /// <value>
        /// The LstUpdUserid.
        /// </value>
    	[DataMember]
        public string LstUpdUserid { get; set; }
      
    	/// <summary>
        /// Gets or sets the IsDelete.
        /// </summary>
        /// <value>
        /// The IsDelete.
        /// </value>
    	[DataMember]
        public Nullable<short> IsDelete { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [DataMember]
        public string Name  { get; set; }

    	/// <summary>
        /// Gets or sets the Users.
        /// </summary>
        /// <value>
        /// The UserDto.
        /// </value>
    	[DataMember]
        public virtual UserDto Users { get; set; }
    }
}
