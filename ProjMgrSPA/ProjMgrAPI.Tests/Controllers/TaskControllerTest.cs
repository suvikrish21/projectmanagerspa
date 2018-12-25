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
        [TestCase]
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


        [TestCase]

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


        [TestCase]

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
        }

        [TestCase]

        public void AddTaskTestMethod()
        {
            var taskCtrl = new TasksController();

            var userCtrl = new UsersController();
            var userid = userCtrl.Getusers().ToList().
                      
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

        [TestCase]
        public void EditTaskTestMethod()
        {
            //var taskCtrl = new TasksController();


            var projCtrl = new ProjectsController();
            var pTaskCtrl = new PTasksController();
            var tskCtrl = new TasksController();



            var projid = projCtrl.Getprojects().ToList().
                          Where(p => p.users == null || p.users.Count == 0).
                          Max(p => p.project_id);

            var parentid = pTaskCtrl.Gettasks().ToList().

                         Max(p => p.parent_id);

            var tsk = tskCtrl.Gettasks().ToList().First();

            tsk.task1 = "TASK ABC";
            tsk.start_dt = DateTime.Now;
            tsk.end_dt = DateTime.Now.AddDays(1);
         
            tsk.priority = 5;
            tsk.status = "HOLD";

            tsk.project_id = projid;
            tsk.parent_id = parentid;
               
            


            IHttpActionResult actResult = tskCtrl.Puttask(tsk.task_id, tsk);
            var createdResult = actResult as StatusCodeResult;

            Debug.WriteLine(actResult);

            Assert.AreEqual(HttpStatusCode.NoContent, createdResult.StatusCode);
        }


        [TestCase]
        public void GetTaskTestMethod()
        {
            var tskCtrl = new TasksController();


            int taskid  = tskCtrl.Gettasks().ToList().
                        Where(t => t.users == null || t.users.Count == 0).
                         Max(t => t.task_id);


            IHttpActionResult actResult = tskCtrl.Gettask(taskid);
            var createdResult = actResult as OkNegotiatedContentResult<task>;

            Debug.WriteLine(actResult);

            Assert.AreEqual(taskid, createdResult.Content.task_id);
        }

        [TestCase]
        public void GetTasksTestMethod()
        {
            var taskCtrl = new TasksController();




            List<task> actResult = taskCtrl.Gettasks().ToList();


            Debug.WriteLine(actResult);

            Assert.AreEqual(actResult.Count, actResult.Count);
        }


        [TestCase]
        public void GetParentTasksTestMethod()
        {
            var taskCtrl = new PTasksController();




            List<parent_task> actResult = taskCtrl.Gettasks().ToList();


            Debug.WriteLine(actResult);

            Assert.AreEqual(actResult.Count, actResult.Count);
        }



        [TestCase]
        public void DeleteTaskTestMethod()
        {
            var tskCtrl = new TasksController();

            var tskid = tskCtrl.Gettasks().ToList().
                         Where(t => t.users == null || t.users.Count == 0).
                          Max(t => t.task_id);
         

           
            var actResult = tskCtrl.Deletetask(tskid);

            var createdResult = actResult as OkNegotiatedContentResult<task>;

            Debug.WriteLine(actResult);

            Assert.AreEqual(tskid, createdResult.Content.task_id);


        }



    }
}
