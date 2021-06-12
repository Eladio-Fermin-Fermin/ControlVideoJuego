using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using ControlVideoJuego.Entidades;
using ControlVideoJuego.DAL;

namespace ControlVideoJuego.BLL
{
    public class JuegosBLL
    {
        public static bool Existe(string nombre)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Juegos.Any(e => e.Nombre == nombre);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }

        //Funcion Insertar
        private static bool Insertar(Juegos juegos)
        {
            Contexto contexto = new Contexto();
            bool guardado = false;

            try
            {
                contexto.Juegos.Add(juegos);
                guardado = (contexto.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return guardado;
        }

        //Funcion Modificar
        public static bool Modificar(Juegos juegos)
        {
            Contexto contexto = new Contexto();
            bool modificado = false;


            try
            {
                contexto.Entry(juegos).State = EntityState.Modified;
                modificado = (contexto.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return modificado;
        }

        //Funcion Guardar
        public static bool Guardar(Juegos juegos)
        {
            if (!Existe(juegos.Nombre))
                return Insertar(juegos);
            else
                return Modificar(juegos);
        }


        //Funcion Eliminar
        public static bool Eliminar(string nombre)
        {
            Contexto contexto = new Contexto();
            bool eliminado = false;

            try
            {
                var juego = contexto.Juegos.Find(nombre);

                if (juego != null)
                {
                    contexto.Juegos.Remove(juego);
                    eliminado = (contexto.SaveChanges() > 0);
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return eliminado;
        }
        //Funcion Buscar
        public static Juegos Buscar(string nombre)
        {
            Contexto contexto = new Contexto();
            Juegos juegos = new Juegos();

            try
            {
                juegos = contexto.Juegos.Find(nombre);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return juegos;
        }

        //Funcion List
        public static List<Juegos> GetList(Expression<Func<Juegos, bool>> juegos)
        {
            Contexto contexto = new Contexto();
            List<Juegos> Lista = new List<Juegos>();

            try
            {
                Lista = contexto.Juegos.Where(juegos).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return Lista;
        }



        //GET
        public static List<Juegos> GetUsuarios()
        {
            List<Juegos> lista = new List<Juegos>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Juegos.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }


    }
}
