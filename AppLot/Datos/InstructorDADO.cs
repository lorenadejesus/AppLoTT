using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;
using MySql.Data;
using MySql.Data.MySqlClient;
using AppLot.Datos;
using MySqlCommand = MySqlConnector.MySqlCommand;

namespace AppLot.Datos
{
    public class InstructorDADO
    {

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //BUSCAR Instructor PARA INICIAR SESIÓN
        public static InstructorUNO BuscarUsuario(string u, string c)
        {
            InstructorUNO instructor = null;
            try
            {
                string sql = "select * from lototre1_control.registroInstructor where correoElectronico='" + u + "' and contrasena='" + c + "'";

                MySqlCommand cmd = new MySqlCommand(sql, Conexion.ProbarConexion());
                MySqlConnector.MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    instructor = new InstructorUNO();
                    instructor.correoElectronico = reader.GetString("correoElectronico");
                    instructor.contrasena = reader.GetString("contrasena");
                    instructor.nombre = reader.GetString("nombre");
                    instructor.apellidoPa = reader.GetString("apellidoPa");
                    instructor.apellidoMa = reader.GetString("apellidoMa");
                    instructor.edad = reader.GetInt32("edad");
                    instructor.calle = reader.GetString("calle");
                    instructor.numExterior = reader.GetString("numExterior");
                    instructor.numInterior = reader.GetString("numInterior");
                    instructor.colonia = reader.GetString("colonia");
                    instructor.municipio = reader.GetString("municipio");

                }

            }
            catch (Exception ex) { }
            return instructor;
        }//BuscarUsuario
        //------------------------------------------------------------------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------------------------------------------------------------------
        //REGISTRARSE COMO NUEVO Instructor JEJEJEJEJE
        public static bool Create_instructor(InstructorUNO e)
        {
            bool result = false;

            string sql = String.Format("insert into lototre1_control.registroInstructor values('{0}','{1}','{2}','{3}','{4}'," +
                                                 "{5},'{6}','{7}','{8}'," +
                                                 "'{9}','{10}')",
                                                 e.correoElectronico,
                                                 e.contrasena, e.nombre,
                                                 e.apellidoPa, e.apellidoMa,
                                                 e.edad, e.calle,
                                                 e.numExterior, e.numInterior,
                                                 e.colonia, e.municipio);

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

        public static bool Delete_instructor(string correoElectronico)
        {
            bool result = false;
            string slq = String.Format("delete from lototre1_control.registroInstructor where correoElectronico={0}", correoElectronico);
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
        public static bool update_instructor(InstructorUNO e)
        {
            bool result = false;
            string slq = String.Format("update lototre1_control.registroInstructor set correoElectronico='{0}'," +
                 "contrasena = '{1}'," +
                 "nombre = '{2}'," +
                 "apellidoPa= '{3}'," +
                 "apellidoMa = '{4}'," +
                 "edad = {5} ," +
                 "calle='{6}', " +
                 "numExterior ='{7}', " +
                 "numInterior='{8}', " +
                 "colonia='{9}', " +
                 "municipio='{10}' "
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

        public InstructorUNO read_usuario(string correoElectronico)

        {
            InstructorUNO instructor = null;
            return instructor;

        }
        
    }//
}


       
    
    











