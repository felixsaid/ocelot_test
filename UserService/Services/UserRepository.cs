using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Database;
using UserService.Database.Entities;

namespace UserService.Services
{
    public class UserRepository : IUserRepository
    {

        private readonly DatabaseContext _context;

        public UserRepository(DatabaseContext context)
        {
            _context = context;
        }

        public User CreateNewUser(User userItem)
        {
            throw new NotImplementedException();
        }

        public string DeleteUser(int userId)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUsers()
        {
           return _context.Users.ToList();
        }

        public User GetUserById(int userId)
        {
            return _context.Users.Find(userId);
        }

        public User UpdateUser(int userId, User userItem)
        {
            throw new NotImplementedException();
        }
    }
}
