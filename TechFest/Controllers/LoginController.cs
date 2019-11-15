using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechFest.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
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
                    var obj = db.Students.Where(a => a.usn.Equals(objUser.usn) && a.pswd.Equals(objUser.pswd)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["USN"] = obj.usn.ToString();
                        Session["Name"] = obj.name.ToString();
                        return RedirectToAction("Index", "Events");
                    }
                }
            }
            return View(objUser);
        }
    }
}
