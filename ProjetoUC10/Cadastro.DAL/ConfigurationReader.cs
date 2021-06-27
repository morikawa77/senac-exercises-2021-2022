using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.DAL
{
    public class ConfigurationReader
    {
        public string ReadConnection()
        {
            string myConn = "";
            myConn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            return myConn;
        }
    }
}
