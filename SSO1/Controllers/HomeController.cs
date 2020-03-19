using SSO1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSO1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index( String name)
        {
            return "Hello " + name;

            //return View("Index");
        }
        public ActionResult LoginPage()
        {
            return View("Index");
        }

        public ActionResult ListUsers()
        {
            Users users = new Users();
            ViewData["Users"] = users.GetUsers();
            return View();      
        }
        public User  PostUser()
        {
            User user = new User { Name = "test", Password = "test"};
            //Debug.WriteLine(user);
            Debug.WriteLine(user.Name);
            Debug.WriteLine(user.Password);
            //Debug.WriteLine(@ViewData[user.Nom]);

            Console.Write("failed");

            return user;

        }
    }
}