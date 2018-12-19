using System;
using NUnit.Framework;
using ProjMgrAPI.Controllers;
using ProjMgrAPI.Models;
using System.Diagnostics;
using System.Web.Mvc;
using System.Web.Http;
using System.Web.Http.Results;
using System.Linq;
using System.Collections.Generic;
using System.Net;

namespace ProjMgrAPI.Tests.Controllers
{
    [TestFixture]
    public class UserControllerTest
    {
        [TestCase]
        public void AddUserTestMethod()
        {
            var userCtrl = new UsersController();


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

        [TestCase]
        public void EditUserTestMethod()
        {
            var userCtrl = new UsersController();


            var user = new user()
            {
                last_name = "Knight2",
                first_name = "Nick1",
                emp_id = 52000,
                 user_id = 1

            };


            IHttpActionResult actResult = userCtrl.Putuser(user.user_id, user);
            var createdResult = actResult as StatusCodeResult;

            Debug.WriteLine(actResult);

            Assert.AreEqual(HttpStatusCode.NoContent, createdResult.StatusCode);
        }


        [TestCase]
        public void GetUserTestMethod()
        {
            var userCtrl = new UsersController();


            int usrid = 2;


            IHttpActionResult actResult = userCtrl.Getuser(usrid);
            var createdResult = actResult as OkNegotiatedContentResult<user>;

            Debug.WriteLine(actResult);

            Assert.AreEqual(usrid, createdResult.Content.user_id);
        }


        [TestCase]
        public void GetUsersTestMethod()
        {
            var userCtrl = new UsersController();


           

            List<user> actResult = userCtrl.Getusers().ToList();


            Debug.WriteLine(actResult);

            Assert.AreEqual(actResult.Count , actResult.Count);
        }



    }
}
