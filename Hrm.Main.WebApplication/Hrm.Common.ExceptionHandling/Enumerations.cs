#region Copyright
//------------------------------------------------------------------------
// Copyright (C) Hrm. All Rights Reserved.
//------------------------------------------------------------------------
// Project: 
// Module : Hrm.Common.ExceptionHandling.
// Author:
//------------------------------------------------------------------------
#endregion

namespace Hrm.Common.ExceptionHandling
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// General error codes for whole application.
    /// </summary>
    public enum BaseErrorCode
    {
        /// <summary>
        /// Represents an unexpected error that occurs in the system.
        /// </summary>
        UnexpectedError,

        /// <summary>
        /// Represents an unexpected server error that occurs in the system.
        /// </summary>
        UnexpectedServerError,

        /// <summary>
        /// Represents an operation that is not supported by the system.
        /// </summary>
        UnsupportedOperation,

        /// <summary>
        /// Represents an empty string is passed as an argument.
        /// </summary>
        ArgumentIsEmpty,

        /// <summary>
        /// Represents a <c>null</c> value is passed as an argument.
        /// </summary>
        ArgumentIsNull,

        /// <summary>
        /// Represents an invalid argument.
        /// </summary>
        ArgumentIsInvalid,

        /// <summary>
        /// Represents a timeout while waiting for an operation to complete.
        /// </summary>
        Timeout,

        /// <summary>
        /// When a resource string is not found in the specified resource file for the 
        /// specified id.
        /// </summary>
        ResourceNotFound,


        /// <summary>
        /// Represents an exception thrown to acknowledge that the user do not has the 
        /// permission to use the specific service 
        /// </summary>
        AccessDenied,

        /// <summary>
        /// Represents an exception thrown when there is no more space on the disk for I/O 
        /// operations.
        /// </summary>
        DiskFullException,

        /// <summary>
        /// Reprersent an exception when the required file is being used by another process
        /// </summary>
        FileAccessError,
    }

    /// <summary>
    /// Represents a set of general error codes which are common to all exception classes 
    /// related to WCF service classes.
    /// </summary>
    public enum WcfServiceErrorCode
    {
        /// <summary>
        /// Represents an error that occurs when a web requests contains XML that is invalid.
        /// </summary>
        InvalidSchema,

        /// <summary>
        /// Represents an error that occurs when a web requests is failed.
        /// </summary>
        WebServiceFailure,

        /// <summary>
        /// Represents an error that occurs when a argument fails.
        /// </summary>
        ArgumentException,

        /// <summary>
        /// Represents an error that occurs when accessing data access layer in service.
        /// </summary>
        DalException,

        /// <summary>
        /// Represents an error that occurs when accessing business layer in service.
        /// </summary>
        BusinessException,

        /// <summary>
        /// Represents an error that occurs where exceptions are not handled in the service.
        /// </summary>
        UnhandledException

    }

}
