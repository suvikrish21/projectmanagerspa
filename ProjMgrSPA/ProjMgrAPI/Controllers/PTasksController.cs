using ProjMgrAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace ProjMgrAPI.Controllers
{
    [EnableCors("*", "*", "*")]
    public class PTasksController : ApiController
    {
        private ProjectManagerSPAEntities db = new ProjectManagerSPAEntities();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IQueryable<parent_task> Gettasks()
        {
            return db.parent_task;
        }

        [ResponseType(typeof(parent_task))]
      
        public IHttpActionResult Posttask(parent_task task)
        {


            db.parent_task.Add(task);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = task.parent_id }, task);
        }
    }
}
