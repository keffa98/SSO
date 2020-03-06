using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace SSO1
{
    public class DBUSersLog : DbContext
    {
        public string IdBdd { get; set; }
        public string PwdBdd { get; set; }
        public List <string> SitesAccess { get; set; } 
    }
}