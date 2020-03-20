using SSO1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace SSO1.Repository
{
    public class UsersRepository : UserInterface
    {
        private DatabaseContext bdd;

        public UsersRepository()
        {
            bdd = new DatabaseContext();
        }

        //public List<User> GetUsers()
        //{
        //    return new List<User>
        //    {
        //        new User { Name = "Aros" , Password ="test" },
        //        new User { Name = "Junior" , Password ="test" }

        //    };
        //    //throw new NotImplementedException();
        //}

        private string EncodePassword(string Password)
        {
            string PasswordCrypted = "enablecode" + Password;
            return BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(ASCIIEncoding.Default.GetBytes(PasswordCrypted)));
        }

        public void CreateUserId(string Nom, string Password) //string Token)
        {
            bdd.UsersID.Add(new UsersID()
            {
                Nom = Nom,
                Password = EncodePassword(Password),
                //Token = Convert.ToBase64String(Guid.NewGuid().ToByteArray())
            });
            bdd.SaveChanges();

        }
        //public List<UsersID> UsersIDList { get; private set; }
        public List<UsersID> GetAllUsersIDs()
        {
            //UsersIDList = bdd.UsersID.ToList();
           // List<UsersID> UsersIDList = (from p in bdd.UsersID select p).ToList();
            //foreach (UsersID userid in UsersIDList) { Console.WriteLine(userid.Nom + ") " + userid.Password + " - " + userid.Token); }


            // return UsersIDList;

            return new List<UsersID>
            {
                new UsersID { Nom = "Aros" , Password ="test" },
                new UsersID { Nom = "Junior" , Password ="test" }
               };

        }

        public UsersID FindUserByID(int id)
        {
            UsersID userid = bdd.UsersID.FirstOrDefault(user => user.Id == id);
            return userid;
        }

        public UsersID FindUserByName(string Name)
        {
//            UsersID userName = bdd.UsersID.FirstOrDefault(user => user.Nom == Name);
            return new UsersID { Nom = "Aros"};
        }

        public void DeleteUserByID(int id)
        {
            UsersID userid = bdd.UsersID.FirstOrDefault(user => user.Id == id);

            //bdd.Delete

        }

        public void UpdateUserID(int id, string nom, string password)
        {
            UsersID userid = bdd.UsersID.FirstOrDefault(user => user.Id == id);
            if (userid != null)
            {
                userid.Nom = nom;
                userid.Password = EncodePassword(password);
                bdd.SaveChanges();
            }

            //Debug.Writeline(userid.name "was updated")
        }


        public bool Auth(string nom, string Password)
        {
            //string PasswordCrypted = EncodePassword(Password);
            //List<UsersID> userlist =  new List<UsersID>{
            //    new UsersID { Nom = "Aros" , Password ="test" },
            //    new UsersID { Nom = "Junior" , Password ="test" }
            //   };

            bool userExist;

            UsersID user = new UsersID { Nom = "Aros", Password = "test" };
//            foreach (UsersID user in userlist)
  //          {
                if (user.Nom == nom)
                {
                    if (user.Password == Password)
                    {
                        userExist = true;
                    } else
                    {
                        userExist = false;
                    }
                } else
                {
                    userExist = false;
                }
    //        }



            return userExist;

           // return bdd.UsersID.FirstOrDefault(user => user.Nom == nom && user.Password == PasswordCrypted);
        }

        public string CheckToken()
        {
<<<<<<< HEAD
           // return Token = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            throw new NotImplementedException();
=======
              return Token = Convert.ToBase64String(Guid.NewGuid().ToByteArray()); 

           // throw new NotImplementedException();
>>>>>>> a396992d6968fa9f91fcd45021104e18a0efed21

        }



        //public bool CheckuSerExist(string User, string mdp)
        //{
        //    DatabaseContext db = DatabaseContext.GetData();
        //    List<UsersID> liste1 = (from p in db.Users select p).ToList();
        //    bool i = true;
        //    foreach (UsersID mamzil in liste1)
        //    {
        //        if (mamzil.Nom == User)
        //        {
        //            if (mamzil.Password == mdp)
        //            {
        //                i = true;
        //            }
        //            else
        //            {
        //                i = false;
        //            }
        //        }
        //        else
        //        {
        //            i = false;
        //        }
        //    }
        //    return i;
        //}


        public string CreateToken()
        {
           return valueToken = Convert.ToBase64String(Guid.NewGuid().ToByteArray()); ;
        }

        public void Dispose()
        {
            bdd.Dispose();
        }

        public static void StoreInCookie( string cookieName, string keyName, DateTime? expirationDate,  bool httpOnly = false)
        {

            foreach (string domain in DbContext.SitesAccess)
            {
                HttpCookie cookie = HttpContext.Current.Response.Cookies[cookieName]
                    ?? HttpContext.Current.Request.Cookies[cookieName];
                if (cookie == null) cookie = new HttpCookie(cookieName);
                if (!String.IsNullOrEmpty(keyName)) cookie.Values.Set(keyName, TokensClass.valueToken);
                else cookie.Value = TokensClass.valueToken;
                if (expirationDate.HasValue) cookie.Expires = expirationDate.Value;
                if (!String.IsNullOrEmpty(cookieDomain)) cookie.Domain = domain;
                if (httpOnly) cookie.HttpOnly = true;
                HttpContext.Current.Response.Cookies.Set(cookie);
            }
        }

        public static bool CookieExist(string cookieName, string keyName)
        {
            HttpCookieCollection cookies = HttpContext.Current.Request.Cookies;
            return (String.IsNullOrEmpty(keyName))
                ? cookies[cookieName] != null
                : cookies[cookieName] != null && cookies[cookieName][keyName] != null;
        }


        public static void RemoveCookie(string cookieName, string keyName, string domain = null)
        {
            if (String.IsNullOrEmpty(keyName))
            {
                if (HttpContext.Current.Request.Cookies[cookieName] != null)
                {
                    HttpCookie cookie = HttpContext.Current.Request.Cookies[cookieName];
                    cookie.Expires = DateTime.UtcNow.AddYears(-1);
                    if (!String.IsNullOrEmpty(domain)) cookie.Domain = domain;
                    HttpContext.Current.Response.Cookies.Add(cookie);
                    HttpContext.Current.Request.Cookies.Remove(cookieName);
                }
            }
            else
            {
                HttpCookie cookie = HttpContext.Current.Request.Cookies[cookieName];
                cookie.Values.Remove(keyName);
                if (!String.IsNullOrEmpty(domain)) cookie.Domain = domain;
                HttpContext.Current.Response.Cookies.Add(cookie);
            }
        }



    }
}