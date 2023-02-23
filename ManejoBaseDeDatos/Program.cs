using System;
using System.Data.SqlClient;

namespace ManejoBaseDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            conectandonos();
        }
        public static void conectandonos() {
            string cadenaConexion = @"Server=192.168.1.253;DataBase=Instituto X;User=sa;password=123456";// lo normal: .\SQLDEVELOPERCQ
            var con = new SqlConnection(cadenaConexion);
            con.Open();
            Console.WriteLine("Conexión exitosa");
            con.Close();

        }
    }
}
