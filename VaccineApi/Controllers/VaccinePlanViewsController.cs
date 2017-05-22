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
using VaccineApi.Models;

namespace VaccineApi.Controllers
{
    public class VaccinePlanViewsController : ApiController
    {
        private VacViewContext db = new VacViewContext();

        // GET: api/VaccinePlanViews
        public IQueryable<VaccinePlanView> GetVaccinePlanViews()
        {
            return db.VaccinePlanViews;
        }

        // GET: api/VaccinePlanViews/5
        [ResponseType(typeof(VaccinePlanView))]
        public IHttpActionResult GetVaccinePlanView(DateTime id)
        {
            VaccinePlanView vaccinePlanView = db.VaccinePlanViews.Find(id);
            if (vaccinePlanView == null)
            {
                return NotFound();
            }

            return Ok(vaccinePlanView);
        }

        // PUT: api/VaccinePlanViews/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVaccinePlanView(DateTime id, VaccinePlanView vaccinePlanView)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vaccinePlanView.Dato)
            {
                return BadRequest();
            }

            db.Entry(vaccinePlanView).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VaccinePlanViewExists(id))
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

        // POST: api/VaccinePlanViews
        [ResponseType(typeof(VaccinePlanView))]
        public IHttpActionResult PostVaccinePlanView(VaccinePlanView vaccinePlanView)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.VaccinePlanViews.Add(vaccinePlanView);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (VaccinePlanViewExists(vaccinePlanView.Dato))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = vaccinePlanView.Dato }, vaccinePlanView);
        }

        // DELETE: api/VaccinePlanViews/5
        [ResponseType(typeof(VaccinePlanView))]
        public IHttpActionResult DeleteVaccinePlanView(DateTime id)
        {
            VaccinePlanView vaccinePlanView = db.VaccinePlanViews.Find(id);
            if (vaccinePlanView == null)
            {
                return NotFound();
            }

            db.VaccinePlanViews.Remove(vaccinePlanView);
            db.SaveChanges();

            return Ok(vaccinePlanView);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VaccinePlanViewExists(DateTime id)
        {
            return db.VaccinePlanViews.Count(e => e.Dato == id) > 0;
        }
    }
}