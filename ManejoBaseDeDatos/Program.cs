using System;
using System.Data;
using System.Data.SqlClient;

namespace ManejoBaseDeDatos
{
    internal class Program
    {
        static string cadenaConexion = @"Server=192.168.1.253;DataBase=Instituto X;User=sa;password=123456";// lo normal: .\SQLDEVELOPERCQ
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //conectandonos();
            //creandoTabla();
            //insertandoRegistro("ABCXYZ","Prueba loca de un jueves","Esta es una prueba del segundo módulo.");
            //eliminandoRegistro("ABCXYZ");
            enviarConsulta();
        }

        private static void enviarConsulta()
        {
            SqlDataReader reader;
            using (var con = new SqlConnection(cadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM desarrollo.materia;";
                reader = (SqlDataReader)cmd.ExecuteReader();
                string valores = "";
                while (reader.Read()) {
                    valores += $"Sigla: {reader.GetString(0)}\n";
                }

                Console.WriteLine(valores);
                cmd.Dispose();
            }
        }

        private static void eliminandoRegistro(string sigla)
        {
            using (var con = new SqlConnection(cadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = $"DELETE FROM desarrollo.materia WHERE sigla = '{sigla}';";
                cmd.ExecuteNonQuery();
                Console.WriteLine("Registro eliminado con éxito");
                cmd.Dispose();
            }
        }

        private static void insertandoRegistro(string sigla, string nombre, string descripcion)
        {
            using (var con = new SqlConnection(cadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = $"INSERT INTO desarrollo.materia VALUES ('{sigla}', '{nombre}', '{descripcion}');";
                cmd.ExecuteNonQuery();
                Console.WriteLine("Registro creado con éxito");
                cmd.Dispose();
            }
        }

        private static void creandoTabla()
        {
            using (var con = new SqlConnection(cadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "CREATE TABLE prueba2 (valor1 INT, cadena VARCHAR(20), numero INT);";
                cmd.ExecuteNonQuery();
                Console.WriteLine("Tabla creada con éxito");
                cmd.Dispose();
            }
        }

        public static void conectandonos() {
            

            using (var con = new SqlConnection(cadenaConexion))
            {
                con.Open();
                Console.WriteLine("Se conectó exitosamente.");
                
            }
            
        }
    }
}
