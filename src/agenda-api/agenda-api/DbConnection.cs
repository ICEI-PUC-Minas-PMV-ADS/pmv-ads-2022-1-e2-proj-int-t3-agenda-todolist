using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Npgsql;

namespace agenda_api
{
    public class DbConnection
    {
        private string PROVIDER = "Npgsql";
        private string HOST = "ec2-54-80-123-146.compute-1.amazonaws.com";
        private string DATABASE = "d901ft3rhfec1u";
        private string USER = "hxntnetyxesfyb";
        private string PORT = "5432";
        private string PASSWORD = "21db05406114025343ec288430f7a251d50964661e6809622050b7dd2cde0e79";


        private NpgsqlConnection _con;

        public DbConnection()
        {
            //var conn = DbProviderFactories.GetFactory(PROVIDER).CreateConnection();
            string strConnection = $"Server={HOST}; " + $"Port={PORT}; " +
            $"User Id={USER};" + $"Password={PASSWORD};" + $"Database={DATABASE};";

            _con = new NpgsqlConnection(strConnection);
        }

        public DataTable getDataQuery(string cmd)
        {
            DataTable dataTable = new DataTable();
            try
            {
                _con.Open();
                using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmd, _con))
                {
                    Adpt.Fill(dataTable);
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _con.Close();
            }

            return dataTable;
        }

        public int MakeQuery(string cmd)
        {
            int resultId;
            try
            {
                _con.Open();
                using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(cmd, _con))
                {
                    resultId = npgsqlCommand.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _con.Close();
            }

            return resultId;
        }

    }
}
