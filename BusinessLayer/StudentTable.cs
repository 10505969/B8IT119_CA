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
    public class StudentTable
    {
        GetData data = new GetData();

        public DataTable Stus()
        {
            return data.getStudents();
        }
    }
}
