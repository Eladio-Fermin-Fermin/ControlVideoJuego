using System;
using System.ComponentModel.DataAnnotations;

namespace ControlVideoJuego.Entidades
{
    public class Juegos
    {

      [Key]

        public int JuegoId { get; set; }
        public string Nombre { get; set; }
        public string Fabricante { get; set; }
        public string Plataforma { get; set; }
        public double PrecioRenta { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Categoria { get; set; }
        public  double PrecioVenta { get; set; }

    }
}

