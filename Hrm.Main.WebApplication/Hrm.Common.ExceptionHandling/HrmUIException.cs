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
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// This class is used for central manager UI and used for business level errors 
    /// and validations.
    /// </summary>    
    [Serializable()]
    public class HrmUiException : HrmException
    {
        #region Public Constructor

        /// <summary>
        /// Default constructor.
        /// </summary>
        public HrmUiException() : base()
        {
        }

        /// <summary>
        /// Overloaded constructor get the message and send it to base class constructor.
        /// </summary>
        /// <param name="message">Exception message.</param>
        public HrmUiException(string message) : base(message)
        {
        }

        /// <summary>
        /// Overloaded constructor get the message and innerException
        /// then send it to base class constructor.
        /// </summary>
        /// <param name="message">Exception message.</param>
        /// <param name="innerException">Nested Exception.</param>
        public HrmUiException(string message, Exception innerException)
            : base(message, innerException)
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
        protected HrmUiException(SerializationInfo serializationInfo, StreamingContext context)
            : base(serializationInfo, context)
        {
        }

        #endregion
    }
}