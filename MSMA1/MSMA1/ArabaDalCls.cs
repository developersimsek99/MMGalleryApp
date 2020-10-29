using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace MSMA1
{
    class ArabaDalCls
    {
        string linkAdressi;
        public DataTable Listeleme()
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\linkAddress.txt");
            string satir = streamReader.ReadLine();
            while (satir != null)
            {
                linkAdressi = satir;
                satir = streamReader.ReadLine();
            }
            SqlConnection connection = new SqlConnection(linkAdressi);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from ArabalarMS", connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            connection.Close();
            return dataTable;
        }
    }
}
