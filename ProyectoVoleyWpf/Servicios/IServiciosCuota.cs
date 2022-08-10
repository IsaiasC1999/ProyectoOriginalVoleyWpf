using ProyectoVoleyWpf.Modelo.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoVoleyWpf.Servicios
{
    interface IServiciosCuota
    {

        public List<JugadorViewModel> BuscarJugador(string NombreApellido);
    }
}
