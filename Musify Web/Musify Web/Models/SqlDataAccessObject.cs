using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Musify_Web.Models
{
    public class SqlDataAccessObject
    {
        // Connection String can be found in web.config.
        public const string connectionString = "Sql";
        private string _connectionString = string.Empty;

        public string Connectionstring
        {
            get
            {
                if (_connectionString == String.Empty)
                {
                    _connectionString = ConfigurationManager.ConnectionStrings[connectionString].ConnectionString;
                }

                return _connectionString;
            }
        }

        public SqlCommand GetSqlCommand(string query)
        {
            SqlConnection conn = new SqlConnection(Connectionstring);
            SqlCommand sqlcmd = new SqlCommand(query, conn);
            return sqlcmd;
        }

        public DataTable Execute(string query)
        {
            DataTable dt = new DataTable();
            SqlCommand sqlcmd = GetSqlCommand(query);
            sqlcmd.Connection.Open();
            dt.Load(sqlcmd.ExecuteReader());
            sqlcmd.Connection.Close();

            return dt;
        }

        public DataTable Execute(SqlCommand sqlCmd)
        {
            DataTable dt = new DataTable();
            sqlCmd.Connection.Open();
            dt.Load(sqlCmd.ExecuteReader());
            sqlCmd.Connection.Close();

            return dt;
        }

        public int ExecuteNonQuery(string query)
        {
            SqlCommand sqlCmd = GetSqlCommand(query);
            sqlCmd.Connection.Open();
            int results = sqlCmd.ExecuteNonQuery();
            sqlCmd.Connection.Close();

            return results;
        }

        public int ExecuteNonQuery(SqlCommand sqlCmd)
        {
            sqlCmd.Connection.Open();
            int results = sqlCmd.ExecuteNonQuery();
            sqlCmd.Connection.Close();

            return results;
        }
    }
}