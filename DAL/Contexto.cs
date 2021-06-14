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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Usuarios>().HasData(new Usuarios
            {
                UsuarioId = 1,
                Nombre = "Raldy",
                Apellido = "Lopez",
                Fecha = new DateTime(2020, 11, 22),
                NombreUsuario = "Admin",
                Clave = "5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5",
            }); // Calve 12345*/


            //------------------Colores--------------------
            modelBuilder.Entity<Juegos>().HasData(new Juegos { Tipo = "Accion" });
            modelBuilder.Entity<Juegos>().HasData(new Juegos { Tipo = "Aventura" });
            modelBuilder.Entity<Juegos>().HasData(new Juegos { Tipo = "Arcade" });
            modelBuilder.Entity<Juegos>().HasData(new Juegos { Tipo = "Estrategia" });

        }
    }
}
