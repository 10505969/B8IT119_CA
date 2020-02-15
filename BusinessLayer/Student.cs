using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLayer
{
    public class Student
    {

        AddData data = new AddData();

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public CountiesEnum County { get; set; }
        public LevelEnum Level { get; set; }
        public int StudentNo { get; set; }

        public Student()
        {

        }

        public Student(string fname, string lname, string email, string phone, string address1, string address2, string city, CountiesEnum county, LevelEnum level, int studentno)
        {
            FirstName = fname;
            LastName = lname;
            Email = email;
            Phone = phone;
            Address1 = address1;
            Address2 = address2;
            City = city;
            County = county;
            Level = level;
            StudentNo = studentno;

        }

        public void AddtoDB()
        {
            data.AddStu(FirstName, LastName, Email, Phone, Address1, Address2, City, County.ToString(), Level.ToString(), StudentNo);
        }

        public static void AddStudent(Student s)
        {
            s.AddtoDB();
        }


    }

    
}
