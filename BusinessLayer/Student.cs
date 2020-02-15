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
    class Student
    {
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

        public static void addStudent(Student s)
        {
            AddData data = new AddData();

            data.AddStu(s.FirstName, s.LastName,s.Email, s.Phone, s.Address1, s.Address2, s.City, s.County.ToString(), s.Level.ToString(), s.StudentNo);
        
        }


    }

    
}
