using MyFirstProjectWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProjectWebApp.Services
{
    public class SecurityService
    {
        UsersDAO usersDAO = new UsersDAO();

        public SecurityService()
    {
         
        }

        public bool IsValid(User user)
        {
            //return true if user is found in the list
            return usersDAO.FindUserByNameAndPassword(user);
        }
    }
}
