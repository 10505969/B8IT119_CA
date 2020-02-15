﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace DataAccessLayer
{
    public class AddData:DAO
    {




        public void AddStu(string fname, string lname, string email, string phone, string address1, string address2, string city, string county, string level, int studentno)




        {

            SqlCommand cmd = new SqlCommand("INSERT INTO Students (FirstName,LastName,Email,Phone," +
                " AddressLine1,AddressLine2,City,County,Level,StudentNo) VALUES (@FirstName, " +
                "@LastName, @Email, @Phone, @AddressLine1, @AddressLine2, @City, @County, " +
                "@Level, @StudentNo)", openConnection());
            cmd.Parameters.AddWithValue("@FirstName", fname);
            cmd.Parameters.AddWithValue("@LastName", lname);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Parameters.AddWithValue("@AddressLine1", address1);
            cmd.Parameters.AddWithValue("@AddressLine2", address2);
            cmd.Parameters.AddWithValue("@City", city);
            cmd.Parameters.AddWithValue("@County", county);
            cmd.Parameters.AddWithValue("@Level", level);
            cmd.Parameters.AddWithValue("@StudentNo", studentno);

            cmd.ExecuteNonQuery();

            closeConnection();
        }
    }
}
