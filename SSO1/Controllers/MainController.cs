using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSO1.Controllers
{
    [Authorize]
    public class MainController : Controller
    {
        public ActionResult Login()
        {
            return View("Login");
        }

        //public string Index()
        //{
        //    return "Hello World MVC";
        //}
    }
}