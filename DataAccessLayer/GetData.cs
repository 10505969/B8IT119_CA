using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;



namespace DataAccessLayer
{
    public class GetData : DAO
    {
        public DataTable getPassword(string username, string password)
        {
            SqlCommand cmd = new SqlCommand("SELECT UserName, pword FROM USERS WHERE UserName=@USER AND pword=@PASS", openConnection());
            cmd.Parameters.AddWithValue("@USER", username);
            cmd.Parameters.AddWithValue("@PASS", password);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            closeConnection();
            return dt;
        }

        public DataTable getStudents()
        {
            SqlCommand cmd = new SqlCommand("Select * From Students", openConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            closeConnection();
            return dt;
        }

    }
}
