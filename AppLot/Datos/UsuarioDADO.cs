using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;
using MySql.Data;
using MySql.Data.MySqlClient;
using AppLot.Datos;
using System.Security.Cryptography;
using MySqlCommand = MySqlConnector.MySqlCommand;

namespace AppLot.Datos
{
    public class UsuarioDADO
    {

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //BUSCAR USAUARIO PARA INICIAR SESIÓN
        public static UsuarioUNO BuscarUsuario(string u, string c)
        {
            UsuarioUNO usuario = null;
            try
            {
                string sql = "SELECT * FROM Usuario where correoElectronico='" + u + "' and contrasena='" + c + "'";
                MySqlCommand cmd = new MySqlCommand(sql, Conexion.ProbarConexion());
                MySqlConnector.MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    usuario = new UsuarioUNO();
                    usuario.correoElectronico = reader.GetString("correoElectronico");
                    usuario.contrasena = reader.GetString("contrasena");
                }
            }
            catch (Exception ex) { }
            return usuario;
        }//BuscarUsuario
        //------------------------------------------------------------------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------------------------------------------------------------------
        //REGISTRARSE COMO NUEVO USUARIO JEJEJEJEJE
        public static bool Create_usuario(UsuarioUNO e)
        {
            bool result = false;

            string sql = String.Format("insert into usuario values('{0}','{1}','{2}','{3}','{4}'," +
                                                 "'{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')",
                                                 e.ID_usuario,
                                                 e.correoElectronico,
                                                 e.contrasena, 
                                                 e.nombre,
                                                 e.apellidoPa, 
                                                 e.apellidoMa,
                                                 e.edad, 
                                                 e.calle,
                                                 e.numExterior, 
                                                 e.numInterior,
                                                 e.colonia, 
                                                 e.municipio,
                                                 e.codigoPostal);

            try
            {
                MySqlCommand comm = new MySqlCommand(sql, Conexion.ProbarConexion());
                comm.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {

            }
            return result;
        }//create 

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //ELIMINAR UN USUARIO

        public static bool Delete_usuario(string ID_usuario)
        {
            bool result = false;
            string slq = String.Format("delete FROM usuario where ID_usuario='{0}';", ID_usuario);
            //delete FROM lototre1_control.registro where correoElectronico='misael'
            try
            {
                MySqlCommand comm = new MySqlCommand(slq, Conexion.ProbarConexion());
                comm.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex) { }
            return result;

        }//delete
         //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // actualizar usuario
        public static bool update_usuario(UsuarioUNO e)
        {
            bool result = false;
            var slq = String.Format("UPDATE Usuario SET correoElectronico='{0}'," +
                 "contrasena = '{1}'," +
                 "nombre = '{2}'," +
                 "apellidoPa= '{3}'," +
                 "apellidoMa = '{4}'," +
                 "edad = {5} ," +
                 "calle='{6}', " +
                 "numExterior ='{7}', " +
                 "numInterior='{8}', " +
                 "colonia='{9}', " +
                 "municipio='{10}' where correoElectronico='{0}'"
                 , e.correoElectronico,
                  e.contrasena, e.nombre,
                  e.apellidoPa, e.apellidoMa,
                  e.edad, e.calle,
                  e.numExterior, e.numInterior,
                  e.colonia, e.municipio);

            try
            {
                MySqlCommand comm = new MySqlCommand(slq, Conexion.ProbarConexion());
                comm.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex) { }

            return result;


        }//UPDATE 
        //-----------------------------------------------------------------------------------------------------------------------------------------

        public UsuarioUNO read_usuario(string correoElectronico)

        {
            UsuarioUNO usuario = null;
            return usuario;

        }//read-usuario







        //cifrar contraseña
        public static string encriptarContrasena(string contrasena)

        {
        SHA1 sha1 = new SHA1CryptoServiceProvider();
       byte[] inputBytes = (new UnicodeEncoding()).GetBytes(contrasena); byte[] hash = sha1.ComputeHash(inputBytes);

        return Convert.ToBase64String(hash);
        }







    }//
}


       
    
    











