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

        //public string CheckToken()
        //{
        //    throw new NotImplementedException();
        //     // return Token = Convert.ToBase64String(Guid.NewGuid().ToByteArray()); 


        //}

        //public Client GetClient()
        //{

        //    Client client = new Client { ClientId = "Google", ClientName = "google", ClientUri = "http://www.google.com" };
        //    return client;
        //}

       public Client FindClient(string name)
        {

            //    Client Context db = DatabaseContext.GetData();
            //    List<Client> clientsList = (from p in db.UsersID select p).ToList();
            //    foreach (Client site in clientsList)
            Client client = null;


            List<Client> clientsList = new List<Client>{
             new Client { ClientId = "Google", ClientName = "google", ClientUri = "http://www.google.com" },
             new Client { ClientId = "Facebook", ClientName = "facebook", ClientUri = "http://www.facebook.com" }, };

            foreach(Client site in clientsList)
            {
                if (site.ClientName == name)
                {
                    return site;
                }
                client = site;
            }

            return client;

            // return bdd.Client.FirstOrDefault(client => Client.ClientName == name);

        }




        //public string CreateToken()
        //{
        //   return valueToken = Convert.ToBase64String(Guid.NewGuid().ToByteArray()); ;
        //}


        //public static void StoreInCookie( string cookieName, string keyName, DateTime? expirationDate,  bool httpOnly = false)
        //{

        //    foreach (string domain in DbContext.SitesAccess)
        //    {
        //        HttpCookie cookie = HttpContext.Current.Response.Cookies[cookieName]
        //            ?? HttpContext.Current.Request.Cookies[cookieName];
        //        if (cookie == null) cookie = new HttpCookie(cookieName);
        //        if (!String.IsNullOrEmpty(keyName)) cookie.Values.Set(keyName, TokensClass.valueToken);
        //        else cookie.Value = TokensClass.valueToken;
        //        if (expirationDate.HasValue) cookie.Expires = expirationDate.Value;
        //        if (!String.IsNullOrEmpty(cookieDomain)) cookie.Domain = domain;
        //        if (httpOnly) cookie.HttpOnly = true;
        //        HttpContext.Current.Response.Cookies.Set(cookie);
        //    }
        //}

        //public static bool CookieExist(string cookieName, string keyName)
        //{
        //    HttpCookieCollection cookies = HttpContext.Current.Request.Cookies;
        //    return (String.IsNullOrEmpty(keyName))
        //        ? cookies[cookieName] != null
        //        : cookies[cookieName] != null && cookies[cookieName][keyName] != null;
        //}


        //public static void RemoveCookie(string cookieName, string keyName, string domain = null)
        //{
        //    if (String.IsNullOrEmpty(keyName))
        //    {
        //        if (HttpContext.Current.Request.Cookies[cookieName] != null)
        //        {
        //            HttpCookie cookie = HttpContext.Current.Request.Cookies[cookieName];
        //            cookie.Expires = DateTime.UtcNow.AddYears(-1);
        //            if (!String.IsNullOrEmpty(domain)) cookie.Domain = domain;
        //            HttpContext.Current.Response.Cookies.Add(cookie);
        //            HttpContext.Current.Request.Cookies.Remove(cookieName);
        //        }
        //    }
        //    else
        //    {
        //        HttpCookie cookie = HttpContext.Current.Request.Cookies[cookieName];
        //        cookie.Values.Remove(keyName);
        //        if (!String.IsNullOrEmpty(domain)) cookie.Domain = domain;
        //        HttpContext.Current.Response.Cookies.Add(cookie);
        //    }
        //}

        public void Dispose()
        {
            bdd.Dispose();
        }

    }
}