#region Copyright
//------------------------------------------------------------------------
// Copyright (C) Hrm. All Rights Reserved.
//------------------------------------------------------------------------
// Project: HR Management System
// Author : Nuwan K
//------------------------------------------------------------------------
#endregion

namespace SiemensEnergy.Frw.Base.Common.Utility
{
    #region Using Directives

    using System;
    using System.Threading.Tasks;

    #endregion

    /// <summary>
    /// This class is used to handle theGenarate Task(new thread) functionalities specific to the REU Region.
    /// </summary>
    public class TaskGenarator<T>
    {

        #region Public Methods

        /// <summary>
        /// Creates the void task.
        /// </summary>
        /// <param name="method">The method.</param>
        /// <returns></returns>
        public Task CreateVoidTask(Action method)
        {
            try
            {
                return Task.Factory.StartNew(() => { method(); });
            }
            catch (Exception)
            {

                throw;
            }

        }

        // With a return type method can use this method to create task
        /// <summary>
        /// Creates the task with return.
        /// </summary>
        /// <param name="method">The method.</param>
        /// <returns></returns>
        public Task<T> CreateTaskWithReturn(Func<T> method)
        {
            try
            {
                return Task<T>.Factory.StartNew(() => { return (method()); });
            }
            catch (Exception)
            {

                throw;
            }

        }

        #endregion

    }
}
