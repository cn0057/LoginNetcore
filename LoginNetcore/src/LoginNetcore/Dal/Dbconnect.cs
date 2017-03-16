using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;                
using System.Data.Common;

namespace LoginNetcore.Dal
{
    public class Dbconnect
    {
        public static DbConnection GetOpenConnection()
        {
            var connection = new SqlConnection(@"Server = localhost; uid = sa; pwd = cn0057; DataBase = myDataBase");
            connection.Open();
            return connection;
        }
    }
}
