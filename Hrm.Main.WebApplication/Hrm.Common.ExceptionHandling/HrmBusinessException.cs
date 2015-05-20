#region Copyright
//------------------------------------------------------------------------
// Copyright (C) Hrm. All Rights Reserved.
//------------------------------------------------------------------------
// Project:  Hrm
// Module : Hrm.Common.ExceptionHandling.FrwBusinessException
// Author:
//------------------------------------------------------------------------
#endregion

namespace Hrm.Common.ExceptionHandling
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// This class is used for Business layer exceptions.
    /// </summary>    
    [Serializable()]
    public class HrmBusinessException: HrmException
    {
        #region Public Constructor

        /// <summary>
        /// Default constructor.
        /// </summary>
        public HrmBusinessException() : base()
        {
        }

        /// <summary>
        /// Overloaded constructor get the message and send it to base class constructor.
        /// </summary>
        /// <param name="message">Exception message.</param>
        public HrmBusinessException(string message) : base(message)
        {
        }

        /// <summary>
        /// Overloaded constructor get the message and innerException
        /// then send it to base class constructor.
        /// </summary>
        /// <param name="message">Exception message.</param>
        /// <param name="innerException">Nested Exception.</param>
        public HrmBusinessException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HrmBusinessException"/> class.
        /// </summary>
        /// <param name="errorCode">The error code.</param>
        /// <param name="message">The message.</param>
        /// <param name="innerException">The inner exception.</param>
        public HrmBusinessException(string errorCode, string message, Exception innerException)
            : base(string.Format("Server error occurred. {0}Error code: {1} {0} Message: {2}", Environment.NewLine, errorCode, message), innerException)
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
        protected HrmBusinessException(SerializationInfo serializationInfo, StreamingContext context)
            : base(serializationInfo, context)
        {
        } 
        #endregion
    }
}
