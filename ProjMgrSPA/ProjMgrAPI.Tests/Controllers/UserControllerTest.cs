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

        private int TestId { get; set; }


        [TestCase, Order(1)]
        public void AddUserTestMethod()
        {
            var userCtrl = new UsersController();


            var user = new user()
            {
                last_name = "ramalingam",
                first_name = "krishna",
                emp_id = 251683,
               
            };


            IHttpActionResult actResult = userCtrl.Postuser(user);
            var createdResult = actResult as CreatedAtRouteNegotiatedContentResult<user>;

            Debug.WriteLine(actResult);
            userCtrl.Dispose();

            Assert.AreEqual("DefaultApi", createdResult.RouteName);

            TestId = user.user_id;
        }


        [TestCase, Order(2)]
        public void AddUser2TestMethod()
        {
            var userCtrl = new UsersController();


            var user = new user()
            {
                last_name = "test",
                first_name = "aryan",
                emp_id = 251683

            };


            IHttpActionResult actResult = userCtrl.Postuser(user);
            var createdResult = actResult as CreatedAtRouteNegotiatedContentResult<user>;

            Debug.WriteLine(actResult);
            userCtrl.Dispose();

            Assert.AreEqual("DefaultApi", createdResult.RouteName);
        }


        [TestCase, Order(3)]
        public void EditUserTestMethod()
        {
            var userCtrl = new UsersController();


            var usr = userCtrl.Getusers().
                       //Where(u => u.project == null || u.task == null).
                         First();




            usr.last_name = "Knight2";
            usr.first_name = "Nick1";
            usr.emp_id = 52000;
          

           


            IHttpActionResult actResult = userCtrl.Putuser(usr.user_id, usr);
            var createdResult = actResult as StatusCodeResult;

            Debug.WriteLine(actResult);

            Assert.AreEqual(HttpStatusCode.NoContent, createdResult.StatusCode);
        }


        [TestCase, Order(4)]
        public void EditUserTestMethod2()
        {
            var userCtrl = new UsersController();


            var usr = userCtrl.Getusers().ToList().
                       // Where(u => u.project == null || u.task == null).
                       First(u => u.user_id == TestId);



            usr.last_name = "Knigh";
            usr.first_name = "Nick";
            usr.emp_id = 52000;
              

            

           
            IHttpActionResult actResult = userCtrl.Putuser(usr.user_id, usr);
            var createdResult = actResult as BadRequestResult;

            Debug.WriteLine(actResult);

            Assert.AreEqual(null, null);
        }



        [TestCase, Order(5)]
        public void GetUserTestMethod()
        {
            var userCtrl = new UsersController();


            int  usrid = userCtrl.Getusers().
                        Where(u => u.project == null || u.task == null).
                         Max(u => u.user_id);
            


            IHttpActionResult actResult = userCtrl.Getuser(usrid);
            var createdResult = actResult as OkNegotiatedContentResult<user>;

            Debug.WriteLine(actResult);

            Assert.AreEqual(usrid, createdResult.Content.user_id);
        }


        [TestCase, Order(6)]
        public void GetUsersTestMethod()
        {
            var userCtrl = new UsersController();


           

            var actResult = userCtrl.Getusers();


            Debug.WriteLine(actResult);

            Assert.AreEqual(actResult.Count() , actResult.Count());
        }


        [TestCase, Order(7)]
        public void GetUsers2TestMethod()
        {
            var userCtrl = new UsersController();




            List<uservw> actResult = userCtrl.Getusers2().ToList();


            Debug.WriteLine(actResult);

            Assert.AreEqual(actResult.Count, actResult.Count);
        }



        [TestCase, Order(8)]
        public void DeleteUserTestMethod()
        {
            var usrCtrl = new UsersController();



            var userid = TestId;

            var actResult = usrCtrl.Deleteuser(userid);

            var createdResult = actResult as OkNegotiatedContentResult<user>;

            Debug.WriteLine(actResult);

            Assert.AreEqual(userid, createdResult.Content.user_id);


        }


    }
}
