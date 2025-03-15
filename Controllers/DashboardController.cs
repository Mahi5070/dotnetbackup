using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TruYum_APP.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            try
            {
                if (Session.Count == 0)
                {
                    return RedirectToAction("Login", "Accounts");
                }
            }
            catch
            {

            }
            return View();
        }
    }
}