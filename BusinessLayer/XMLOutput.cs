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
    public class XMLOutput
    {
        GetData gdata = new GetData();

        public void FullTabletoXml(string folderpath)
        {
            string filepath = folderpath + @"\Students.xml";
            DataSet ds = new DataSet("Students");
            DataTable stus = gdata.GetFullStudentTable();
            stus.TableName = "Student";
            ds.Tables.Add(stus);
            ds.WriteXml(filepath);

        }

        public void StudentToXml(string folderpath, string studentNo)
        {
            int studentNumber = int.Parse(studentNo);
            string filepath = folderpath + @"\" + studentNo + @".xml";
            DataSet ds = new DataSet("Students");
            DataTable stus = gdata.GetStudentByStuNo(studentNumber); 
            stus.TableName = "Student";
            ds.Tables.Add(stus);
            ds.WriteXml(filepath);

        }
    }
}
