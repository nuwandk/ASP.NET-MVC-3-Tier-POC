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
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;

    #endregion

    /// <summary>
    /// Base class for all dtos...
    /// </summary>
    [DataContract(IsReference = true)]
    public class BaseDto
    {
        /// <summary>
        /// Gets or sets the user name
        /// </summary>
        /// <value>
        /// The CreateUserid.
        /// </value>
        [DataMember]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the Operation Name
        /// </summary>
        /// <value>
        /// The CreateUserid.
        /// </value>
        [DataMember]
        public string Operation { get; set; }
    }
}
