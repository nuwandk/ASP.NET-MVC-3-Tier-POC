#region Copyright
//------------------------------------------------------------------------
// Copyright (C) Hrm. All Rights Reserved.
//------------------------------------------------------------------------
// Project: HR Management System
// Author : Nuwan K
//------------------------------------------------------------------------
#endregion

namespace SiemensEnergy.Frw.Main.Common.Business
{
    #region Using Directives

    using Hrm.Common.Resources;
    using Hrm.Common.Dto;
    using Hrm.Common.Logging;
    using Hrm.Common.Resources;
    using Hrm.Server.Business;
    using Hrm.Server.Business;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    /// <summary>
    /// Validation methods for authorization.
    /// </summary>
    public class AuthorizationManager
    {
        #region Private Field

        #endregion

        #region Public Methods

        /// <summary>
        /// Determines whether the specified user is authorized to perform the particular operation.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="operation">The operation.</param>
        /// <returns>
        /// <c>true</c> if the specified user is authorized; otherwise, <c>false</c>.
        /// </returns>
        public bool IsAuthorized(string userName, OperationList operation, out string message)
        {
            User user = new User();

            message = CommonResource.UserNotAuthorized;

            long roleId;

            if (null == userName)
            {
                return false;
            }

            // Get the role id for the current user
            roleId = user.GetUserRoleIdByUserName(userName);

            if (roleId != 0)
            {
                // Get the Operation Dto based on operation name and the role id.
                OperationDto operationDto = user.GetOperationByIdAndUserName(operation, roleId);
                // Set true if a mapping exists for role id
                if (operationDto != null)
                {
                    LogProvider.Log(typeof(AuthorizationManager), LogLevel.Debug, string.Concat("Authorization Successful for user : ", userName, " Operation : ", operation.ToString()), userName);
                    message = CommonResource.AuthorizationSuccessful;
                    return true;
                }

                LogProvider.Log(typeof(AuthorizationManager), LogLevel.Error, string.Concat("Authorization Failed : Operation ",
                    operation.ToString(), " is not assigned to the role ", roleId), userName);
            }

            return false;
        }

        #endregion

    }
}
