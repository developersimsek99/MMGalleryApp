using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MSMA1
{
    class ArabaDalCls
    {
        public DataTable Listeleme()
        {
            SqlConnection connection = new SqlConnection(@"server=DESKTOP-C4FIS0N\SQLEXPRESS; initial catalog=DbGaleriMA; integrated security=true;");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from ArabalarMA", connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            connection.Close();
            return dataTable;
        }
    }
}
