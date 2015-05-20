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
    /// Service fault exception dto.
    /// </summary>
    [DataContract]
    public class ServiceFaultExceptionDto
    {
        /// <summary>
        /// The message
        /// </summary>
        private string message;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceFaultExceptionDto"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public ServiceFaultExceptionDto(string message)
        {
            this.message = message;
        }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        [DataMember]
        public string Message { get { return this.message; } set { this.message = value; } }
    }
}

