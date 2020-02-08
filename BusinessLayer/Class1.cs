using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class LoginHandler
    {       
            public DAO conn = new DAO();

            static GetData data = new GetData();

            public bool login(string u, string p)
            {

                return true;
            }
        
    }
}

