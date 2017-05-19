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
    public class VaccineViewsController : ApiController
    {
        private VacViewContext db = new VacViewContext();

        // GET: api/VaccineViews
        public IQueryable<VaccineView> GetVaccineView()
        {
            return db.VaccineView;
        }

        //// GET: api/VaccineViews/5
        //[ResponseType(typeof(VaccineView))]
        //public IHttpActionResult GetVaccineView(int id)
        //{
        //    VaccineView vaccineView = db.VaccineView.Find(id);
        //    if (vaccineView == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(vaccineView);
        //}

        //// PUT: api/VaccineViews/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutVaccineView(int id, VaccineView vaccineView)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != vaccineView.Vac_Id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(vaccineView).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!VaccineViewExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/VaccineViews
        //[ResponseType(typeof(VaccineView))]
        //public IHttpActionResult PostVaccineView(VaccineView vaccineView)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.VaccineView.Add(vaccineView);

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (VaccineViewExists(vaccineView.Vac_Id))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtRoute("DefaultApi", new { id = vaccineView.Vac_Id }, vaccineView);
        //}

        //// DELETE: api/VaccineViews/5
        //[ResponseType(typeof(VaccineView))]
        //public IHttpActionResult DeleteVaccineView(int id)
        //{
        //    VaccineView vaccineView = db.VaccineView.Find(id);
        //    if (vaccineView == null)
        //    {
        //        return NotFound();
        //    }

        //    db.VaccineView.Remove(vaccineView);
        //    db.SaveChanges();

        //    return Ok(vaccineView);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VaccineViewExists(int id)
        {
            return db.VaccineView.Count(e => e.Vac_Id == id) > 0;
        }
    }
}