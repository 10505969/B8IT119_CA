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
            SqlCommand cmd = new SqlCommand("SELECT UserName, pword FROM USERS WHERE UserName=@USER AND Pword=@PASS", openConnection());
            cmd.Parameters.AddWithValue("@USER", username);
            cmd.Parameters.AddWithValue("@PASS", password);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.ExecuteNonQuery();
            closeConnection();

            return dt;
        }

        public DataTable getStudents()
        {
            SqlCommand cmd = new SqlCommand("Select FirstName AS [First Name], LastName AS Surname, Email AS [Email Address], Phone AS [Phone No], AddressLine1 AS [Address Line 1], AddressLine2 AS [Address Line 2], City, County, Level, Course, StudentNo AS [Student Number] From Students WHERE IsDeleted = 0", openConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.ExecuteNonQuery();

            closeConnection();
            return dt;
        }


        public DataTable GetStudentByStuNo(int studentno)
        {
            SqlCommand cmd = new SqlCommand("Select * From Students WHERE StudentNo=@STUDENTNO", openConnection());
            cmd.Parameters.AddWithValue("@STUDENTNO", studentno);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            closeConnection();
            return dt;
        }

        public DataTable GetFullStudentTable()
        {
            {
                SqlCommand cmd = new SqlCommand("Select * From Students", openConnection());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmd.ExecuteNonQuery();

                closeConnection();
                return dt;
            }

        }

        public DataTable GetStudentLogTable()
        {
            {
                SqlCommand cmd = new SqlCommand("Select ChangeDate AS [Date of Change], Change, FirstName AS [First Name], LastName AS [Last Name], EmailNew AS [Updated Email], EmailOld AS [Old Email], AddressLine1New AS [Updated Address Line 1], AddressLine1Old AS [Old Address Line 1], AddressLine2New AS [Updated Address Line 2], AddressLine2Old AS [Old Address Line 2], CityNew AS [Updated City], CityOld AS [Old City], CountyNew AS [Updated County], CountyOld AS [Old County], LevelNew AS [Updated Level],  LevelOld AS [Old Level], Course, StudentNo AS[Student No] From StudentLog", openConnection());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmd.ExecuteNonQuery();

                closeConnection();
                return dt;
            }

        }
    }
}
