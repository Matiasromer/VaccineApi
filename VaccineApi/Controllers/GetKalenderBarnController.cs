
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace VaccineApi.Controllers
{
    public class GetKalenderBarnController : ApiController
    {
        private VaccineContext db = new VaccineContext();

        public IQueryable<Kalender> GetKalender()
        {
            return db.Kalender;
        }
        
        [Route("api/GetKalenderBarn/{barn}")]
        [HttpGet]
        // Har lavet en funktion der henter antal fra barn_id i kalender.
        // GET: api/GetKalenderBarn/5
        public IHttpActionResult GetKalenderBarn(int barn)
        {
            int sumvac = db.Kalender.Count(x => x.Barn_id == barn);


            if (sumvac == 0)
            {
                return NotFound();
            }

            return Ok(sumvac);
        }
    }
}
