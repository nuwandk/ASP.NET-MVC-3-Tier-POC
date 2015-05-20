#region Copyright
//------------------------------------------------------------------------
// Copyright (C) Hrm. All Rights Reserved.
//------------------------------------------------------------------------
// Project: 
// Module : Hrm.Common.ExceptionHandling.CustomFault
//------------------------------------------------------------------------
#endregion

namespace Hrm.Common.ExceptionHandling
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    #endregion

    /// <summary>
    /// Class to wrap service level fault exception
    /// </summary>
    [DataContract]
    public class CustomServiceFault
    {
        #region Private Fields

        private string message;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomServiceFault"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public CustomServiceFault(string message)
        {
            this.message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomServiceFault"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public CustomServiceFault(string message, Exception exception)
        {
            this.message = message;
            Exception = exception;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        [DataMember]
        public string Message
        {
            get
            {
                return message;
            }

            set
            {
                message = value;
            }
        }

        /// <summary>
        /// Gets or sets the exception.
        /// </summary>
        /// <value>
        /// The exception.
        /// </value>
        [DataMember]
        public Exception Exception { get; set; }

        #endregion
    }
}
