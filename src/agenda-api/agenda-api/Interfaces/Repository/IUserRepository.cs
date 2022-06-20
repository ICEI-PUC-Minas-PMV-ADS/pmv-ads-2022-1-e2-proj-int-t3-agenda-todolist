using System;
using System.Collections.Generic;
using agenda_api.Entities;

namespace agenda_api.Interfaces.Repository
{
    public interface IUserRepository
    {
        public List<User> GetAll();
        public User GetById(int id);
        public User GetUserByUsername(string username, string password);
        public User SaveUser(User user);
        public User UpdateUser(int id, User user);
        public int DeleteUser(int id);
    }
}
