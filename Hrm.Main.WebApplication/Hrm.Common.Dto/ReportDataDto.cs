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
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Threading.Tasks;

    #endregion

    /// <summary>
    /// Represnts Report Data Dto
    /// </summary>
    [DataContract(IsReference = true)]
    public class ReportDataDto : BaseDto
    {
        /// <summary>
        /// Gets or sets the report type identifier.
        /// </summary>
        /// <value>
        /// The report type identifier.
        /// </value>
        [DataMember]
        public string ReportTypeId { get; set; }

        /// <summary>
        /// Gets or sets the report status.
        /// </summary>
        /// <value>
        /// The report status.
        /// </value>
        [DataMember]
        public string ReportStatus { get; set; }

        /// <summary>
        /// Gets or sets the report author.
        /// </summary>
        /// <value>
        /// The report author.
        /// </value>
        [DataMember]
        public string ReportAuthor { get; set; }

        /// <summary>
        /// Gets or sets the report identifier.
        /// </summary>
        /// <value>
        /// The report identifier.
        /// </value>
        [DataMember]
        public long ReportId { get; set; }
    }
}
