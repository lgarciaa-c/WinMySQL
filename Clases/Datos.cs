using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using MySQL.Data.MySqlClient;

namespace WinMySQL.Clases
{
    internal class Datos
    {
        String cadenaConexion = "server=localhost; user=luis; pwd = joseluis ";
        MySqlConnection conexion;

        private void Conectar()
        {
            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                Console.WriteLine("Conexión exitosa");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine( ex.Message);
            }
        }

        private void Desconectar()
        {
            try
            {
               if ( conexion != null) {
                    conexion.Close();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

