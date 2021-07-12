using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Data.Database
{
    public class Adapter
    {
        //private SqlConnection sqlConnection = new SqlConnection("ConnectionString;");
        const string consKeyDefaultCnnString = "ConnStringLocal";
        private SqlConnection _sqlConn;
        public SqlConnection SqlConn
        { 
            get=>this._sqlConn;
            set=>this._sqlConn=value; 
        }
        protected void OpenConnection()
        {
            String conn = ConfigurationManager.ConnectionStrings[consKeyDefaultCnnString].ConnectionString;
            //throw new Exception("Metodo no implementado");
            SqlConn = new SqlConnection(conn);
            SqlConn.Open();
        }

        protected void CloseConnection()
        {
            SqlConn.Close();
            SqlConn = null;
        }

        protected SqlDataReader ExecuteReader(String commandText)
        {
            throw new Exception("Metodo no implementado");
        }
    }
}
