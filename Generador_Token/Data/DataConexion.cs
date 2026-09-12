using System;
using MySqlConnector;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Generador_Token.Models;
using System.Threading.Tasks;

namespace Generador_Token.Data
{
    internal class DataConexion
    {
        public static MySqlConnection conexionBD { get; set; }
        private static string connectionString { get; set; }

        public static async Task<MySqlConnection> Conectar()
        {
            try
            {
                conexionBD = new MySqlConnection(connectionString);
                return conexionBD;

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("El error es " + ex.Message);
                //throw;
                return null;

            }
        }
        public static void GetConnectionString(List<EmpresaModel> empresa)
        {
            //connectionString = "Database = login; Data Source = localhost; User Id = root; Password= 1234";
            connectionString = $"Database = NAME_DATABASE; Data Source = IP_SERVER; User Id = USER; Password= PSWD_DB; ConvertZeroDateTime=True";
        }

        public static void Abrir()
        {
            conexionBD.Open();
        }

        public static void Cerrar()
        {
            conexionBD.Close();
        }
    }
}
