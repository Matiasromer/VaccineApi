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
    public class Vaccine_TableController : ApiController
    {
        private VaccineContext db = new VaccineContext();

        // GET: api/Vaccine_Table
        public IQueryable<Vaccine_Table> GetVaccine_Table()
        {
            return db.Vaccine_Table;
        }

        // GET: api/Vaccine_Table/5
        [ResponseType(typeof(Vaccine_Table))]
        public IHttpActionResult GetVaccine_Table(int id)
        {
            Vaccine_Table vaccine_Table = db.Vaccine_Table.Find(id);
            if (vaccine_Table == null)
            {
                return NotFound();
            }

            return Ok(vaccine_Table);
        }

        // PUT: api/Vaccine_Table/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVaccine_Table(int id, Vaccine_Table vaccine_Table)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vaccine_Table.Vaccine_nr)
            {
                return BadRequest();
            }

            db.Entry(vaccine_Table).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Vaccine_TableExists(id))
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

        // POST: api/Vaccine_Table
        [ResponseType(typeof(Vaccine_Table))]
        public IHttpActionResult PostVaccine_Table(Vaccine_Table vaccine_Table)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Vaccine_Table.Add(vaccine_Table);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (Vaccine_TableExists(vaccine_Table.Vaccine_nr))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = vaccine_Table.Vaccine_nr }, vaccine_Table);
        }

        // DELETE: api/Vaccine_Table/5
        [ResponseType(typeof(Vaccine_Table))]
        public IHttpActionResult DeleteVaccine_Table(int id)
        {
            Vaccine_Table vaccine_Table = db.Vaccine_Table.Find(id);
            if (vaccine_Table == null)
            {
                return NotFound();
            }

            db.Vaccine_Table.Remove(vaccine_Table);
            db.SaveChanges();

            return Ok(vaccine_Table);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Vaccine_TableExists(int id)
        {
            return db.Vaccine_Table.Count(e => e.Vaccine_nr == id) > 0;
        }
    }
}