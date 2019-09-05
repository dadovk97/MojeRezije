using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MojeRezije
{
    class DataBase
    {
        public static SqlConnection GetSqlkonekcija()
        {
            return new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dado\Documents\Rezije.mdf;Integrated Security=True;Connect Timeout=30");
        }
    }
}
