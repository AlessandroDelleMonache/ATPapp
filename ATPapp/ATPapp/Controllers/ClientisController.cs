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
    public class ClientisController : ApiController
    {
        private ATPappContext db = new ATPappContext();

        // GET: api/Clientis
        public IQueryable<Clienti> GetClientis()
        {
            return db.Clientis;
        }

        // GET: api/Clientis/5
        [ResponseType(typeof(Clienti))]
        public IHttpActionResult GetClienti(string id)
        {
            Clienti clienti = db.Clientis.Find(id);
            if (clienti == null)
            {
                return NotFound();
            }

            return Ok(clienti);
        }

        // PUT: api/Clientis/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutClienti(string id, Clienti clienti)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != clienti.ClientiId)
            {
                return BadRequest();
            }

            db.Entry(clienti).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientiExists(id))
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

        // POST: api/Clientis
        [ResponseType(typeof(Clienti))]
        public IHttpActionResult PostClienti(Clienti clienti)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Clientis.Add(clienti);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ClientiExists(clienti.ClientiId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = clienti.ClientiId }, clienti);
        }

        // DELETE: api/Clientis/5
        [ResponseType(typeof(Clienti))]
        public IHttpActionResult DeleteClienti(string id)
        {
            Clienti clienti = db.Clientis.Find(id);
            if (clienti == null)
            {
                return NotFound();
            }

            db.Clientis.Remove(clienti);
            db.SaveChanges();

            return Ok(clienti);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClientiExists(string id)
        {
            return db.Clientis.Count(e => e.ClientiId == id) > 0;
        }
    }
}