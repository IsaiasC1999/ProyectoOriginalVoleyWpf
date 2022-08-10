using ProyectoVoleyWpf.Controlador;
using ProyectoVoleyWpf.Modelo;
using ProyectoVoleyWpf.Modelo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace ProyectoVoleyWpf.Vista.MenuVistas
{
    /// <summary>
    /// Lógica de interacción para CuotaPage.xaml
    /// </summary>
    public partial class CuotaPage : Page
    {
        public CuotaPage()
        {
            InitializeComponent();


            using (var db = new DataContext())
            {

                dgvJugadoresPage.ItemsSource = db.Jugadores.ToList();

            }
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {


            var acciones = new MenuControlador();

            acciones.BuscarJugadorCuotas(txbBuscarCuota.Text);

        }

        private void seleccion(object sender, SelectedCellsChangedEventArgs e)
        {
            using ( var db = new DataContext())
            {


                
                var juga = (Jugador) dgvJugadoresPage.SelectedItem;

                if(juga != null)
                {
                    var resu = db.Cuotas.Where(x => x.IdJugador == juga.Id).ToList();
                    dgvCuotas.ItemsSource = resu;
                }

                else
                {

                    dgvCuotas.ItemsSource = null;
                }



            }
        }

        private void BusquedaTiempoReal(object sender, TextChangedEventArgs e)
        {

           

                int a = txbBuscarCuota.Text.Length;

                string contenido = txbBuscarCuota.Text;

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

                            dgvJugadoresPage.ItemsSource = resultado.ToList();
                        }

                        else
                        {
                            var resul = resu.Where(x => x.Nombre.StartsWith(primeraConMayu.ToString()));

                            var resultado = resu.Where(x => x.Nombre.StartsWith(contenido));

                            dgvJugadoresPage.ItemsSource = resultado.Concat(resul).ToList();
                        }








                    }


                }
                else
                {

                    using (var db = new DataContext())
                    {

                        var resu = db.Jugadores.ToList();

                        dgvJugadoresPage.ItemsSource = resu;


                    }


                }




            }

        private void dgvJugadoresPage_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            switch (e.Column.Header.ToString())
            {
                case "Id":
                    e.Column.Visibility = Visibility.Hidden;
                    break;
            }
        }
    }
}
  

