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
    using Common.Dto;

    #endregion

    /// <summary>
    /// This class represents Operation data.
    /// </summary>
    [DataContract(IsReference = true)]
    public partial class OperationDto : BaseDto
    {
        public OperationDto()
        {
        }

        /// <summary>
        /// Gets or sets the OperationPk.
        /// </summary>
        /// <value>
        /// The OperationPk.
        /// </value>
        [DataMember]
        public long OperationPk { get; set; }

        /// <summary>
        /// Gets or sets the Operation.
        /// </summary>
        /// <value>
        /// The Operation.
        /// </value>
        [DataMember]
        public string Operation { get; set; }

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

    }
}
