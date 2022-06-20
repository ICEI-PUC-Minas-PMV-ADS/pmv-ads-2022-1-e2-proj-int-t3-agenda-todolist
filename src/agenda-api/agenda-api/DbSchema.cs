using System;
namespace agenda_api
{
    public static class DbSchema
    {
        private static DbConnection _dbConnection = new DbConnection();

        public static void INIT()
        {
            createAccountTable();
            createBoardTable();
            //createAccountTypeEnumTable();
            createTaskTable();
        }


        private static void createAccountTable()
        {
            string taskTableQUery = "CREATE TABLE IF NOT EXISTS Accounts (" +
                "user_id serial PRIMARY KEY," +
                "User_type VARCHAR ( 50 ) NOT NULL," +
                "Username VARCHAR ( 50 ) UNIQUE NOT NULL," +
                "Password VARCHAR (  50 ) NOT NULL," +
                "Email VARCHAR ( 255 ) UNIQUE NOT NULL" +
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
                "CreatedDate TIMESTAMP NOT NULL," +
                "board_id integer," +
                "user_id integer," +
                "FOREIGN KEY (user_id) REFERENCES Accounts (user_id)," +
                "FOREIGN KEY (board_id) REFERENCES Board (id)" +
                ")";

            _dbConnection.MakeQuery(taskTableQUery);
        }

        private static void createBoardTable()
        {
            string taskTableQUery = "CREATE TABLE IF NOT EXISTS Board (" +
                "id serial PRIMARY KEY," +
                "Name VARCHAR ( 50 ) UNIQUE NOT NULL," +
                "Description VARCHAR ( 50 ) NOT NULL" +
                ")";

            _dbConnection.MakeQuery(taskTableQUery);
        }

    }
}
