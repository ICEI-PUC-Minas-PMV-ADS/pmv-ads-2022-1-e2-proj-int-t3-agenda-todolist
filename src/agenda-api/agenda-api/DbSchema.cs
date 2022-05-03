using System;
namespace agenda_api
{
    public static class DbSchema
    {
        private static DbConnection _dbConnection = new DbConnection();

        public static void INIT()
        {
            createAccountTable();
            createTaskTable();
        }

        private static void createAccountTable()
        {
            string taskTableQUery = "CREATE TABLE IF NOT EXISTS accounts (" +
                "user_id serial PRIMARY KEY," +
                "username VARCHAR ( 50 ) UNIQUE NOT NULL," +
                "password VARCHAR ( 50 ) NOT NULL," +
                "email VARCHAR ( 255 ) UNIQUE NOT NULL," +
                "created_on TIMESTAMP NOT NULL" + 
                ")";

            _dbConnection.MakeQuery(taskTableQUery);
        }

        private static void createTaskTable()
        {
            string taskTableQUery = "CREATE TABLE IF NOT EXISTS Task (" +
                "id serial PRIMARY KEY," +
                "Name VARCHAR ( 50 ) UNIQUE NOT NULL," +
                "Description VARCHAR ( 50 ) NOT NULL," +
                "TodoDate TIMESTAMP," +
                "CreatedDate TIMESTAMP NOT NULL" +
                ")";

            _dbConnection.MakeQuery(taskTableQUery);
        }

    }
}
