using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circulation02
{
    class dbConnection
    {

        public string cnnStr = "";

        public SqlConnection dbConnect()
        {
            cnnStr = ConfigurationSettings.AppSettings.Get("SqlString");
            return new SqlConnection(cnnStr);
        }
    }
}
