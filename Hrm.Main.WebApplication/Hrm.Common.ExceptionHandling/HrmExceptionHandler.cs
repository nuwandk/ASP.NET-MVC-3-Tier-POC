#region Copyright
//------------------------------------------------------------------------
// Copyright (C) Hrm. All Rights Reserved.
//------------------------------------------------------------------------
// Project: 
// Module : .Hrm.Common.ExceptionHandling.
// Author : 
//------------------------------------------------------------------------
#endregion

namespace Hrm.Common.ExceptionHandling
{
    #region Using Directives

    using System;
    using System.Collections.Specialized;
    using Logging;
    using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
    using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
    using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.Configuration;

    #endregion

    /// <summary>
    /// This class is used for handle custom exception according to the exception policy.
    /// </summary>
    [ConfigurationElementType(typeof(CustomHandlerData))]
    public class HrmExceptionHandler : IExceptionHandler
    {

        #region Public Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="ignore">A NameValueCollection object</param>
        public HrmExceptionHandler(NameValueCollection ignore)
        {
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// The HandleException method contains the exception handling logic for the custom 
        /// handler. It returns an exception. This can be the same exception passed to the method
        /// or it can be a new exception created inside the method. 
        /// </summary>
        /// <param name="exception">The exception that needs to handle</param>
        /// <param name="handlingInstanceId">The unique ID attached to the handling chain for this 
        /// handling instance</param>
        public Exception HandleException(Exception exception, Guid handlingInstanceId)
        {
            if (exception == null)
            {
                ArgumentNullException argumentNullException = new ArgumentNullException("exception");
                LogProvider.Log(this.GetType(), LogLevel.Error, argumentNullException.Message, argumentNullException);
                
                return argumentNullException;
            }
            else
            {
                string errorMessage = exception.Message;

                if (String.IsNullOrEmpty(errorMessage))
                {
                    if (exception.InnerException != null)
                    {
                        errorMessage = exception.InnerException.Message.ToString();
                    }
                }

                LogProvider.Log(this.GetType(), LogLevel.Error, errorMessage, exception);
                return exception;
            }
        }
        #endregion
    }
}