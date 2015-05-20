using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hrm.Common.Dto;
using System.Collections.Generic;

namespace Hrm.Server.Business.UnitTest
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void GetAllEmployeesTest()
        {
            Employee emp = new Employee();
           IList<EmployeeDto> EmpList =   emp.GetAllEmployees();

           Assert.IsTrue(EmpList != null, "Employee List is not empty");
        }
    }
}
