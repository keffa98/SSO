using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSO1.Controllers
{
    public class MainController : Controller
    {
        public ActionResult getUser()
        {
            return View("Login");
        }

        public string postUser()
        {
            return "postUser";
           
        }



        //public string Index()
        //{
        //    return "Hello World MVC";
        //}
    }
}