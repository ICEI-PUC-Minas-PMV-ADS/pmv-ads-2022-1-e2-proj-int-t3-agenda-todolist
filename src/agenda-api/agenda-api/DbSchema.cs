using System;
namespace agenda_api
{
    public static class DbSchema
    {
        private static DbConnection _dbConnection = new DbConnection();

        public static void INIT()
        {
            createAccountTypeEnumTable();
            createAccountTable();
            createTaskTable();
            createBoardTable();
        }

        private static void createAccountTypeEnumTable()
        {
            string taskTableQUery = "CREATE TYPE UserType AS ENUM ('admin', 'user');";

            _dbConnection.MakeQuery(taskTableQUery);
        }


        private static void createAccountTable()
        {
            string taskTableQUery = "CREATE TABLE IF NOT EXISTS Accounts (" +
                "user_id serial PRIMARY KEY," +
                "user_type UserType NOT NULL default 'user'," +
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
                "user_id integer," +
                "FOREIGN KEY (user_id) REFERENCES Accounts (user_id)" + 
                ")";

            _dbConnection.MakeQuery(taskTableQUery);
        }

        private static void createBoardTable()
        {
            string taskTableQUery = "CREATE TABLE IF NOT EXISTS Board (" +
                "id serial PRIMARY KEY," +
                "Name VARCHAR ( 50 ) UNIQUE NOT NULL," +
                "Description VARCHAR ( 50 ) NOT NULL," +
                "task_id integer," +
                "FOREIGN KEY (task_id) REFERENCES Task (id)" +
                ")";

            _dbConnection.MakeQuery(taskTableQUery);
        }

    }
}
