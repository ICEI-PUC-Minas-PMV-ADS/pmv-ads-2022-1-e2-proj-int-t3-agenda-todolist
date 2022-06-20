using System;
using System.Collections.Generic;
using agenda_api.Entities;
using agenda_api.Interfaces.Repository;

namespace agenda_api.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private string TABLENAME = "Accounts";
        private string PARAMETERS = "User_type, Username, Password, Email";

        public UserRepository()
        {
            base._tableName = TABLENAME;
        }

        public int DeleteUser(int id)
        {
            try
            {
                base.deleteData($"'{id}'");
            }
            catch (Exception e)
            {
                throw e;
            }

            return id;
        }

        public List<User> GetAll()
        {
            return base.getData("*");
        }

        public User GetById(int id)
        {
            string condition = $"WHERE user_id='{id}'";
            return base.getData("*", condition)[0];
        }

        public User GetUserByUsername(string username, string password)
        {
            string condition = $"WHERE Username='{username}' AND Password='{password}'";
            return base.getData("*", condition)[0];
        }

        public User SaveUser(User user)
        {
            int userId;
            string values = $" '{user.User_type}', '{user.Username}', '{user.Password}', '{user.Email}' ";
            try
            {
                userId = base.insertData(PARAMETERS, values);
            }
            catch (Exception e)
            {
                throw e;
            }
            user.Id = userId;
            return user;
        }

        public User UpdateUser(int id, User user)
        {
            string values = $" user_type= '{user.User_type}', username = '{user.Username}', password = '{user.Password}' , email = '{user.Email}'";
            try
            {
                base.updateData(id, values);
            }
            catch (Exception e)
            {
                throw e;
            }
            return user;
        }
    }
}
