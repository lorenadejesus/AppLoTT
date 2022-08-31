using System;
using System.Collections.ObjectModel;
using System.Drawing;
using AppLot.Datos;
using System.ComponentModel;
namespace AppLot.Tablas
{
    public class InfoViews
    {
        public ObservableCollection<InformacionDato> informacionDato { get; set; }


        public InfoViews()
        {
            informacionDato = new ObservableCollection<InformacionDato>
            {
                new InformacionDato
                {
                    Picture = "fu.png",
                    Title = "Misión",
                   Description = "Contribuir a la atención de grupos vulnerables desarrollando actividades, programas y apoyos en busca de su bienestar.",
                    BGColor = "#109dfa"
                },
                new InformacionDato
                {
                    Picture = "loto2.png",
                    Title = "Visión",
                    Description = "Darnos a conocer y posicionarnos como una asociación de tercer sector, aumentando los apoyos y programas sociales hacia grupos vulnerables siendo así una asociación vanguardista, innovadora y respetada.",
                    BGColor = "#109dfa"
                },
                new InformacionDato
                {
                    Picture = "loto3.png",
                    Title = "Valores",
                    Description = "- Libertad\r \n"+"- Compromiso y Participación\r \n"+"- Humanismo\r \n"+"- Solidaridad\r \n"+"- Trabajo en equipo",
                    BGColor = "#109dfa    "
                },
                new InformacionDato
                {
                    Picture = "ar.png",
                    Title = "Se tú la diferencia.",
                    Description = "'Las grandes oportunidades para ayudar a los demás raras veces vienen pero las pequeñas todos los días nos rodean' \n - Sally Koch.",
                    BGColor = "#109dfa    "
                },
                 new InformacionDato
                {
                    Picture = "loto6.png",
                    Title = "Actividad Meditación.",
                    Description = "'Nada libera nuestra grandeza como el deseo de ayudar y de servir' \n - Marianne Williamson",
                    BGColor = "#109dfa    "
                },
                  new InformacionDato
                {
                    Picture = "loto4.png",
                    Title = "Actividad Yoga.",
                    Description = "'La esencia de la vida es servir a los demás y hacer el bien' \n - Aristóteles.",
                    BGColor = "#109dfa    "
                }

            };






        }
    }
}
