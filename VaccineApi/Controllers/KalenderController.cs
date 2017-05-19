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
    public class KalenderController : ApiController
    {
            private VaccineContext db = new VaccineContext();

            // GET: api/Kalenders
            public IQueryable<Kalender> GetKalender()
            {
                return db.Kalender;
            }

            // GET: api/Kalenders/5
            [ResponseType(typeof(Kalender))]
            public IHttpActionResult GetKalender(int id)
            {
                Kalender kalender = db.Kalender.Find(id);
                if (kalender == null)
                {
                    return NotFound();
                }

                return Ok(kalender);
            }

            // PUT: api/Kalenders/5
            [ResponseType(typeof(void))]
            public IHttpActionResult PutKalender(int id, Kalender kalender)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (id != kalender.Kalender_id)
                {
                    return BadRequest();
                }

                db.Entry(kalender).State = EntityState.Modified;

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KalenderExists(id))
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

            // POST: api/Kalenders
            [ResponseType(typeof(Kalender))]
            public IHttpActionResult PostKalender(Kalender kalender)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                db.Kalender.Add(kalender);
                db.SaveChanges();

                return CreatedAtRoute("DefaultApi", new { id = kalender.Kalender_id }, kalender);
            }

            // DELETE: api/Kalenders/5
            [ResponseType(typeof(Kalender))]
            public IHttpActionResult DeleteKalender(int id)
            {
                Kalender kalender = db.Kalender.Find(id);
                if (kalender == null)
                {
                    return NotFound();
                }

                db.Kalender.Remove(kalender);
                db.SaveChanges();

                return Ok(kalender);
            }

            protected override void Dispose(bool disposing)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                base.Dispose(disposing);
            }

            private bool KalenderExists(int id)
            {
                return db.Kalender.Count(e => e.Kalender_id == id) > 0;
            }
        }
    }