
#region Copyright
//------------------------------------------------------------------------
// Copyright (C) Hrm. All Rights Reserved.
//------------------------------------------------------------------------
// Project: HR Management System
// Author : Nuwan K
//------------------------------------------------------------------------
#endregion

namespace Hrm.Main.WebApplication.Controllers
{
    using Hrm.Common.Dto;
    using Hrm.Common.Logging;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel;
    using System.Web;
    using System.Web.Mvc;

    /// <summary>
    /// Base class for all controller classes.
    /// </summary>
    public class BaseController : Controller
    {
        /// <summary>
        /// Catch exceptions thrown from each controller.
        /// </summary>
        /// <param name="filterContext"></param>
        protected override void OnException(ExceptionContext filterContext)
        {
            if (filterContext.ExceptionHandled)
            {
                return;
            }

            // Validate for WCF Service returned exception.
            if (filterContext.Exception is FaultException<ServiceFaultExceptionDto>)
            {
                FaultException<ServiceFaultExceptionDto> faultException = 
                    filterContext.Exception as FaultException<ServiceFaultExceptionDto>;
                LogProvider.Log(this.GetType(), LogLevel.Error, "Service Error Occured: " + faultException.Detail.Message,
                    filterContext.Exception);
            }
            else
            {
                // Log the exception to error log.
                LogProvider.Log(this.GetType(), LogLevel.Error, "Error Occured", filterContext.Exception);
            }

            filterContext.Result = new ViewResult
            {
                ViewName = "~/Views/Shared/Error.cshtml"
            };

            filterContext.ExceptionHandled = true;
        }
    }
}