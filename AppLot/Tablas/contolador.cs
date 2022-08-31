using System;
using System.Collections.Generic;
using System.Text;
using AppLot.Datos;
namespace AppLot.Tablas
{
    public class contolador
    {
        public List<citaUNO> Cont { get; set; }
       
            public contolador()
            {
                Cont = citaDAO.consulta();
            }

    }
    }
