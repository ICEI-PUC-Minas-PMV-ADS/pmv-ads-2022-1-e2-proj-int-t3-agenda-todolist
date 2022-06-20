using System;
using System.Collections.Generic;
using agenda_api.Entities;
using agenda_api.Interfaces.Repository;
using agenda_api.Interfaces.Services;

namespace agenda_api.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _taskRepository;

        public UserService(IUserRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public User SaveUser(User user)
        {
            try
            {
                _taskRepository.SaveUser(user);
            }
            catch (Exception e)
            {
                throw e;
            }

            return user;
        }

        public List<User> GetAll()
        {
            List<User> list;
            try
            {
                list = _taskRepository.GetAll();
            }
            catch (Exception e)
            {
                throw e;
            }

            return list;
        }

        public User GetById(int id)
        {
            User user;
            try
            {
                user = _taskRepository.GetById(id);
            }
            catch (Exception e)
            {
                throw e;
            }

            return user;
        }

        public bool Login(UserRequest user)
        {
            try
            {
                User dbUser = _taskRepository.GetUserByUsername(user.Username, user.Password);
                if(dbUser.Username != null)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }

            return false;
        }

        public User UpdateUser(int id, User user)
        {
            try
            {
                _taskRepository.UpdateUser(id, user);
            }
            catch (Exception e)
            {
                throw e;
            }

            return user;
        }

        public int DeleteUser(int id)
        {
            try
            {
                _taskRepository.DeleteUser(id);
            }
            catch (Exception e)
            {
                throw e;
            }

            return id;
        }
    }
}
