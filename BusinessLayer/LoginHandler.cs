using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data.SqlClient;


namespace BusinessLayer
{
    public class LoginHandler
    {
        GetData data = new GetData();

        public bool Login (string user, string pass){
            if (data.getPassword(user, pass).Rows.Count > 0)
            {
                return true;
            }
            else
                return false;
        }

    }
}
