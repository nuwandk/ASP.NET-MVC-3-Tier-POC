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
    using Hrm.Common.ExceptionHandling;
    using Hrm.Server.Business;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.Text;

    #endregion

    /// <summary>
    /// Represents IUserAdministration Contract implementation.
    /// </summary>
    public class UserAdministration : IUserAdministration
    {
        #region Private Method

        // Service facade for business entities.
        private HrDataServiceFacade hrDataServiceFacade = new HrDataServiceFacade();

        #endregion

        #region Service Contract Implementation Methods

        /// <summary>
        /// Represents GetUserByName service contract.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        /// <exception cref="FaultException{ServiceFaultExceptionDto}">
        /// </exception>
        /// <exception cref="ServiceFaultExceptionDto">
        /// </exception>
        public UserDto GetUserByName(string userName)
        {
            try
            {
                return new User().GetUserInfoByUserName(userName);
            }
            catch (HrmDalException ex)
            {
                ex.Handle();
                throw new FaultException<ServiceFaultExceptionDto>(new ServiceFaultExceptionDto(ex.Message));
            }
            catch (HrmBusinessException ex)
            {
                ex.Handle();
                throw new FaultException<ServiceFaultExceptionDto>(new ServiceFaultExceptionDto(ex.Message));
            }
            catch (HrmException ex)
            {
                ex.Handle();
                throw new FaultException<ServiceFaultExceptionDto>(new ServiceFaultExceptionDto(ex.Message));
            }
            catch (Exception ex)
            {
                HrmServiceException HrmServiceException = new HrmServiceException(ex.Message, ex);
                HrmServiceException.Handle();
                throw new FaultException<ServiceFaultExceptionDto>(new ServiceFaultExceptionDto(ex.Message));
            }
        }


        #endregion
    }
}
