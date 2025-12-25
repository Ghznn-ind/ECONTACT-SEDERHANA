using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Econtact
{
    class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=LAPTOP-PGKJND9B\\SQLExpress01;Initial Catalog=dbEcontact;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            return conn;
        }
    }
}
