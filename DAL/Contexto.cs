using Microsoft.EntityFrameworkCore;
using ControlVideoJuego.Entidades;

namespace ControlVideoJuego.DAL
{
    public class Contexto : DbContext
    {

        //*********************************************Registro de Juegos *********************************

        public DbSet<Juegos> Juegos { get; set; }


        //*********************************************Registro de Consola *********************************


        public DbSet<Consolas> Consolas { get; set; }

   


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data/ControlDeJuegos.db");
        }





    }
}
