#region Copyright
//------------------------------------------------------------------------
// Copyright (C) Hrm. All Rights Reserved.
//------------------------------------------------------------------------
// Project: 
// Module : Hrm.Common.ExceptionHandling
// Author : 
//------------------------------------------------------------------------
#endregion

namespace Hrm.Common.ExceptionHandling
{
    #region Using Directives

    using System;
    using System.Runtime.Serialization;
    using System.Security.Permissions;
    using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
    using System.Resources;
    using System.Globalization;
    using Hrm.Common.Resources;

    #endregion

    /// <summary>
    /// This class contains Hrm customized exception definition.
    /// </summary>
    [Serializable]
    public class HrmException : Exception
    {
        # region Private Constants
        private const string FrwExceptionPolicyName = "Hrm Exception Policy";
        private const string ErrorCode = "errorCode";
        /// <summary>
        /// Holds the error message to error when accessing resource file
        /// </summary>
        private const string ResourceFileAccessError = "Error When Accessing Resource File";

        #endregion

        #region Private Fields

        /// <summary>
        /// Error code of the exception.
        /// </summary>
        private readonly Enum frwErrorCode;
        #endregion

        #region Protected Constructor

        /// <summary>
        /// Constructs a FrwException class that will be used when deserializing
        /// a serialized FrwException object.
        /// </summary>
        /// <param name="serializationInfo">Holds all the data needed to serialize or deserialize 
        /// an object.</param>
        /// <param name="context">Gives the source and destination of the stream being serialized.
        /// </param>
        protected HrmException(SerializationInfo serializationInfo, StreamingContext context)
            : base(serializationInfo, context)
        {
        }

        #endregion

        #region Public Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public HrmException()
            : base()
        {
        }

        /// <summary>
        /// Constructs a FrwException class with a given message.
        /// The message is assigned to the Message property of the Exception 
        /// class.
        /// </summary>
        /// <param name="message">Message to be displayed to the user.</param>
        public HrmException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Constructs a FrwException class with an BaseErrorCode enum value that 
        /// identifies an error. The system will load the error message corresponding to the 
        /// errorCode from an appropriate resource file and assign it to the Message property 
        /// in the Exception class.
        /// </summary>
        /// <param name="errorCode">The BaseErrorCode enumeration code.</param>
        public HrmException(BaseErrorCode errorCode)
            : base(GetErrorMsg(String.Empty, errorCode))
        {
            frwErrorCode = errorCode;
        }

        /// <summary>
        /// Constructs a FrwException class with a given innerException.
        /// The innerException is assigned to the InnerException property of the Exception 
        /// class.
        /// </summary>
        /// <param name="innerException">InnerException to be wrapped with original exception.</param>
        public HrmException(Exception innerException)
            : base(String.Empty, innerException)
        {
        }

        /// <summary>
        /// Constructs a FrwException class with a given message and an 
        /// BaseErrorCode enum value that identifies an error. The system will load the error 
        /// message corresponding to errorCode from an appropriate resource file and assign it 
        /// to the Message property in the Exception class.
        /// </summary>
        /// <param name="message">Message to be displayed to the user.</param>
        /// <param name="errorCode">The BaseErrorCode enumeration code.</param>
        public HrmException(string message, BaseErrorCode errorCode)
            : base(GetErrorMsg(message, errorCode))
        {
            frwErrorCode = errorCode;
        }

        /// <summary>
        /// Constructs a FrwException class with a given message and 
        /// inner exception object. The message is assigned to the Message property of the 
        /// Exception class.
        /// </summary>
        /// <param name="message">Message to be displayed to the user.</param>
        /// <param name="innerException">Inner FrwException object.</param>
        public HrmException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Constructs a FrwException class with a given error code and inner
        /// exception object. The message fetched from the error code is assigned to the Message
        /// property of the Exception class.
        /// </summary>
        /// <param name="errorCode">The BaseErrorCode enumeration code.</param>
        /// <param name="innerException">Inner FrwException object.</param>
        public HrmException(BaseErrorCode errorCode, Exception innerException)
            : base(GetErrorMsg(string.Empty, errorCode), innerException)
        {
            frwErrorCode = errorCode;
        }

        /// <summary>
        /// Constructs a FrwException class with a given error code and inner
        /// exception object and a more ifnormation string.
        /// The message fetched from the error code is assigned to the Message
        /// property of the Exception class.
        /// </summary>
        /// <param name="errorCode">The BaseErrorCode enumeration code.</param>
        /// <param name="message">Additional information to help developer</param>
        /// <param name="innerException">Inner FrwException object.</param>
        public HrmException(string message, BaseErrorCode errorCode,
            Exception innerException)
            : base(GetErrorMsg(message, errorCode), innerException)
        {
            frwErrorCode = errorCode;
        }

        /// <summary>
        /// Constructs a FrwException class with a given error code and inner
        /// exception object. The message fetched from the error code is assigned to the Message
        /// property of the Exception class.
        /// </summary>
        /// <param name="errorCode">The BaseErrorCode enumeration code.</param>
        /// <param name="innerException">Inner FrwException object.</param>
        public HrmException(WcfServiceErrorCode errorCode, Exception innerException)
            : base(GetErrorMsg(string.Empty, errorCode), innerException)
        {
            frwErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HrmException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="errorCode">The error code.</param>
        /// <param name="innerException">The inner exception.</param>
        public HrmException(string message, WcfServiceErrorCode errorCode,
            Exception innerException)
            : base(GetErrorMsg(message, errorCode), innerException)
        {
            frwErrorCode = errorCode;
        }

        #endregion

        #region Private Methods
        /// <summary>
        /// Overloaded. Obtains the resource string from the particular resource file of the
        /// Exception Module, namely CommonResource.en-US.resx.
        /// </summary>
        /// <param name="message">Error message to be displayed to the user.</param>
        /// <param name="errorCode">The Enum enumeration code.</param> 
        private static string GetErrorMsg(string message, Enum errorCode)
        {
            if (errorCode == null)
            {
                throw new ArgumentNullException(ErrorCode);
            }

            try
            {
                ResourceManager resourceManager = ExceptionMessageResource.ResourceManager;
                string errorMessage = resourceManager.GetString(errorCode.ToString());

                return String.IsNullOrEmpty(message) ? errorMessage :
                                                        string.Concat(errorMessage, ":", message);
            }
            catch
            {
                //Changed to return System Exception due to cyclic defect in FrwException
                return ResourceFileAccessError;
            }
        }

        #endregion

        #region Public Methods
        /// <summary>
        /// Handle the exception using configured exception policy
        /// </summary>        
        public bool Handle()
        {
            return ExceptionPolicy.HandleException(this, FrwExceptionPolicyName);
        }

        /// <summary>
        /// Collects the information to be serialized.
        /// </summary>
        /// <param name="info">Holds all the data needed to serialize or deserialize 
        /// an object.</param>
        /// <param name="context">Gives the source and destination of the stream being serialized.
        /// </param>
        [SecurityPermission(SecurityAction.LinkDemand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
        #endregion
    }
}
