using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechFest.Controllers
{
    public class VolunteerController : Controller
    {
        TechFestDBEntities db = new TechFestDBEntities();
        // GET: Volunteer
        public ActionResult Index(int? id)
        {

            return View(db.Volunteers.Where(u => u.e_id == id).ToList());
        }
    }
}