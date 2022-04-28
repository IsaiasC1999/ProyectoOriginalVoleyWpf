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
using ProyectoVoleyWpf.Controlador;
using ProyectoVoleyWpf.Modelo;

namespace ProyectoVoleyWpf.Vista.MenuVistas
{
    /// <summary>
    /// Lógica de interacción para FormularioJugadores.xaml
    /// </summary>
    public partial class FormularioJugadores : Window
    {
        public FormularioJugadores()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
           
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            var Controlador = new MenuControlador();


            var j1 = new Jugador();
            j1.Nombre = txbNombre.Text;
            j1.Apellido = txbApellido.Text;
            j1.Dni = txbDni.Text;
            j1.FechaNacimiento = dpFechaNacimiento.SelectedDate.ToString();
            j1.Domicilio = txbDomicilio.Text;
            j1.Sexo = Sexo();
            j1.Seguro = Seguro();


            Controlador.agregar(j1);

            txbNombre.Text = "";
            txbApellido.Text = "";
            txbDni.Text = "";
            txbDomicilio.Text = "";
            rbSeguroNO.IsChecked = false;
            rbSeguroSI.IsChecked = false;
            rbSexoF.IsChecked = false;
            rbSexoM.IsChecked = false;

            

        }

        private string Seguro()
        {
            if (rbSeguroSI.IsChecked == true)
            {
                return "Tiene Seguro";
            }

            return "No tiene seguro";
        }

        private string Sexo ()
        {

            if (rbSexoM.IsChecked == true)
            {
                return "Masculino";
            }
             return "Femenino";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var cambiosJugador = new Jugador();


            cambiosJugador.Nombre = txbNombre.Text;
            cambiosJugador.Apellido = txbApellido.Text;
            cambiosJugador.Dni = txbDni.Text;
            cambiosJugador.FechaNacimiento = dpFechaNacimiento.SelectedDate.ToString();
            cambiosJugador.Domicilio = txbDomicilio.Text;
            cambiosJugador.Sexo = Sexo();
            cambiosJugador.Seguro = Seguro();

            int id = Convert.ToInt32(etiId.Content);

            var Controlador = new MenuControlador();

            Controlador.EditarJugador(id,cambiosJugador);


            txbNombre.Text = "";
            txbApellido.Text = "";
            txbDni.Text = "";
            txbDomicilio.Text = "";
            rbSeguroNO.IsChecked = false;
            rbSeguroSI.IsChecked = false;
            rbSexoF.IsChecked = false;
            rbSexoM.IsChecked = false;


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
