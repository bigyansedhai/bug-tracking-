using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesslayer
{
    class ConnectionClass
    {
        public static String ConnectionString
        { get { return System.Configuration.ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString; } }
    }
}
