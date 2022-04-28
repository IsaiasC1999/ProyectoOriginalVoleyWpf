using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ProyectoVoleyWpf.Modelo;
using ProyectoVoleyWpf.Servicios;
using ProyectoVoleyWpf.Vista.MenuVistas;
using System.Windows;

namespace ProyectoVoleyWpf.Controlador
{
    class MenuControlador
    {
        private readonly IServiciosMenu serviciosMenu = new ServiciosMenu();
        private readonly IServiciosJugador serviciosJugador = new ServiciosJugador();
        
        public static Jugadores VistaJugadores = new Jugadores();
        public static Inicio VistaInicio = new Inicio();
        public static CuotaPage VistaCuota = new CuotaPage();
       

        #region MetodosVistaJugador

        public void Buscar(string JugadorAbsucar)
        {

            var resu = serviciosJugador.BuscarJugadador(JugadorAbsucar);
            if (resu != null)
            {
                
                VistaJugadores.dgvJugadores.ItemsSource = resu;
                VistaJugadores.dgvJugadores.Columns[8].Visibility = Visibility.Hidden;
               
              
            }
            

        }

       

        public void agregar(Jugador j1)
        {
           serviciosJugador.AgregarJugador(j1);
        }


        public void MostrarJugadorEditar(int id)
        {
            serviciosJugador.MostrarJugadorEditar(id);

           
        }

        public void EditarJugador( int id , Jugador jugadorCambios)
        {

            serviciosJugador.EditarJugador(id, jugadorCambios);


        }

        public void EliminarJugador(int id)
        {


            serviciosJugador.Borrar(id);

        }

        #endregion 


    }
}
