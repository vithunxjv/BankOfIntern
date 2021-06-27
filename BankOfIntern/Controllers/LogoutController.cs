using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankOfInternMVC2.Controllers
{
    [OutputCache(NoStore = true, Duration = 0, VaryByParam = "None")]
    public class LogoutController : Controller
    {
        // GET: Logout
        public ActionResult Logout()
        {
            Session["uid"] = null;
            Session.Clear();
            Session.Abandon();
            return View("Logout");
        }
    }
}