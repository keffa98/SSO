using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace SSO1
{
    public class UsersID : DbContext
    {
        public string Nom { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }

        public void PrintUser()
        {
            UserDbContext db = UserDbContext.GetInstance();
            List<UsersID> liste1 = (from p in db.UsersdbList select p).ToList();

            foreach (UsersID mamzil in liste1)
            {
                Console.WriteLine(mamzil.Nom + ") " + mamzil.Password + " - " + mamzil.Token);
            }
        }

        public bool CheckuSerExist(string User, string mdp)
        {
            UserDbContext db = UserDbContext.GetInstance();
            List<UsersID> liste1 = (from p in db.UsersdbList select p).ToList();
            bool i = true;
            foreach (UsersID mamzil in liste1)
            {
                if (mamzil.Nom == User)
                {
                    if (mamzil.Password == mdp)
                    {
                        i = true;
                    }
                    else
                    {
                        i = false;
                    }
                }
                else
                {
                    i= false;
                }
            }
            return i;
        }

        public void AddUser(string user, string mdp)
        {
            UserDbContext db = UserDbContext.GetInstance();

            db.UsersdbList.Add(new  UsersID()
            {
                Nom = user,
                Password = mdp
            });
            db.SaveChanges();
        }

    }
}