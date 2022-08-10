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
using Microsoft.Data.Sqlite;

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

            int a = txbBuscar.Text.Length;

            string contenido = txbBuscar.Text;

            if (a > 0)
            {



                using (var db = new DataContext())
                {



                    var resu = from d in db.Jugadores
                               select d;


                    var primera = contenido.First();

                    var primeraConMayu = contenido.ToUpper().First();



                    if (primera == primeraConMayu)
                    {

                        var resultado = resu.Where(x => x.Nombre.StartsWith(contenido));

                        dgvJugadores.ItemsSource = resultado.ToList();
                    }

                    else
                    {
                        var resul = resu.Where(x => x.Nombre.StartsWith(primeraConMayu.ToString()));

                        var resultado = resu.Where(x => x.Nombre.StartsWith(contenido));

                        dgvJugadores.ItemsSource = resultado.Concat(resul).ToList();
                    }








                }


            }
            else
            {

                using (var db = new DataContext())
                {

                    var resu = db.Jugadores.ToList();

                    dgvJugadores.ItemsSource = resu;


                }


            }




        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {

            var form = new FormularioJugadores();
            form.btnActulizar.Visibility = Visibility.Hidden;

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

        private void btnRegistrarCuota_Click(object sender, RoutedEventArgs e)
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

                acciones.FormularioPagoJugador(id);


            }

        }

        private void ocultar()
        {

            dgvJugadores.Columns[0].Visibility = Visibility.Hidden;
        
        }

        private void dgvJugadores_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            switch (e.Column.Header.ToString())
            {
                case "Id":
                    e.Column.Visibility = Visibility.Hidden;
                    break;


                case "Cuotas":
                    e.Column.Visibility = Visibility.Hidden;
                    break;
            }
        }
    }
}
