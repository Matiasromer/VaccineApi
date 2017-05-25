using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;
using VaccineApi.Models;

namespace VaccineApi.Controllers
{
    public class VaccinePlanView2Controller : ApiController
    {
        private VacViewContext db = new VacViewContext();
        public IQueryable<VaccinePlanView> GetVaccinePlanViews(int id)
        {
            return db.VaccinePlanViews.Where(x => x.Barn_id == id);
        }
    }
}
