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
        GetData gdata = new GetData();
        EditData edata = new EditData();
        RemoveData ddata = new RemoveData();

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public CountiesEnum County { get; set; }
        public LevelEnum Level { get; set; }
        public CourseEnum Course { get; set; }
        public int StudentNo { get; set; }

        public Student()
        {

        }

        public Student(string fname, string lname, string email, string phone, string address1, string address2, string city, CountiesEnum county, LevelEnum level, CourseEnum course, int studentno)
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
            Course = course;
            StudentNo = studentno;

        }

        public void AddStudent()
        {
            data.AddStu(FirstName, LastName, Email, Phone, Address1, Address2, City, County.ToString(), Level.ToString(), Course.ToString(), StudentNo);
        }

        public void RemoveStudent()
        {
            ddata.RemoveStu(StudentNo);
        } 

        public void EditStudent()
        {
            edata.EditStu(Email, Phone, Address1, Address2, City, County.ToString(), Level.ToString(), StudentNo);
        }

        public void DeleteStudent()
        {
            edata.DeleteStu(StudentNo);
        }

        public Student GetStuById(int studentno)
        {
            Student s = new Student();
            DataTable vals;
            vals = gdata.GetStudentByStuNo(studentno);
            
            s.FirstName = vals.Rows[0]["FirstName"].ToString();
            s.LastName = vals.Rows[0]["LastName"].ToString();
            s.Email = vals.Rows[0]["Email"].ToString();
            s.Phone = vals.Rows[0]["Phone"].ToString();
            s.Address1 = vals.Rows[0]["AddressLine1"].ToString();
            s.Address2 = vals.Rows[0]["AddressLine2"].ToString();
            s.City = vals.Rows[0]["City"].ToString();
            Enum.TryParse<CountiesEnum>(vals.Rows[0]["County"].ToString(), out CountiesEnum county);
            s.County = county;
            Enum.TryParse<LevelEnum>(vals.Rows[0]["Level"].ToString(), out LevelEnum level);
            s.Level = level;
            Enum.TryParse<CourseEnum>(vals.Rows[0]["Course"].ToString(), out CourseEnum course);
            s.Course = course;
            s.StudentNo = studentno;
            return s;
        }


    }

    
}
