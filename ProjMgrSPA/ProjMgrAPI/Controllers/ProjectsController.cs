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

        // GET: api/Projects/5
        [ResponseType(typeof(project))]
        public IHttpActionResult Getproject(int id)
        {
            project project = db.projects.Find(id);
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
}