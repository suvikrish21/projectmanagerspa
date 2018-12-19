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
            var taskCtrl = new TasksController();




            var parenttask = new parent_task { parent_task1 = "Parent Task2" };
             


            IHttpActionResult actResult = taskCtrl.Posttask(parenttask);
            var createdResult = actResult as CreatedAtRouteNegotiatedContentResult<parent_task>;

            Debug.WriteLine(actResult);

            Assert.AreEqual("DefaultApi", createdResult.RouteName);
        }

        [TestCase]

        public void AddTaskTestMethod()
        {
            var taskCtrl = new TasksController();




            var tsk = new task ()
            {
                task1 = "TASK A",
                 start_dt = DateTime.Now,
                  end_dt = DateTime.Now.AddDays(1),
                   parent_id = 1,
                    project_id =1,
                     priority = 5,
                      status ="NEW"
            };



            IHttpActionResult actResult = taskCtrl.Posttask(tsk);
            var createdResult = actResult as CreatedAtRouteNegotiatedContentResult<task>;

            Debug.WriteLine(actResult);

            Assert.AreEqual("DefaultApi", createdResult.RouteName);
        }

        [TestCase]
        public void EditTaskTestMethod()
        {
            var taskCtrl = new TasksController();


            var tsk = new task()
            {
                task1 = "TASK ABC",
                start_dt = DateTime.Now,
                end_dt = DateTime.Now.AddDays(1),
                parent_id = 1,
                project_id = 1,
                priority = 5,
                status = "HOLD",
                task_id = 1
            };


            IHttpActionResult actResult = taskCtrl.Puttask(tsk.task_id, tsk);
            var createdResult = actResult as StatusCodeResult;

            Debug.WriteLine(actResult);

            Assert.AreEqual(HttpStatusCode.NoContent, createdResult.StatusCode);
        }


        [TestCase]
        public void GetTaskTestMethod()
        {
            var tskCtrl = new TasksController();


            int taskid = 1;


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



    }
}
