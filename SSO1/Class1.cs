using SSO1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSO1
{
    public class Users
    {
        public List<User> GetUsers()
        {
            return new List<User>
            {
                new User { Nom = "Aros" , Password ="test" }
            };
        }
    }
}
