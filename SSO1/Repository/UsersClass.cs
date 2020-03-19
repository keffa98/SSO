using SSO1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSO1
{
    public class Users //données en dur qui sont retournées à la vue 
    {
        public List<User> GetUsers()
        {
            return new List<User>
            {
                new User { Name = "Aros" , Password ="test" },
                new User { Name = "Junior" , Password ="test" }

            };
        }
    }
}
