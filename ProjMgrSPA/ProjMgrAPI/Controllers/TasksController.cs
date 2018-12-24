using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ProjMgrAPI.Models;
using System.Web.Http.Cors;

namespace ProjMgrAPI.Controllers
{
    [EnableCors("*", "*", "*")]
    public class TasksController : ApiController
    {
        private ProjectManagerSPAEntities db = new ProjectManagerSPAEntities();

        // GET: api/Tasks
        public IQueryable<task> Gettasks()
        {
            return db.tasks;
        }

        // GET: api/Tasks/5
        [ResponseType(typeof(task))]
        public IHttpActionResult Gettask(int id)
        {
            task task = db.tasks.Find(id);
            if (task == null)
            {
                return NotFound();
            }

            return Ok(task);
        }

        // PUT: api/Tasks/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttask(int id, task task)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != task.task_id)
            {
                return BadRequest();
            }

            MapTaskUser(task);

            db.Entry(task).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!taskExists(id))
                //{
                    return NotFound();
                //}
                //else
                //{
                    throw;
                //}
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Tasks
        [ResponseType(typeof(task))]
        public IHttpActionResult Posttask(task task)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            MapTaskUser(task);

            db.tasks.Add(task);
            db.SaveChanges();

            //postcontroller

            return CreatedAtRoute("DefaultApi", new { id = task.task_id }, task);
        }

        private void MapTaskUser(task task)
        {
            if (task.users != null && task.users.Count > 0)
            {
                var tskusrid = task.users.First().user_id;
                var usr = db.users.First(u => u.user_id == tskusrid);
                usr.task_id = task.task_id;

                task.users.Clear();
                task.users.Add(usr);
            }
        }



        // DELETE: api/Tasks/5
        [ResponseType(typeof(task))]
        public IHttpActionResult Deletetask(int id)
        {
            task task = db.tasks.Find(id);
            if (task == null)
            {
                return NotFound();
            }

            db.tasks.Remove(task);
            db.SaveChanges();

            return Ok(task);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        //private bool taskExists(int id)
        //{
        //    return db.tasks.Count(e => e.task_id == id) > 0;
        //}
    }
}