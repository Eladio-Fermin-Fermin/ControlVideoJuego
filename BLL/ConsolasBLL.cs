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
    public class ConsolasBLL
    {

        
            public static bool Existe(string nombre)
            {
                Contexto contexto = new Contexto();
                bool encontrado = false;

                try
                {
                    encontrado = contexto.Consolas.Any(e => e.Nombre == nombre);
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
            private static bool Insertar(Consolas consolas)
            {
                Contexto contexto = new Contexto();
                bool guardado = false;

                try
                {
                    contexto.Consolas.Add(consolas);
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
            private static bool Modificar(Consolas consolas)
            {
                Contexto contexto = new Contexto();
                bool modificado = false;


                try
                {
                    contexto.Entry(consolas).State = EntityState.Modified;
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
            public static bool Guardar(Consolas consolas)
            {
                if (!Existe(consolas.Nombre))
                    return Insertar(consolas);
                else
                    return Modificar(consolas);
            }


            //Funcion Eliminar
            public static bool Eliminar(string nombre)
            {
                Contexto contexto = new Contexto();
                bool eliminado = false;

                try
                {
                    var consola = contexto.Consolas.Find(nombre);

                    if (consola != null)
                    {
                        contexto.Consolas.Remove(consola);
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
            public static Consolas Buscar(string nombre)
            {
                Contexto contexto = new Contexto();
                Consolas consolas = new Consolas();

                try
                {
                consolas = contexto.Consolas.Find(nombre);

                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    contexto.Dispose();
                }

                return consolas;
            }

            //Funcion List
            public static List<Consolas> GetList(Expression<Func<Consolas, bool>> consolas)
            {
                Contexto contexto = new Contexto();
                List<Consolas> Lista = new List<Consolas>();

                try
                {
                    Lista = contexto.Consolas.Where(consolas).ToList();

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
            public static List<Consolas> GetUsuarios()
            {
                List<Consolas> lista = new List<Consolas>();
                Contexto contexto = new Contexto();

                try
                {
                    lista = contexto.Consolas.ToList();
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







         //###
    }
}
