using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinMySQL.Clases
{
    internal class Datos
    {
        String cadenaConexion = "server=localhost; user=luis; pwd = joseluis ";
        MySqlConnection conexion;

        private void conectar()
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
        public DataSet ejecutarComando(String comando)
        {
            try
            {
                conectar();
                MySqlDataAdapter da = new MySqlDataAdapter(comando, conexion);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public bool ejecutarcomando(String comando)
        {
            try
            {
                conectar();
                MySqlCommand cmd = new MySqlCommand(comando, conexion);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}

