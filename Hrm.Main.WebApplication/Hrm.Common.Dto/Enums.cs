#region Copyright
//------------------------------------------------------------------------
// Copyright (C) Hrm. All Rights Reserved.
//------------------------------------------------------------------------
// Project: HR Management System
// Author : Nuwan K
//------------------------------------------------------------------------
#endregion

namespace Hrm.Common.Dto
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    #endregion

    /// <summary>
    /// Enumeration for application operationsfor report specific operations, Administrative tasks or any other user operation. Used in operation authorization.
    /// </summary>
    public enum OperationList
    {
        /// <summary>
        /// The get employee
        /// </summary>
        GetEmployee = 1,

        /// <summary>
        /// The edit employee
        /// </summary>
        EditEmployee = 2,

        /// <summary>
        /// The delete employee
        /// </summary>
        DeleteEmployee = 3,

        /// <summary>
        /// The create employee
        /// </summary>
        CreateEmployee = 4,

        /// <summary>
        /// The generate report
        /// </summary>
        GenerateReport = 5
    }
}
