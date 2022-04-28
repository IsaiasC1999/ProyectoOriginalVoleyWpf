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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ProyectoVoleyWpf.Controlador;
using ProyectoVoleyWpf.Modelo;
using System.Linq;

namespace ProyectoVoleyWpf.Vista.MenuVistas
{
    /// <summary>
    /// Lógica de interacción para Jugadores.xaml
    /// </summary>
    public partial class Jugadores : Page
    {
        public Jugadores()
        {
            InitializeComponent();

            Refresh();
           
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            var acciones = new MenuControlador();

            acciones.Buscar(txbBuscar.Text);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {

            var form = new FormularioJugadores();
            form.ShowDialog();

        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {

            Jugador j1 = new Jugador();

            j1 = (Jugador)dgvJugadores.SelectedItem;


            if (j1 == null)
            {

                

                MessageBox.Show("Se debe elegir algun registro ");

            }
            else
            {
                int id = j1.Id;
                var acciones = new MenuControlador();
                acciones.MostrarJugadorEditar(id);

            }






         }


        


       

        private void dgvJugadores_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

        }

        public void Refresh()
        {

            using (var db = new DataContext())
            {

                List<Jugador> juga = new List<Jugador>();
                juga = db.Jugadores.ToList();

                dgvJugadores.ItemsSource = juga ;
                

            }

        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {

            Jugador j1 = new Jugador();

            j1 = (Jugador)dgvJugadores.SelectedItem;


            if (j1 == null)
            {

               

                MessageBox.Show("Se debe elegir algun registro ");

            }
            else
            {
                int id = j1.Id;
                var acciones = new MenuControlador();
                acciones.EliminarJugador(id);

            }

            Refresh();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }
    }
}
