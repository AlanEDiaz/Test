using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiRestfull.Services;

namespace WebApiRestfull.Factories
{
    public static class UserServiceFactory
    {
        public static UserService GetUserService()
        {
            return new UserService(new Daos.UserDao(new UsersEntities()));
        }
    }
}