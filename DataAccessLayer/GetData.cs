using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    class GetData : DAO
    {
        public string getPassword(string username, string password)
        {
            SqlCommand cmd = new SqlCommand("SELECT pword FROM USERS WHERE UserName=@USER)", openConnection());
            cmd.Parameters.AddWithValue("@USER", username);
            cmd.ExecuteNonQuery();
            closeConnection();

            return cmd.ToString();
        }
    }
}
