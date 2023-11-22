using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2._6
{
    internal class DataConnection
    {
        string conStr;
        public DataConnection()
        {
            conStr = "Data Source = ANHTU\\SQLEXPRESS; Initial Catalog= QLSV; Integrated Security=true";
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(conStr);
        }
    }
}
