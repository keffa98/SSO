using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace SSO1
{
    public class  UserDbContext: DbContext
    {
        public DbSet<DBUSersLog> UsersLogList { get; set; }
        public DbSet<UsersID> UsersdbList { get; set; }
        private static UserDbContext _userDbContext;

        private UserDbContext()
        {

        }

        public static UserDbContext GetInstance()
        {
            if (_userDbContext == null)
            {
                _userDbContext = new UserDbContext();
            }
            // Dans tous les cas on la retourne
            return _userDbContext;
        }

    }

}