using System;
using System.Collections.Generic;
using agenda_api.Entities;

namespace agenda_api.Interfaces.Services
{
    public interface IUserService
    {
        public User SaveUser(User user);
        public List<User> GetAll();
        public User GetById(int id);
        public bool Login(UserRequest user);
        public User UpdateUser(int id, User user);
        public int DeleteUser(int id);
    }
}
