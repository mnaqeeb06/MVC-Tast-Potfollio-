using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Task.Controllers
{
    public class LogInController : Controller
    {
        // GET: LogIn
        public ActionResult loginView()
        {
            return View();
        }
    }
}