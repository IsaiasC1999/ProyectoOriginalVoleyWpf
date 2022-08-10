using ProyectoVoleyWpf.Controlador;
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

namespace ProyectoVoleyWpf
{
    /// <summary>
    /// Lógica de interacción para Ventana.xaml
    /// </summary>
    public partial class Ventana : Window
    {
        public Ventana()
        {
            InitializeComponent();


        }

       
        
        


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var admistradosLogin = new LoginControlador();
            
            admistradosLogin.Ingresar(txbUsuario.Text, txbContraseña.Password.ToString());
            txbUsuario.Text = "";
            txbContraseña.Clear();


        }

        private void etiError_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void txbUsuario_TouchEnter(object sender, TouchEventArgs e)
        {


        }

        private void txbUsuario_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (txbUsuario.Text != "")
            {

                etiError.Visibility = Visibility.Hidden;

            }
        }
    }
}
