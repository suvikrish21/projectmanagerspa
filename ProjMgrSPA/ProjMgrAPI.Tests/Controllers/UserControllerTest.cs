using System;
using NUnit.Framework;
using ProjMgrAPI.Controllers;
using ProjMgrAPI.Models;
using System.Diagnostics;
using System.Web.Mvc;
using System.Web.Http;
using System.Web.Http.Results;

namespace ProjMgrAPI.Tests.Controllers
{
    [TestFixture]
    public class UserControllerTest
    {
        [TestCase]
        public void AddUserTestMethod()
        {
            var userCtrl = new UsersAPIController();


            var user = new user()
            {
                last_name = "ramalingam",
                first_name = "krishna",
                emp_id = 251683

            };


            IHttpActionResult actResult = userCtrl.Postuser(user);
            var createdResult = actResult as CreatedAtRouteNegotiatedContentResult<user>;

            Debug.WriteLine(actResult);

            Assert.AreEqual("DefaultApi", createdResult.RouteName);
        }
    }
}
