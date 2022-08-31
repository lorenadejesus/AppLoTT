using System;
using System.Collections.Generic;
using System.Text;
using Dates;
namespace AppLot.Datos
{
    public class citaUNO
    {

        public int folio { get; set; }
        public string nombre { get; set; }
        public string sexo { get; set; }
        public int codigoPostal { get; set; }
        public int edad { get; set; }
        public Date fecha { get; set; }
        public TimeSpan hora { get; set; }

        public string situacion { get; set; }
    }
}
