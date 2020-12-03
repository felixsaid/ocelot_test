using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Database.Entities;

namespace UserService.Services
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        User GetUserById(int userId);
        User CreateNewUser(User userItem);
        User UpdateUser(int userId, User userItem);
        string DeleteUser(int userId);
    }
}
