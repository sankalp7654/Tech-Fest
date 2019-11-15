using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechFest.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Student objUser)
        {
            if (ModelState.IsValid)
            {
                using (TechFestDBEntities db = new TechFestDBEntities())
                {
                    
                }
            }
            return View(objUser);
        }
    }
}
