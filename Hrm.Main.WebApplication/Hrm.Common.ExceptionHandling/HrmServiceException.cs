#region Copyright
//------------------------------------------------------------------------
// Copyright (C) Hrm. All Rights Reserved.
//------------------------------------------------------------------------
// Project: HR Management System
// Module : Hrm.Common.ExceptionHandling.
// Author : Nuwan K
//------------------------------------------------------------------------
#endregion

namespace Hrm.Common.ExceptionHandling
{
    #region Using Directives

    using System;
    using System.Runtime.Serialization;

    #endregion

    /// <summary>
    /// This class is used for service layer and used for business level errors 
    /// and validations.
    /// </summary>    
    [Serializable()]
    public class HrmServiceException : HrmException
    {
        #region Constants

        private const string ServerErrorFormat = "Server error occured.{0}Error code: {1}{0}Message: {2}";

        #endregion

        #region Public Constructor

        /// <summary>
        /// Default constructor.
        /// </summary>
        public HrmServiceException()
            : base()
        {
        }

        /// <summary>
        /// Overloaded constructor get the message and send it to base class constructor.
        /// </summary>
        /// <param name="message">Exception message.</param>
        public HrmServiceException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Overloaded constructor get the message and innerException
        /// then send it to base class constructor.
        /// </summary>
        /// <param name="message">Exception message.</param>
        /// <param name="innerException">Nested Exception.</param>
        public HrmServiceException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HrmServiceException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="errorCode">The error code.</param>
        /// <param name="innerException">The inner exception.</param>
        public HrmServiceException(string errorCode, string message, Exception innerException)
            : base(string.Format(ServerErrorFormat, Environment.NewLine, errorCode, message), innerException)
        {
        }

        #endregion

        #region Protected Constructor

        /// <summary>
        /// Constructs a FrwUIException class that will be used when deserializing
        /// a serialized FrwUIException object.
        /// </summary>
        /// <param name="serializationInfo">Holds all the data needed to serialize or deserialize 
        /// an object.</param>
        /// <param name="context">Gives the source and destination of the stream being serialized.
        /// </param>
        protected HrmServiceException(SerializationInfo serializationInfo, StreamingContext context)
            : base(serializationInfo, context)
        {
        }

        #endregion
    }
}