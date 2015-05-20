#region Copyright
//------------------------------------------------------------------------
// Copyright (C) Hrm. All Rights Reserved.
//------------------------------------------------------------------------
// Project:  Hrm Management System
// Author: Nuwan K
//------------------------------------------------------------------------
#endregion

namespace Hrm.Server.Data
{
    #region Using Directives

    using Hrm.Common.ExceptionHandling;
    using System;

    #endregion

    /// <summary>
    /// This class represents UnitOfWork for the HRM DB Context
    /// </summary>
    public class UnitOfWork : IDisposable
    {
        #region Private Memmbers

        private HrManagementDbEntities context = new HrManagementDbEntities();
        private GenericRepository<EmployeesInfo> employeeRepository;
        private GenericRepository<DepartmentInfo> departmentRepository;
        private GenericRepository<DesignationsInfo> designationsRepository;
        private GenericRepository<OperationInfo> operationRepository;
        private GenericRepository<UserRoleMappingInfo> userRoleMappingRepository;
        private GenericRepository<UserRoleInfo> userRoleRepository;
        private GenericRepository<UserInfo> userRepository;
        private GenericRepository<RoleOperationMappingInfo> roleOperationMappingRepository;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the employee repository.
        /// </summary>
        /// <value>
        /// The employee repository.
        /// </value>
        public GenericRepository<EmployeesInfo> EmployeeRepository
        {
            get
            {
                if (this.employeeRepository == null)
                {
                    this.employeeRepository = new GenericRepository<EmployeesInfo>(context);
                }
                return employeeRepository;
            }
        }

        /// <summary>
        /// Gets the department repository.
        /// </summary>
        /// <value>
        /// The department repository.
        /// </value>
        public GenericRepository<DepartmentInfo> DepartmentRepository
        {
            get
            {
                if (this.departmentRepository == null)
                {
                    this.departmentRepository = new GenericRepository<DepartmentInfo>(context);
                }
                return departmentRepository;
            }
        }

        /// <summary>
        /// Gets the designation repository.
        /// </summary>
        /// <value>
        /// The designation repository.
        /// </value>
        public GenericRepository<DesignationsInfo> DesignationRepository
        {
            get
            {
                if (this.designationsRepository == null)
                {
                    this.designationsRepository = new GenericRepository<DesignationsInfo>(context);
                }
                return designationsRepository;
            }
        }

        /// <summary>
        /// Gets or sets the operation repository.
        /// </summary>
        /// <value>
        /// The operation repository.
        /// </value>
        public GenericRepository<OperationInfo> OperationRepository
        {
            get
            {
                if (this.operationRepository == null)
                {
                    this.operationRepository = new GenericRepository<OperationInfo>(context);
                }
                return operationRepository;
            }
            set
            {
                operationRepository = value;
            }
        }


        /// <summary>
        /// Gets or sets the role operation mapping repository.
        /// </summary>
        /// <value>
        /// The role operation mapping repository.
        /// </value>
        public GenericRepository<RoleOperationMappingInfo> RoleOperationMappingRepository
        {
            get
            {
                if (this.roleOperationMappingRepository == null)
                {
                    this.roleOperationMappingRepository = new GenericRepository<RoleOperationMappingInfo>(context);
                }
                    return roleOperationMappingRepository;  
            }
            set
            {
                roleOperationMappingRepository = value;
            }
        }


        /// <summary>
        /// Gets or sets the user repository.
        /// </summary>
        /// <value>
        /// The user repository.
        /// </value>
        public GenericRepository<UserInfo> UserRepository
        {
            get
            {
                if(this.userRepository == null)
                {
                    this.userRepository = new GenericRepository<UserInfo>(context);
                }
                return userRepository;
            }
            set
            {
                userRepository = value;
            }
        }


        /// <summary>
        /// Gets or sets the user role repository.
        /// </summary>
        /// <value>
        /// The user role repository.
        /// </value>
        public GenericRepository<UserRoleInfo> UserRoleRepository
        {
            get
            {
                if (this.userRoleRepository == null)
                {
                    this.userRoleRepository = new GenericRepository<UserRoleInfo>(context);
                }

                return userRoleRepository;
            }
            set
            {
                userRoleRepository = value;
            }
        }


        /// <summary>
        /// Gets or sets the user role mapping repository.
        /// </summary>
        /// <value>
        /// The user role mapping repository.
        /// </value>
        public GenericRepository<UserRoleMappingInfo> UserRoleMappingRepository
        {
            get
            {
                if (this.userRoleMappingRepository == null)
                {
                    this.userRoleMappingRepository = new GenericRepository<UserRoleMappingInfo>(context);
                }

                return userRoleMappingRepository;
            }
            set
            {
                userRoleMappingRepository = value;
            }
        }



        #endregion

        #region Public Methods

        /// <summary>
        /// Saves this instance to the DB context.
        /// </summary>
        public void Save()
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception exception)
            {
                HrmDalException hrmDalException = new HrmDalException("Exception occured during data persistant", exception);
                hrmDalException.Handle();

                throw hrmDalException;
            }

        }
        #endregion

        #region Disposable Methods

        private bool disposed = false;

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}

