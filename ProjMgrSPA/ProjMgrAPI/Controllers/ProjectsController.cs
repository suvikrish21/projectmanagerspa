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
    public class ProjectsController : ApiController
    {
        private ProjectManagerSPAEntities db = new ProjectManagerSPAEntities();


        // GET: api/Projects
        public IQueryable<project> Getprojects()
        {
            return db.projects;
        }

        [Route("api/projects/summary")]
        public IQueryable<projectvw> Getprojects2()
        {
            return db.projects.Select(p => new projectvw()
            {
                end_dt = p.end_dt,
                priority = p.priority,
                project1 = p.project1,
                project_id = p.project_id,
                start_dt = p.start_dt,
                total_tasks = p.tasks.Count,
                completed_tasks = p.tasks.Count(t=> t.status == "COMPLETE")
            });
        }

        // GET: api/Projects/5
        [ResponseType(typeof(project))]
        public IHttpActionResult Getproject(int id)
        {
            var project = db.projects.Include("users")
                    .First(p => p.project_id == id);
            
            if (project == null)
            {
                return NotFound();
            }

            return Ok(project);
        }

        // PUT: api/Projects/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putproject(int id, project project)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != project.project_id)
            {
                return BadRequest();
            }

            MapProjectUser(project);

            db.Entry(project).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!projectExists(id))
                //{
                //    return NotFound();
                //}
                //else
                //{
                throw;
                //}
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Projects
        [ResponseType(typeof(project))]
        public IHttpActionResult Postproject(project project)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            MapProjectUser(project);

            db.projects.Add(project);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = project.project_id }, project);
        }

        private void MapProjectUser(project project)
        {
            if (project.users != null && project.users.Count > 0)
            {
                var projusrid = project.users.First().user_id;
                var usr = db.users.First(u => u.user_id == projusrid);
                usr.project_id = project.project_id;

                project.users.Clear();
                project.users.Add(usr);
            }
        }

        // DELETE: api/Projects/5
        [ResponseType(typeof(project))]
        public IHttpActionResult Deleteproject(int id)
        {
            project project = db.projects.Find(id);
            if (project == null)
            {
                return NotFound();
            }

            db.projects.Remove(project);
            db.SaveChanges();

            return Ok(project);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        //private bool projectExists(int id)
        //{
        //    return db.projects.Count(e => e.project_id == id) > 0;
        //}
    }



    public class projectvw
    {
        public int project_id { get; set; }
        public string project1 { get; set; }
        public Nullable<System.DateTime> start_dt { get; set; }
        public Nullable<System.DateTime> end_dt { get; set; }
        public Nullable<int> priority { get; set; }

        public int total_tasks { get; set; }

        public int completed_tasks { get; set; }
    }
}