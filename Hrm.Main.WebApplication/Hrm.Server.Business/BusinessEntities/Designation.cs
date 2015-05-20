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
    using Hrm.Common.ExceptionHandling;
    using Hrm.Server.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    #endregion

    /// <summary>
    /// This class represents the Designation business entity
    /// </summary>
    public class Designation : BaseBusinessEntity
    {
        #region Private Members

        private UnitOfWork unitOfWork = new UnitOfWork();

        #endregion

        #region Public Methods

        /// <summary>
        /// Used to get all designations.
        /// </summary>
        /// <returns>Employee list</returns>
        public IList<DesignationDto> GetAllDesignation()
        {
            IList<DesignationDto> designationDtos = null;
            //var designationInfoes = db.DesignationsInfoes.ToList();
            var designationInfoes = unitOfWork.DesignationRepository.Get(includeProperties: "").ToList();


            if (designationInfoes != null)
            {
                designationDtos = new List<DesignationDto>();

                foreach (DesignationsInfo designationsInfo in designationInfoes)
                {
                    DesignationDto designationDto = new DesignationDto();
                    designationDto.DesignationId = designationsInfo.DesignationId;
                    designationDto.MaxSalary = designationsInfo.MaxSalary;
                    designationDto.MinSalary = designationsInfo.MinSalary;
                    designationDto.Title = designationsInfo.Title;

                    designationDtos.Add(designationDto);
                }
            }

            return designationDtos;
        }

        #endregion
    }
}
