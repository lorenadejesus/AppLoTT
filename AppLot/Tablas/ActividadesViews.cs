using System;
using System.Collections.ObjectModel;
using System.Drawing;
using AppLot.Datos;
using System.ComponentModel;

namespace AppLot.Tablas
{
    public class ActividadesViews
    {
        public ObservableCollection<Actividades>  Actividades { get; set; }

        public ActividadesViews()
        {
            Actividades = new ObservableCollection<Actividades>
            {
                new Actividades
                {
                    Picture = "loto4.png",
                    Title = "Actividad Yoga.",
                    Description = "'Doctrina filosófica hindú que se basa en una serie de ejercicios espitituales y fisicos para liberar las tensiones del cuerpo.' \n \nHorario de actividad \n " +
                    "Lunes  y Miercoles de 7:00 pm a 8:00 pm \n Martes y Jueves de 8:30 am a 9:30 am ",
                    BGColor = "#FFFFFF"
                },

                new Actividades
                {
                       Picture = "def.png",
                    Title = "Defensa Personal infantil",
                    Description = "'Conjunto de habilidades técnico- tacticas encaminadas a impedir o repeler una agresión  realizadas por uno mismo y para sí mismo.'\n \nHorario de actividad \n " +
                    "Martes y Jueves de 4:30 pm a 6:30 pm",
                    BGColor = "#FFFFFF"
                },

                new Actividades
                {
                      Picture = "tej.png",
                    Title = "Tejido",
                    Description = "'Actividad de elaborar manualidades a través de tejidos y bordados de tela e hilo.'\n \nHorarios de actividad\n" +
                    "Martes 9:30 am a 10:30 am ",
                    BGColor = "#FFFFFF"
                },

                new Actividades
                {
                       Picture = "me.png",
                    Title = "Meditación",
                    Description = "'Pensamiento o consideración de algo con atención y detenimiento para estudiarlo o comprenderlo bien.'\n \nHorarios de actividad\n" +
                    "Martes 11:00 am a 12:00 pm",
                    BGColor = "#FFFFFF    "
                },

                new Actividades
                {
                     Picture = "re.png",
                    Title = "Reciclado",
                    Description = "'Proceso cuyo objetivo es elaborar manualidades a partir de productos ya creados.'\n \nHorarios de actividad\n" +
                    "Jueves 10:00 am a 11:00 am",
                    BGColor = "#FFFFFF    "
                },

                new Actividades
                {
                     Picture = "tan.png",
                    Title = "Tanatología",
                    Description = "'Disciplina integral que aborda todo lo relacionado con el fenomeno de la muerte en el ser humano: la pérdida, el sufrimiento psicológico y las relaciones significativas del enfermo.'\n \nHorarios de actividad\n" +
                    "Jueves 10:00 am a 11:00 am",
                    BGColor = "#FFFFFF    "
                },

                new Actividades
                {
                    Picture = "pit.png",
                    Title = "Pintura y Repujado",
                    Description = "'Técnica artesanal que consiste en trabajar planchas de metal, cuero u otros materiales maleables, para obtener una figura ornamental en relieve.'\n \nHorarios de actividad\n" +
                    "Jueves 11:30 am a 1:30 pm",
                    BGColor = "#FFFFFF"
                },

                    new Actividades
                {
                    Picture = "bai.png",
                    Title = "Baile",
                    Description = "'La danza o el baile es un arte donde se utiliza el movimiento del cuerpo usualmente con música, como una forma de expresión y de interacción social, con fines de entretenimiento, artísticos o religiosos.'\n \nHorarios de actividad\n" +
                    "Viernes 8:00 am a 9:30 am",
                    BGColor = "#FFFFFF"
                },


                    new Actividades
                {
                    Picture = "comp.png",
                    Title = "Computación",
                    Description = "'Ciencía encargada de elaboración y desarrollo de lógica a partir de actividades guiadas.'\n \nHorarios de actividad\n" +
                    "Viernes 11:00 am a 12:00 pm",
                    BGColor = "#FFFFFF"
                }

            };
        }


    }
}
