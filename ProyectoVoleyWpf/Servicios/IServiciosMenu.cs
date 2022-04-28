using ProyectoVoleyWpf.Modelo;
using ProyectoVoleyWpf.Vista.MenuVistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoVoleyWpf.Servicios
{
    interface IServiciosMenu
    {


       
        public List<Jugador> Buscar(string NombreOApellido);


    }
}
