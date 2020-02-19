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
    public class RemoveData :DAO
    {
        public void RemoveStu(int studentno)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM WHERE StudentNo = @StudentNo ", openConnection());
            cmd.Parameters.AddWithValue("@StudentNo", studentno);
            cmd.ExecuteNonQuery();

            closeConnection();
        }
    }
}
