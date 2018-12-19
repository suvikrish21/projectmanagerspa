﻿using System;
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
        [TestCase]
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
        }

        [TestCase]
        public void AddProjectTestMethod2()
        {
            var projctrl = new ProjectsController();


            var proj = new project()
            {
                project1 = "Project ABC",
                 priority = 3,
                  start_dt = DateTime.Now,
                   end_dt = DateTime.Now  ,
                     
            };


            IHttpActionResult actResult = projctrl.Postproject(proj);
            var createdResult = actResult as CreatedAtRouteNegotiatedContentResult<project>;

            Debug.WriteLine(actResult);

            Assert.AreEqual("DefaultApi", createdResult.RouteName);
        }

        [TestCase]
        public void EditProjectTestMethod()
        {
            var projCtrl = new ProjectsController();


            var proj = new project()
            {
                project1 ="Project XYZ",
                 project_id = 2
                  
            };


            IHttpActionResult actResult = projCtrl.Putproject(proj.project_id, proj);
            var createdResult = actResult as StatusCodeResult;

            Debug.WriteLine(actResult);

            Assert.AreEqual(HttpStatusCode.NoContent, createdResult.StatusCode);
        }


        [TestCase]
        public void GetProjectTestMethod()
        {
            var projCtrl = new ProjectsController();


            int projid = 2;


            IHttpActionResult actResult = projCtrl.Getproject(projid);
            var createdResult = actResult as OkNegotiatedContentResult<project>;

            Debug.WriteLine(actResult);

            Assert.AreEqual(projid, createdResult.Content.project_id);
        }


        [TestCase]
        public void GetProjectsTestMethod()
        {
            var projCtrl = new ProjectsController();




            List<project> actResult = projCtrl.Getprojects().ToList();


            Debug.WriteLine(actResult);

            Assert.AreEqual(actResult.Count, actResult.Count);
        }



    }
}