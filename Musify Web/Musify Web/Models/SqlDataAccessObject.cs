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
        Exceptions eh = new Exceptions();

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
            SqlCommand sqlCmd = GetSqlCommand(query);
            sqlCmd.Connection.Open();
            try
            {
                dt.Load(sqlCmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
            }
            finally
            {
                sqlCmd.Connection.Close();
            }

            return null;
        }

        public DataTable Execute(SqlCommand sqlCmd)
        {
            DataTable dt = new DataTable();
            sqlCmd.Connection.Open();
            try
            {
                dt.Load(sqlCmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
            }
            finally
            {
                sqlCmd.Connection.Close();
            }

            return null;
        }

        public int ExecuteNonQuery(string query)
        {
            SqlCommand sqlCmd = GetSqlCommand(query);
            sqlCmd.Connection.Open();
            try
            {
                int results = sqlCmd.ExecuteNonQuery();
                return results;
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
            }
            finally
            {
                sqlCmd.Connection.Close();
            }

            return 0;
        }

        public int ExecuteNonQuery(SqlCommand sqlCmd)
        {
            sqlCmd.Connection.Open();
            try
            {
                int results = sqlCmd.ExecuteNonQuery();
                return results;
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
            }
            finally
            {
                sqlCmd.Connection.Close();
            }

            return 0;
        }
    }
}