using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ControlVideoJuego.Entidades;
using ControlVideoJuego.BLL;


namespace ControlVideoJuego.UI.Registo
{
    /// <summary>
    /// Interaction logic for rJuegos.xaml
    /// </summary>
    public partial class rJuegos : Window
    {
        Juegos juegos = new Juegos();
        //No se sabe lo que hace pero si lo quita no funciona.
        public rJuegos()
        {
            InitializeComponent();
            this.DataContext = juegos;

        }

        //LIMPIAR
        private void Limpiar()
        {
            this.juegos = new Juegos();
            this.DataContext = juegos;
        }



        //VALIDAR
        private bool Validar()
        {
            bool esValido = true;


            if (NombreTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Transacción Fallida", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (!int.TryParse(NombreTextBox.Text, out int Nombre))
            {
                esValido = false;
                MessageBox.Show("Este Id no es valido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (!double.TryParse(FabricanteTextBox.Text, out double Fabricante))
            {
                esValido = false;
                MessageBox.Show("Este Telefono no es valido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (!double.TryParse(PlataformaTextBox.Text, out double Plataforma))
            {
                esValido = false;
                MessageBox.Show("Este Celular no es valido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (!double.TryParse(PrecioRentaTextBox.Text, out double PrecioRenta))
            {
                esValido = false;
                MessageBox.Show("Este Celular no es valido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (!double.TryParse(TipoComboBox.Text, out double Tipo))
            {
                esValido = false;
                MessageBox.Show("Este Celular no es valido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (!double.TryParse(CategoriaTextBox.Text, out double Categoria))
            {
                esValido = false;
                MessageBox.Show("Este Celular no es valido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (!double.TryParse(PrecioVentaTextBox.Text, out double PrecioVenta))
            {
                esValido = false;
                MessageBox.Show("Este Celular no es valido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            return esValido;
        }



        //BOTON BUSCAR *************************************************************************
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var juego = JuegosBLL.Buscar(Utilidades.ToString(NombreTextBox.Text));
            if (juego != null)
                this.juegos = juego;
            else
                this.juegos = new Juegos();

            this.DataContext = this.juegos;
        }


        //BOTON NUEVO *************************************************************************
        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }


        //BOTO GUARDAR **************************************************************************
        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {

            {
                if (!Validar())
                    return;

                var paso = JuegosBLL.Guardar(juegos);
                if (paso)
                {
                    Limpiar();
                    MessageBox.Show("Transacción Exitosa", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("Transacción Fallida", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }

        private void ModificarButton_Click(object sender, RoutedEventArgs e)
        {

            {
                if (!Validar())
                    return;

                var paso = JuegosBLL.Modificar(juegos);
                if (paso)
                {
                    Limpiar();
                    MessageBox.Show("Su modificación a sido Exitosa", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("No se a podido modificar ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }
        //BOTON ELIMINAR *************************************************************************
        /* private void EliminarButton_Click(object sender, RoutedEventArgs e)
         {
             {
                 if (JuegosBLL.Eliminar(Utilidades.ToInt(NombreTextBox.Text)))
                 {
                     Limpiar();
                     MessageBox.Show("Registro Eliminado!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                 }
                 else
                     MessageBox.Show("No fue posible eliminar", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
             }
         }*/




    }
}
