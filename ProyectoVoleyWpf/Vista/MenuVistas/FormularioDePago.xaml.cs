using ProyectoVoleyWpf.Controlador;
using ProyectoVoleyWpf.Modelo;
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

namespace ProyectoVoleyWpf.Vista.MenuVistas
{
    /// <summary>
    /// Lógica de interacción para FormularioDePago.xaml
    /// </summary>
    public partial class FormularioDePago : Window
    {
        public FormularioDePago()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnGuardarPago_Click(object sender, RoutedEventArgs e)
        {

            var cuota1 = new Cuota();

            
            cuota1.IdJugador = int.Parse(etiId.Content.ToString());
            cuota1.Monto = int.Parse(txbMonto.Text);
            cuota1.FechaDePago = dtFechaPago.SelectedDate.ToString();

            var accciones = new MenuControlador();

            accciones.ConfirmacionDePago(cuota1);


            this.Close();

        }
    }
}
