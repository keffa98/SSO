using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace SSO1
{
    public class  DatabaseContext: DbContext
    {
        //public DbSet<ClientContext> Clients { get; set; }
        public DbSet<UsersID> UsersID { get; set; }

        private static DatabaseContext userData;

        //private DatabaseContext()
        //{

        //}

        public static DatabaseContext GetData()
        {
            if (userData != null)
            {
                return userData;

            }
            else // Dans tous les autres cas on la retourne

            {
                return null;
            }
                
         
        }

    }

}