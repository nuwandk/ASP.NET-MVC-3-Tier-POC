#region Copyright
//------------------------------------------------------------------------
// Copyright (C) Hrm. All Rights Reserved.
//------------------------------------------------------------------------
// Project: HR Management System
// Author : Nuwan K
//------------------------------------------------------------------------
#endregion

namespace Hrm.Server.Services
{
    #region Using Directives

    using Hrm.Common.Dto;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.Text;

    #endregion

    /// <summary>
    /// Represents IReportGenerationService inerface.
    /// </summary>
    [ServiceContract]
    public interface IReportGenerationService
    {
        #region WCF ReportGenerationService Contracts

        /// <summary>
        /// Represents GenerateReport service contract.
        /// </summary>
        [OperationContract]
        [FaultContract(typeof(ServiceFaultExceptionDto))]
        void GenerateReport(ReportDataDto reportDataDto);

        #endregion

    }
}
