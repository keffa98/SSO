using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace SSO1
{
    //Cette classe représente le contexte en relation avec les données 
    //de la base de données de l'utilisateur et la liste des sites en lien avec le SSO
    public class ClientContext : DbContext
    {
        //public string IdBdd { get; set; }
        //public string PwdBdd { get; set; }
        public List <string> SitesAccess { get; set; } 
    }
}
