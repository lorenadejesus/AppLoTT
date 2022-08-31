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
    public class citaDAO
    {


        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //BUSCAR USAUARIO PARA INICIAR SESIÓN
        public static citaUNO BuscarCita(string u)
        {
            citaUNO cita = null;
            try
            {
                string sql = "select * from lototre1_control.citas where folio='" + u ;

                MySqlCommand cmd = new MySqlCommand(sql, Conexion.ProbarConexion());
                MySqlConnector.MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cita = new citaUNO();
               
                    cita.nombre = reader.GetString("nombre");
                    cita.sexo = reader.GetString("sexo");
                    cita.codigoPostal = reader.GetInt32("codigoPostal");
                    cita.edad = reader.GetInt32("edad");
                    cita.fecha = (Dates.Date)reader.GetDateTime("fecha");
                    cita.hora = reader.GetTimeSpan("hora");
                    cita.situacion = reader.GetString("situacion");
                    

                }

            }
            catch (Exception ex) { }
            return cita;
        }//BuscarUsuario
        //------------------------------------------------------------------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------------------------------------------------------------------
        //CREAR CITA
        public static bool Create_cita(citaUNO e)
        {
            bool result = false;
                
            string sql = String.Format("insert into lototre1_control.citas values({0},'{1}','{2}',{3},{4},'{5}',{6},'{7}')",
                                                 e.folio,
                                                 e.nombre,
                                                 e.sexo, 
                                                 e.codigoPostal,
                                                 e.edad,
                                                 e.fecha,
                                                 e.hora, 
                                                 e.situacion);

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

        //----visualizar citas---------

        public citaUNO read_cita(int folio)
        {
            citaUNO cita = null;

            return cita;
        }

        public static List<citaUNO> consulta()

        {
            List<citaUNO> list = new List<citaUNO>();

            MySqlCommand comm = new MySqlCommand("select * from citas", Conexion.ProbarConexion());

            MySqlConnector.MySqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
                list.Add(new citaUNO
                {

                    nombre = reader.GetString("nombre"),
                    sexo = reader.GetString("sexo"),
                    hora = reader.GetTimeSpan("hora"),
                    situacion = reader.GetString("situacion")

                });

            return list;
        }










    }
}
