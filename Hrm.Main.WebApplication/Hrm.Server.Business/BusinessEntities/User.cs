#region Copyright
//------------------------------------------------------------------------
// Copyright (C) Hrm. All Rights Reserved.
//------------------------------------------------------------------------
// Project: HR Management System
// Author : Nuwan K
//------------------------------------------------------------------------
#endregion

namespace Hrm.Server.Business
{
    #region Using Directives

    using Hrm.Common.Dto;
    using Hrm.Common.Logging;
    using Hrm.Server.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    #endregion

    /// <summary>
    /// Represents User Business Entity
    /// </summary>
    public class User
    {
        #region Private Members

        // UnitofWork instance for data access operations. 
        private UnitOfWork unitOfWork = new UnitOfWork();

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the name of the user role id by user.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <returns></returns>
        public long GetUserRoleIdByUserName(string userName)
        {
            long roleId = 0;

            if (null != userName)
            {
                //Load the active user with the provided user name
                UserInfo userInfo = this.unitOfWork.UserRepository.Get(includeProperties: "UserRoleMappingInfoes")
                    .Where(x => x.UserName.ToUpper() == userName.ToUpper()).FirstOrDefault();

                //Filter UserRole Mapping based on user id.
                UserRoleMappingInfo userRoleInfo = (userInfo != null && userInfo.UserRoleMappingInfoes != null) ? 
                    userInfo.UserRoleMappingInfoes.Where(x => x.UserId == userInfo.UserId).FirstOrDefault() : null;

                if (userRoleInfo != null && userRoleInfo.UserRoleId != null)
                {
                    return userRoleInfo.UserRoleId.Value;
                }
            }

            // If no matching operation record found, return null
            LogProvider.Log(this.GetType(), LogLevel.Debug, string.Concat("Authorization Failed : Cannot find the User Role for UserName: "
                + userName));

            return roleId;
        }


        /// <summary>
        /// Gets the name of the operation by identifier and user.
        /// </summary>
        /// <param name="operation">The operation.</param>
        /// <param name="userRoleId">The user role identifier.</param>
        /// <returns>OperationDto</returns>
        public OperationDto GetOperationByIdAndUserName(OperationList operation, long userRoleId)
        {
            string operationName = operation.ToString();
            RoleOperationMappingInfo roleOperationMapInfo = null;
            OperationInfo operationInfo = null;

            if(userRoleId > 0)
            {
                // Retrive operation info based on operation name.
                 operationInfo =this.unitOfWork.OperationRepository.Get(includeProperties: "").Where(
                    x => x.Operation.ToUpper() == operationName.ToUpper()).FirstOrDefault();

                if(operationInfo == null)
                {
                    return null;
                }

                // Retrieve role operation mapping info based on operation and user role.
                 roleOperationMapInfo = this.unitOfWork.RoleOperationMappingRepository.Get(
                    includeProperties: "OperationInfo, UserRoleInfo").Where(x => x.UserRoleId == userRoleId &&
                        x.OperationId == operationInfo.OperationId).FirstOrDefault();
            }

            // Get the operation id, if provided operation name has a matching operation
            if (null != roleOperationMapInfo)
            {
                OperationDto operationDto = new OperationDto()
                {
                    Operation = operationInfo.Operation,
                    OperationPk = operationInfo.OperationId
                };

                return operationDto;
            }

            // If no matching operation record found, return null
            LogProvider.Log(this.GetType(), LogLevel.Debug, string.Concat("Authorization Failed : Operation ID for",operationName, " and",
            "UserRoleId for ", userRoleId," cannot resolve due to name mismatch."));

            return null;
        }


        /// <summary>
        /// Gets the name of the user information by user.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <returns></returns>
        public UserDto GetUserInfoByUserName(string userName)
        {
            if (null != userName)
            {
                //Load the active user with the provided user name
                UserInfo userInfo = this.unitOfWork.UserRepository.Get(includeProperties: "")
                    .Where(x => x.UserName.ToUpper() == userName.ToUpper()).FirstOrDefault();

                if (userInfo != null)
                {
                    UserDto userDto = new UserDto();
                    userDto.UserName = userInfo.UserName;
                    userDto.UserPk = userInfo.UserId;
                    userDto.Password = userInfo.Password;

                    return userDto;
                }
            }

            // If no matching operation record found, return null
            LogProvider.Log(this.GetType(), LogLevel.Debug, string.Concat("Cannot find the User for UserName: "
                + userName));

            return null;
        }

        #endregion
    }
}
