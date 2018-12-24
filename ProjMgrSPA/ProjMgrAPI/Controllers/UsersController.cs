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
using ProjMgrAPI.App_Start;
using System.Web.Http.Cors;

namespace ProjMgrAPI.Controllers
{
    [EnableCors("*","*","*")]
    public class UsersController : ApiController
    {
        private ProjectManagerSPAEntities db = new ProjectManagerSPAEntities();

        // GET: api/Users
        public IQueryable<user> Getusers()
        {
            return db.users;
        }

        [Route("api/users/summary")]
        public IQueryable<uservw> Getusers2()
        {
            return db.users.Select(u=> new uservw()
            {
                 emp_id  = u.emp_id,
                  first_name = u.first_name,
                  last_name = u.last_name,
                   project_id = u.project_id,
                   task_id = u.task_id,
                  user_id = u.user_id

            });
        }

        // GET: api/Users/5
        [ResponseType(typeof(user))]
        public IHttpActionResult Getuser(int id)
        {
          
            user user = db.users.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // PUT: api/Users/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putuser(int id, user user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != user.user_id)
            {
                return BadRequest();
            }

            db.Entry(user).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!userExists(id))
                //{
                //    return NotFound();
                //}
                //else
                ///{
                    throw;
                //}
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Users
        [ResponseType(typeof(user))]
        public IHttpActionResult Postuser(user user)
        {
           

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            int usersequence =  db.users.Count() == 0 ? 1 :db.users.Max(t => t.user_id);
            user.user_id = usersequence + 1;

            db.users.Add(user);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = user.user_id }, user);
        }

        // DELETE: api/Users/5
        [ResponseType(typeof(user))]
        public IHttpActionResult Deleteuser(int id)
        {
            user user = db.users.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            db.users.Remove(user);
            db.SaveChanges();

            return Ok(user);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        //private bool userExists(int id)
        //{
           // return db.users.Count(e => e.user_id == id) > 0;
        //}
    }


    public class uservw
    {
        public int user_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public Nullable<int> emp_id { get; set; }
        public Nullable<int> project_id { get; set; }
        public Nullable<int> task_id { get; set; }
    }
}