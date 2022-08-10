using ProyectoVoleyWpf.Modelo;
using ProyectoVoleyWpf.Modelo.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoVoleyWpf.Servicios
{
    interface IServiciosJugador
    {

        public List<Jugador> BuscarJugadador(string NombreOApellido);

        public void AgregarJugador(Jugador j1);

        public void MostrarJugadorEditar(int id);

        public void EditarJugador(int id, Jugador j1);

        public void MostrarFormularioPago(int id);
        public void Borrar(int id);


        public void ConfirmaPago(Cuota cuota1);
    }
}
