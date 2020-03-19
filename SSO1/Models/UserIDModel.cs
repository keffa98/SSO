using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SSO1
{
    //[Table("Users")]
    public class UsersID 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Password { get; set; }
        public string Token { get; set; }

        //public void PrintUser()
        //{
        //    DatabaseContext db = DatabaseContext.GetData();
        //    List<UsersID> liste1 = (from p in db.UsersID select p).ToList();

        //    foreach (UsersID mamzil in liste1)
        //    {
        //        Console.WriteLine(mamzil.Nom + ") " + mamzil.Password + " - " + mamzil.Token);
        //    }
        //}

        //public bool CheckuSerExist(string User, string mdp)
        //{
        //    DatabaseContext db = DatabaseContext.GetData();
        //    List<UsersID> liste1 = (from p in db.UsersID select p).ToList();
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
        //            i= false;
        //        }
        //    }
        //    return i;
        //}

        //public void AddUser(string user, string mdp)
        //{
        //    DatabaseContext db = DatabaseContext.GetData();

        //    db.UsersID.Add(new  UsersID()
        //    {
        //        Nom = user,
        //        Password = mdp
        //    });
        //    db.SaveChanges();
        //}

        //public string CreateToken()
        //{
        //    return Token = Convert.ToBase64String(Guid.NewGuid().ToByteArray()); ;
        //}

    }
}