using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDA.NewFolder
{
    internal class connection
    {
        private static string stringConnection = @"Data Source=DESKTOP-VGE692E;Initial Catalog=QLDA1;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";


        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
