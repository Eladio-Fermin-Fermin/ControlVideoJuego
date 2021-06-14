using System;
using System.ComponentModel.DataAnnotations;

namespace ControlVideoJuego.Entidades
{
   public class Consolas
    {

       [Key]

        public int ConsolaId { get; set; }
        public string Nombre { get; set; }

        public string Fabricante { get; set; }

        public double PrecioRenta { get; set; }

        public double Version { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        public double PrecioVenta { get; set; }

        public double Almacenamiento { get; set; }


    }
}
