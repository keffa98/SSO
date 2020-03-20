using SSO1.Models;
using SSO1.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SSO1.Controllers
{
    public class HomeController : Controller
    {

        [AllowAnonymous]
        [ActionName("Index")]
        public ActionResult LoginPage() // Vérifie si l'utilisateur est authentifié
        {
            UserIDViewModels viewModel = new UserIDViewModels { Authentifie = HttpContext.User.Identity.IsAuthenticated };
            using (UserInterface userInterface = new UsersRepository()) {

                if (HttpContext.User.Identity.IsAuthenticated) //Si c'est le cas On récupère le nom de l'utilsateur
                {
                   // Debug.WriteLine("isauth");

                    viewModel.userViewModel = userInterface.FindUserByName(HttpContext.User.Identity.Name); 
                } 
                return View(viewModel);
            }

            //return View("Index");
        }
        [HttpPost]
        [ActionName("Index")] 
        public ActionResult AuthUser(UserIDViewModels viewModel, string returnUrl) // Authentification de l'utilisateur
        {
            using (UserInterface userInterface = new UsersRepository())
            {


                if (ModelState.IsValid)
                {

                    bool usersExist = userInterface.Auth(viewModel.userViewModel.Nom, viewModel.userViewModel.Password);
                                if (usersExist)
                                {
                       // Debug.WriteLine("isnotauth");

                        FormsAuthentication.SetAuthCookie(viewModel.userViewModel.Id.ToString(), false);

                                    if (!string.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl)) //returnUrl c'est l'url sur lequel l'user était sans être authentitifié

                                        return Redirect(returnUrl);  // après authentification on le renvoie vers le lien auquel il essayait d'accéder

                                          return Redirect("/Home/WebApp1");
                                }
                                else {
                                ModelState.AddModelError("Utilisateur.Nom", "le nom et/ou mot de passe incorrect(s)");
                                    }
                                
                            }
                            return View(viewModel);
                }
            }

            public ActionResult CreerCompte()
            {
                return View();
            }

            [HttpPost]
            public ActionResult CreerCompte(UsersID usersID)
            {
            using (UserInterface userInterface = new UsersRepository())
            {
                //if (ModelState.IsValid)
                //{
                //    StringUser id = userInterface.CreateUserId(usersID.Nom, usersID.Password);
                //    FormsAuthentication.SetAuthCookie(id.ToString(), false);
                //    return Redirect("/");
                //}
                return View(usersID);
            }
                
            }

        [Authorize]
        public ActionResult ListUsers()
        {
            //ViewData["date"] = DateTime.Now; UsersID users = new UsersID { Nom ="test" , Password="test"}; ViewData["UsersID"] = users;
            using (UserInterface userInterface = new UsersRepository())
            {
                List<UsersID> listUsers = userInterface.GetAllUsersIDs();
                return View(listUsers);
            }
        }

        [Authorize]
        public ActionResult WebApp1()
        {
            return View();
        }

        [Authorize]
        public ActionResult WebApp2()
        {
            return View();
        }
        public ActionResult Deconnexion() //Deconnection
            {
                FormsAuthentication.SignOut();
                return Redirect("/Home/Index");
           // return Redirect("UrlDuSSO");

        }



        //  public UsersID UpdateUser() {        }

        //  public UsersID DeleteUser() {        }



    }
}