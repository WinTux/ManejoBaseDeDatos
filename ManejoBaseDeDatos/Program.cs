using System;

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
            string cadenaConexion = @"Server=192.168.1.253;DataBase=Instituto X;User=sa;";// lo normal: .\SQLDEVELOPERCQ
        }
    }
}
