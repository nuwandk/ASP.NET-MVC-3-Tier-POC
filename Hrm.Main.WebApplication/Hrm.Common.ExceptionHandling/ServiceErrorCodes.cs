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
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Represents Service error codes that used to pass to the client side.
    /// </summary>
    public static class ServiceErrorCodes
    {
        public const string AuthorizationFailed = "Authorization Failed";
    }
}
