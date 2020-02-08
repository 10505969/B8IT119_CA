using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace DataAccessLayer
{
    class DAO
    {
        public SqlConnection conn;
        public DAO()
        {
            conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=University;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        public SqlConnection openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed ||
                conn.State == System.Data.ConnectionState.Broken)
                conn.Open();
            return conn;
        }
        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }
}
