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
using ATPapp.Data;
using ATPapp.Models;

namespace ATPapp.Controllers
{
    public class AgentisController : ApiController
    {
        private ATPappContext db = new ATPappContext();

        //[Authorize]
        // GET: api/Agentis
        public IQueryable<Agenti> GetAgentis()
        {
            return db.Agentis;
        }

        //[Authorize(Roles ="SuperAdmin")]
        // GET: api/Agentis/5
        [ResponseType(typeof(Agenti))]
        public IHttpActionResult GetAgenti(int id)
        {
            Agenti agenti = db.Agentis.Find(id);
            if (agenti == null)
            {
                return NotFound();
            }

            return Ok(agenti);
        }

        //[Authorize]
        // PUT: api/Agentis/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAgenti(int id, Agenti agenti)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != agenti.AgentiId)
            {
                return BadRequest();
            }

            db.Entry(agenti).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgentiExists(id))
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

        //[Authorize]
        // POST: api/Agentis
        [ResponseType(typeof(Agenti))]
        public IHttpActionResult PostAgenti(Agenti agenti)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Agentis.Add(agenti);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = agenti.AgentiId }, agenti);
        }

        //[Authorize]
        // DELETE: api/Agentis/5
        [ResponseType(typeof(Agenti))]
        public IHttpActionResult DeleteAgenti(int id)
        {
            Agenti agenti = db.Agentis.Find(id);
            if (agenti == null)
            {
                return NotFound();
            }

            var master = db.Set<Agenti>().Include(m => m.Clienti)
                        .SingleOrDefault(m => m.AgentiId == id);
            db.Set<Agenti>().Remove(agenti);
            db.SaveChanges();

            return Ok(agenti);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AgentiExists(int id)
        {
            return db.Agentis.Count(e => e.AgentiId == id) > 0;
        }
    }
}