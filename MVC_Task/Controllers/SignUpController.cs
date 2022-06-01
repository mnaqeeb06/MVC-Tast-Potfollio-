using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Task.Controllers
{
    public class SignUpController : Controller
    {
        // GET: SignUp
        public ActionResult signupView()
        {
            return View();
        }
    }
}