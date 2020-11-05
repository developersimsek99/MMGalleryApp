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
        private SqlConnection Baglanti()
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

            return connection;
        }

        public DataTable Listeleme()
        {
            SqlConnection connection = Baglanti();
            SqlCommand command = new SqlCommand("Select * from ArabalarMA", connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            connection.Close();
            return dataTable;
        }

        public void Ekle(ArabaCls arabaCls)
        {
            SqlConnection connection = Baglanti();
            SqlCommand command = new SqlCommand("Insert into ArabalarMA values (@marka,@model,@fiyat,@aciklama)",connection);
            command.Parameters.AddWithValue("@marka",arabaCls.Marka);
            command.Parameters.AddWithValue("@model",arabaCls.Model);
            command.Parameters.AddWithValue("@fiyat", arabaCls.Fiyat);
            command.Parameters.AddWithValue("@aciklama", arabaCls.Aciklama);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Update(ArabaCls arabaCls)
        {
            SqlConnection connection = Baglanti();
            SqlCommand command = new SqlCommand("Update ArabalarMA set Marka=@marka,Model=@model,Fiyat=@fiyat,Aciklama=@aciklama where Id=@id",connection);
            command.Parameters.AddWithValue("@marka", arabaCls.Marka);
            command.Parameters.AddWithValue("@model", arabaCls.Model);
            command.Parameters.AddWithValue("@fiyat", arabaCls.Fiyat);
            command.Parameters.AddWithValue("@aciklama", arabaCls.Aciklama);
            command.Parameters.AddWithValue("@id",arabaCls.Id);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Delete(int id)
        {
            SqlConnection connection = Baglanti();
            SqlCommand command = new SqlCommand("Delete from ArabalarMA where Id=@id",connection);
            command.Parameters.AddWithValue("@id",id);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
