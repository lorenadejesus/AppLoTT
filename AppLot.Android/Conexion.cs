using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySqlConnector;
using MySql.Command;
using Android.Content;

namespace AppLot.Droid
{ 


    public class Conexion
    {
        public MySqlConnection conn;
        public bool TryConnection(Context context)
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
                return true;
            }
            catch (Exception ex)
            {
                //Toast.MakeText(context, ex.ToString(), ToastLength.Long).Show(); //Muestra un Toast con el error (Puede ser muy largo)

                //        Toast.MakeText(context, ex.ToString(), ToastLength.Long).Show();
                return false;
            }
        }
    }
}


