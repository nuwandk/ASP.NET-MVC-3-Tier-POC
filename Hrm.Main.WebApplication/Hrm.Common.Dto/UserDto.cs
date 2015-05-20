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
    /// This class represents User DTO.
    /// </summary> 
    [DataContract (IsReference= true)]
    public partial class UserDto : BaseDto
    {
        public UserDto()
        {
            this.UserRoles = new HashSet<UserRoleDto>();
        }
    
    	/// <summary>
        /// Gets or sets the UserPk.
        /// </summary>
        /// <value>
        /// The UserPk.
        /// </value>
    	[DataMember]
        public long UserPk { get; set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        [DataMember]
        public Guid UserId { get; set; }
      
    	/// <summary>
        /// Gets or sets the UserName.
        /// </summary>
        /// <value>
        /// The UserName.
        /// </value>
    	[DataMember]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [DataMember]        
        public string Password { get; set; }
      
    	/// <summary>
        /// Gets or sets the Email.
        /// </summary>
        /// <value>
        /// The Email.
        /// </value>
    	[DataMember]
        public string Email { get; set; }
      
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
        /// Gets or sets the Description.
        /// </summary>
        /// <value>
        /// The Description.
        /// </value>
    	[DataMember]
        public string Description { get; set; }
      
    	/// <summary>
        /// Gets or sets the IsDelete.
        /// </summary>
        /// <value>
        /// The IsDelete.
        /// </value>
    	[DataMember]
        public Nullable<short> IsDelete { get; set; }
      
    	/// <summary>
        /// Gets or sets the UserNameAlias.
        /// </summary>
        /// <value>
        /// The UserNameAlias.
        /// </value>
    	[DataMember]
        public string UserNameAlias { get; set; }
      
    	/// <summary>
        /// Gets or sets the UserRoles.
        /// </summary>
        /// <value>
        /// The List of UserRoleDto.
        /// </value>
    	[DataMember]
        public virtual ICollection<UserRoleDto> UserRoles { get; set; }
    }
}
