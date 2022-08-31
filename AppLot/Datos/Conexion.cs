using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySqlConnector;
using MySql.Command;

namespace AppLot.Datos
{

    public class Conexion
    {

        public static MySqlConnection conn= null;
        public static MySqlConnection ProbarConexion()
        {
            MySqlConnectionStringBuilder Builder = new MySqlConnectionStringBuilder();
            Builder.Port = 3306;
            Builder.Server = "65.99.225.37"; //Al ser una BD Online debes usar la ip de tu servidor y no localhost
            Builder.Database = "lototre1_control";
            Builder.UserID = "lototre1_desarrollo"; //Es el usuario de la base de datos
            Builder.Password = "Lototres2022"; //La contraseña del usuario
            try
            {
                conn = new MySqlConnection(Builder.ToString());
                conn.Open();
                
            }
            catch (Exception exException)
            {
                throw new Exception("Ha ocurrido un error");
               
            }
            return conn;
        }//probar

        public static void cerrar()
        {
            conn.Close();
        }//cerrar

}//clASE
}//nombre de clase