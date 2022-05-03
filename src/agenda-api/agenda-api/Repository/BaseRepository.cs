using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using agenda_api.Entities;
using Npgsql;

namespace agenda_api.Repository
{
    public class BaseRepository<T> where T : BaseEntity
    {
        // your data table
        protected string _tableName;

        public List<T> getData(string parameters, string condition = null)
        {
            string baseQuery = $"select {parameters} from {_tableName} {condition}";
            DbConnection dbConnection = new DbConnection();
            DataTable dataTable = dbConnection.getDataQuery(baseQuery);
            return ConvertToList<T>(dataTable);
        }

        public void insertData(string parameters, string values)
        {
            string baseQuery = $"Insert Into {_tableName}({parameters}) values({values})";
            DbConnection dbConnection = new DbConnection();
            try
            {
                dbConnection.MakeQuery(baseQuery);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        private static List<T> ConvertToList<T>(DataTable dataTable)
       {
           var columnNames = dataTable.Columns.Cast<DataColumn>().Select(c => c.ColumnName.ToLower()).ToList();
           var properties = typeof(T).GetProperties();
           return dataTable.AsEnumerable().Select(row => {
               var objT = Activator.CreateInstance<T>();
               foreach (var pro in properties)
               {
                   if (columnNames.Contains(pro.Name.ToLower()))
                   {
                       try
                       {
                           pro.SetValue(objT, row[pro.Name]);
                       }
                       catch (Exception ex) { }
                   }
               }
               return objT;
           }).ToList();
       }

    }
}
