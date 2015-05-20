using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hrm.Main.WebApplication.Controllers;
using System.Web.Mvc;

namespace Hrm.Main.WebApplication.UnitTest
{
    [TestClass]
    public class EmployeeControllerTest
    {
           [TestMethod]
          public void TestDetailsView()
          {
               //TODO: Employee object should be inserted first by configruing a test db.
               var controller = new EmployeeController();
               var result = controller.Details(1001) as ViewResult;
               Assert.IsNotNull(result, "DetailsView object is null");
          }

           [TestMethod]
           public void TestIndexView()
           {
               //TODO: Employee object should be inserted first by configruing a test db.
               var controller = new EmployeeController();

               var result = controller.Index() as ViewResult;
               Assert.IsNotNull(result, "IndexView object is null");
           }

        //TODO: Need to complete for rest of the Controller methods.
    }
}
