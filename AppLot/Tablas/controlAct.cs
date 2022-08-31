using System;
using System.Collections.Generic;
using System.Text;
using AppLot.Datos;
namespace AppLot.Tablas
{
    public class controlAct
    {
        public List<actividadUNO> act { get; set; }

        public controlAct()
        {
            act = actividadesDAO.consulta();
        }

    }
}