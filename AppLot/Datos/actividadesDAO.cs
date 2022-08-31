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
    public class actividadesDAO
    {


        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //BUSCAR USAUARIO PARA INICIAR SESIÓN
        public static actividadUNO BuscarAct(string u)
        {
            actividadUNO act = null;
            try
            {
                string sql = "select * from actividad where idActividad='" + u;

                MySqlCommand cmd = new MySqlCommand(sql, Conexion.ProbarConexion());
                MySqlConnector.MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    act = new actividadUNO();


                    act.idActividad = reader.GetInt32("idActividad");
                    act.nombreActividad = reader.GetString("nombre");
                    act.dia = reader.GetString("dia");
                    act.hora = reader.GetTimeSpan("hora");
                    act.desc = reader.GetString("desc");


                }

            }
            catch (Exception ex) { }
            return act;
        }//BuscarUsuario
        //------------------------------------------------------------------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------------------------------------------------------------------
        //CREAR CITA
        public static bool Create_act(actividadUNO e)
        {
            bool result = false;

            string sql = String.Format("insert into actividad values({0},'{1}','{2}',{3}," +
                "'{4}')",
                                                 e.idActividad,
                                                 e.nombreActividad,     
                                                 e.dia,
                                                 e.hora,
                                                 e.desc);

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

        public actividadUNO read_act(int idActividad)
        {
            actividadUNO act = null;

            return act;
        }

        public static List<actividadUNO> consulta()

        {
            List<actividadUNO> list = new List<actividadUNO>();

            MySqlCommand comm = new MySqlCommand("select * from actividad", Conexion.ProbarConexion());

            MySqlConnector.MySqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
                list.Add(new actividadUNO
                {

                    nombreActividad = reader.GetString("nombre"),
                    desc = reader.GetString("desc"),
                    dia = reader.GetString("dia"),
                    hora = reader.GetTimeSpan("hora")


        });

            return list;
        }








    }
}