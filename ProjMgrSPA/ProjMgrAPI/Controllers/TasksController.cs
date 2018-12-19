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

namespace ProjMgrAPI.Controllers
{
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

            db.Entry(task).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!taskExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
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

            db.tasks.Add(task);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = task.task_id }, task);
        }

        [ResponseType(typeof(parent_task))]
        public IHttpActionResult Posttask(parent_task task)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.parent_task.Add(task);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = task.parent_id }, task);
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

        private bool taskExists(int id)
        {
            return db.tasks.Count(e => e.task_id == id) > 0;
        }
    }
}