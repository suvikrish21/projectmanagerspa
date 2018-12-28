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
    public class TaskControllerTest
    {
        private int TestId { get; set; }

        [TestCase, Order(1)]
        public void AddParentTaskTestMethod()
        {
            var taskCtrl = new PTasksController();




            var parenttask = new parent_task { parent_task1 = "Parent Task2" };
             


            IHttpActionResult actResult = taskCtrl.Posttask(parenttask);
            var createdResult = actResult as CreatedAtRouteNegotiatedContentResult<parent_task>;

            Debug.WriteLine(actResult);
            taskCtrl.Dispose();

            Assert.AreEqual("DefaultApi", createdResult.RouteName);
        }


        [TestCase, Order(2)]

        public void AddTaskTestMethod2()
        {
            var taskCtrl = new TasksController();

            var projCtrl = new ProjectsController();
            var pTaskCtrl = new PTasksController();



            var projid =   projCtrl.Getprojects().ToList().
                          Where(p => p.users == null || p.users.Count == 0).
                          Max(p => p.project_id);

            var parentid = pTaskCtrl.Gettasks().ToList().
                       
                         Max(p => p.parent_id);


            var tsk = new task()
            {
                task1 = "TASK Z",
                start_dt = DateTime.Now,
                end_dt = DateTime.Now.AddDays(1),
                parent_id = parentid,
                project_id = projid,
                priority = 5,
                status = "NEW",
              

            };



            IHttpActionResult actResult = taskCtrl.Posttask(tsk);
            var createdResult = actResult as CreatedAtRouteNegotiatedContentResult<task>;

            Debug.WriteLine(actResult);
            taskCtrl.Dispose();

            Assert.AreEqual("DefaultApi", createdResult.RouteName);
        }


        [TestCase, Order(3)]

        public void AddTaskTestMethod1()
        {
            var taskCtrl = new TasksController();

         

          
            var tsk = new task()
            {
                task1 = "TASK GH",
                start_dt = DateTime.Now,
                end_dt = DateTime.Now.AddDays(1),
                priority = 15,
                status = "NEW",


            };



            IHttpActionResult actResult = taskCtrl.Posttask(tsk);
            var createdResult = actResult as CreatedAtRouteNegotiatedContentResult<task>;

            Debug.WriteLine(actResult);
            taskCtrl.Dispose();

            Assert.AreEqual("DefaultApi", createdResult.RouteName);

            TestId = tsk.task_id;
        }

        [TestCase, Order(4)]

        public void AddTaskTestMethod()
        {
            var taskCtrl = new TasksController();

            var userCtrl = new UsersController();
            var userid = userCtrl.Getusers().
                      
                      Max(u => u.user_id);


            var usr = new user { user_id = userid };

            var projCtrl = new ProjectsController();
            var pTaskCtrl = new PTasksController();



            var projid = projCtrl.Getprojects().ToList().
                          Where(p => p.users == null || p.users.Count == 0).
                          Max(p => p.project_id);

            var parentid = pTaskCtrl.Gettasks().ToList().

                         Max(p => p.parent_id);


            var tsk = new task ()
            {
                task1 = "TASK A",
                 start_dt = DateTime.Now,
                  end_dt = DateTime.Now.AddDays(1),
                   parent_id = parentid,
                    project_id = projid,
                     priority = 5,
                      status ="NEW",
                users = new List<user>() { usr }

            };



            IHttpActionResult actResult = taskCtrl.Posttask(tsk);
            var createdResult = actResult as CreatedAtRouteNegotiatedContentResult<task>;

            Debug.WriteLine(actResult);
            taskCtrl.Dispose();

            Assert.AreEqual("DefaultApi", createdResult.RouteName);
        }

        [TestCase, Order(5)]
        public void EditTaskTestMethod()
        {
            //var taskCtrl = new TasksController();


            var projCtrl = new ProjectsController();
            var pTaskCtrl = new PTasksController();
            var tskCtrl = new TasksController();



            var projid = projCtrl.Getprojects().ToList().
                          First(p => p.users == null || p.users.Count == 0);
                         

            var parentid = pTaskCtrl.Gettasks().

                         Max(p => p.parent_id);

            var tsk = tskCtrl.Gettasks().First();

            tsk.task1 = "TASK ABC";
            tsk.start_dt = DateTime.Now;
            tsk.end_dt = DateTime.Now.AddDays(1);
         
            tsk.priority = 5;
            tsk.status = "HOLD";

            tsk.project_id = projid.project_id;
            tsk.parent_id = parentid;
               
            


            IHttpActionResult actResult = tskCtrl.Puttask(tsk.task_id, tsk);
            var createdResult = actResult as StatusCodeResult;

            Debug.WriteLine(actResult);

            Assert.AreEqual(HttpStatusCode.NoContent, createdResult.StatusCode);
        }


        [TestCase, Order(6)]
        public void GetTaskTestMethod()
        {
            var tskCtrl = new TasksController();


            var tsk = tskCtrl.Gettasks().First();


            IHttpActionResult actResult = tskCtrl.Gettask(tsk.task_id);
            var createdResult = actResult as OkNegotiatedContentResult<task>;

            Debug.WriteLine(actResult);

            Assert.AreEqual(tsk.task_id, createdResult.Content.task_id);
        }

        [TestCase, Order(10)]
        public void GetTasksTestMethod()
        {
            var taskCtrl = new TasksController();
            var projCtrl = new ProjectsController();


            var projid = projCtrl.Getprojects().ToList().
                       First(p => p.users == null || p.users.Count == 0);

            



            List<task> actResult = taskCtrl.Gettasks(projid.project_id).ToList();


            Debug.WriteLine(actResult);

            Assert.AreEqual(actResult.Count, actResult.Count);
        }


        [TestCase, Order(9)]
        public void GetTasksTestMethod2()
        {
            var taskCtrl = new TasksController();




            List<task> actResult = taskCtrl.Gettasks().ToList();


            Debug.WriteLine(actResult);

            Assert.AreEqual(actResult.Count, actResult.Count);
        }


        [TestCase, Order(7)]
        public void GetParentTasksTestMethod()
        {
            var taskCtrl = new PTasksController();




            List<parent_task> actResult = taskCtrl.Gettasks().ToList();


            Debug.WriteLine(actResult);

            Assert.AreEqual(actResult.Count, actResult.Count);
        }



        [TestCase, Order(8)]
        public void DeleteTaskTestMethod()
        {
            var tskCtrl = new TasksController();

            var tskid = TestId;
         

           
            var actResult = tskCtrl.Deletetask(tskid);

            var createdResult = actResult as OkNegotiatedContentResult<task>;

            Debug.WriteLine(actResult);

            Assert.AreEqual(tskid, createdResult.Content.task_id);


        }



    }
}
