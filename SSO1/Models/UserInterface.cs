using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSO1.Models
{
    interface UserInterface: IDisposable
    {

//        List<User> GetUsers();

        List<UsersID> GetAllUsersIDs();

        void  CreateUserId(string Nom, string Password);

        void UpdateUserID(int id, string nom, string password);

        UsersID FindUserByID(int id);

        UsersID FindUserByName(string Name);

        void DeleteUserByID(int id);

        bool Auth(string nom, string Password);

        //bool CheckIfUserExist(string nom )
    }
}
