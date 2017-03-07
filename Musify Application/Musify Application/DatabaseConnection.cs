using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musify_Application
{
    class DatabaseConnection
    {
        private string _dbQuery;
        private string _dbConn;
        private SqlDataAdapter _adapter;

        public string Query
        {
            set { _dbQuery = value; }
        }

        public string DbConn
        {
            set { _dbConn = value; }
        }

        public DataSet GetConn
        {
            get { return myDataSet(); }
        }

        private DataSet myDataSet()
        {
            SqlConnection conn = new SqlConnection(_dbConn);
            conn.Open();
            _adapter = new SqlDataAdapter(_dbQuery, _dbConn);
            DataSet _dataset = new DataSet();
            _adapter.Fill(_dataset, "DataInfo");
            conn.Close();
            return _dataset;
        }

        public void UpdateDatabase(DataSet ds)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(_adapter);
            cb.DataAdapter.Update(ds.Tables[0]);
        }
    }
}
