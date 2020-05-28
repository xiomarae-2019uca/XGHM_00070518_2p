using System;
using System.Data;
using System.Data.SqlClient;
using Npgsql;
using System.Windows.Forms;
namespace SegundoParcial
{
    public class ConectionDBNpgsql

    {
        string parameter=("Server=localhost;Port=http:127.0.0.1;Id=postgres;Password=123456;DataBase=parcial_02;");
        private static string sConnection;
    
        public static DataTable  Connetion(string query)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            DataSet ds = new DataSet();
            connection.Open();
            
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            da.Fill(ds);
            
            connection.Close();

            return ds.Tables[0];
        }

        public static void Disconnection(string act)
        {
            Console.WriteLine(sConnection);
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(act, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}