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
using VaccineApi;

namespace VaccineApi.Controllers
{
    public class HistorikController : ApiController
    {
        private VaccineContext db = new VaccineContext();

        // GET: api/Historik
        public IQueryable<Historik> GetHistorik()
        {
            return db.Historik;
        }

        // GET: api/Historik/5
        [ResponseType(typeof(Historik))]
        public IHttpActionResult GetHistorik(DateTime id)
        {
            Historik historik = db.Historik.Find(id);
            if (historik == null)
            {
                return NotFound();
            }

            return Ok(historik);
        }

        // PUT: api/Historik/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHistorik(DateTime id, Historik historik)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != historik.Dato_Vaccineret)
            {
                return BadRequest();
            }

            db.Entry(historik).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HistorikExists(id))
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

        // POST: api/Historik
        [ResponseType(typeof(Historik))]
        public IHttpActionResult PostHistorik(Historik historik)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Historik.Add(historik);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (HistorikExists(historik.Dato_Vaccineret))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = historik.Dato_Vaccineret }, historik);
        }

        // DELETE: api/Historik/5
        [ResponseType(typeof(Historik))]
        public IHttpActionResult DeleteHistorik(DateTime id)
        {
            Historik historik = db.Historik.Find(id);
            if (historik == null)
            {
                return NotFound();
            }

            db.Historik.Remove(historik);
            db.SaveChanges();

            return Ok(historik);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HistorikExists(DateTime id)
        {
            return db.Historik.Count(e => e.Dato_Vaccineret == id) > 0;
        }
    }
}