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
    public class ProjectControllerTest
    {
        private int TestId { get; set; }

        [TestCase, Order(1)]
        public void AddProjectTestMethod()
        {
            var projctrl = new ProjectsController();

           
            var proj = new project()
            {
                 project1 ="Project ABC",
                 
                  
            };


            IHttpActionResult actResult = projctrl.Postproject(proj);
            var createdResult = actResult as CreatedAtRouteNegotiatedContentResult<project>;

            Debug.WriteLine(actResult);

            Assert.AreEqual("DefaultApi", createdResult.RouteName);

            TestId = proj.project_id;
        }


        [TestCase, Order(2)]
        public void AddProjectTestMethod1()
        {
            var projctrl = new ProjectsController();

          

            var proj = new project()
            {
                project1 = "Project XYZ",
                priority =  23,
                start_dt = DateTime.Now,
                end_dt = DateTime.Now,
               
            };


            IHttpActionResult actResult = projctrl.Postproject(proj);
            var createdResult = actResult as CreatedAtRouteNegotiatedContentResult<project>;

            Debug.WriteLine(actResult);

            projctrl.Dispose();

            Assert.AreEqual("DefaultApi", createdResult.RouteName);
        }

        [TestCase, Order(3)]
        public void AddProjectTestMethod2()
        {
            var projctrl = new ProjectsController();
            var userCtrl = new UsersController();

            var userid = userCtrl.Getusers().ToList().
                       Where(u => u.project == null || u.task == null).
                        Max(u => u.user_id);


            var usr = new user { user_id = userid };

            var proj = new project()
            {
                project1 = "Project ABC",
                 priority = 3,
                  start_dt = DateTime.Now,
                   end_dt = DateTime.Now  ,
                   users = new List<user>() { usr }
            };


            IHttpActionResult actResult = projctrl.Postproject(proj);
            var createdResult = actResult as CreatedAtRouteNegotiatedContentResult<project>;

            Debug.WriteLine(actResult);

            projctrl.Dispose();

            Assert.AreEqual("DefaultApi", createdResult.RouteName);
        }

        [TestCase, Order(4)]
        public void EditProjectTestMethod()
        {
            var projCtrl = new ProjectsController();


            var proj = projCtrl.Getprojects().
                          //Where(p => p.users == null || p.users.Count == 0).
                          First();



            proj.project1 = "Project XYZ";
               


            IHttpActionResult actResult = projCtrl.Putproject(proj.project_id, proj);
            var createdResult = actResult as StatusCodeResult;

            Debug.WriteLine(actResult);

            Assert.AreEqual(HttpStatusCode.NoContent, createdResult.StatusCode);
        }


        [TestCase, Order(5)]
        public void GetProjectTestMethod()
        {
            var projCtrl = new ProjectsController();



            var projid = projCtrl.Getprojects().
                          //Where(p => p.users == null || p.users.Count == 0).
                          First();





            IHttpActionResult actResult = projCtrl.Getproject(projid.project_id);
            var createdResult = actResult as OkNegotiatedContentResult<project>;

            Debug.WriteLine(actResult);

            Assert.AreEqual(projid.project_id, createdResult.Content.project_id);
        }


        [TestCase, Order(6)]
        public void GetProjectsTestMethod()
        {
            var projCtrl = new ProjectsController();




            List<project> actResult = projCtrl.Getprojects().ToList();


            Debug.WriteLine(actResult);

            Assert.AreEqual(actResult.Count, actResult.Count);
        }



        [TestCase, Order(7)]
        public void GetProjects2TestMethod()
        {
            var projCtrl = new ProjectsController();




            List<projectvw> actResult = projCtrl.Getprojects2().ToList();


            Debug.WriteLine(actResult);

            Assert.AreEqual(actResult.Count, actResult.Count);
        }



        [TestCase, Order(8)]
        public void DeleteProjectTestMethod()
        {
            var projCtrl = new ProjectsController();

            var projid = TestId;




            var actResult = projCtrl.Deleteproject(projid);

            var createdResult = actResult as OkNegotiatedContentResult<project>;

            Debug.WriteLine(actResult);

            Assert.AreEqual(projid, createdResult.Content.project_id);
            
            
        }



    }
}
