using ProyectoVoleyWpf.Vista.MenuVistas;
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

namespace ProyectoVoleyWpf.Vista
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
            MostrarVistas.Content = MenuControlador.VistaInicio;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MostrarVistas.Content = MenuControlador.VistaInicio;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MostrarVistas.Content = MenuControlador.VistaJugadores;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MostrarVistas.Content = MenuControlador.VistaCuota;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MostrarVistas.Content = MenuControlador.VistaUtilidades;
        }
    }
}
