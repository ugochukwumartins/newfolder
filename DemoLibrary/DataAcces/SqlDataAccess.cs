using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DemoLibrary.DataAcces
{
   public  static class SqlDataAccess
    {
        public static string ConnectionString(string connection ="MVCDemodb")
        {
            return ConfigurationManager.ConnectionStrings[connection].ConnectionString;
        }
        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(ConnectionString()))
            {
                return cnn.Query<T>(sql).ToList();
            }
        }
         
        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(ConnectionString()))
            {
                return cnn.Execute(sql, data);
            }
        }
    }
}
