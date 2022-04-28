using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ProyectoVoleyWpf.Vista.MenuVistas;
using ProyectoVoleyWpf.Modelo;


namespace ProyectoVoleyWpf.Servicios
{
    class ServiciosMenu : IServiciosMenu
    {
        public List<Jugador> Buscar(string NombreOApellido)
        {
            using(DataContext db = new DataContext())
            {

                var resu = (from p in db.Jugadores
                            where p.Nombre == NombreOApellido || p.Apellido == NombreOApellido
                            select p).ToList();

                return resu;
            }
        }

        public List<Jugador> Listar()
        {
            using DataContext db = new DataContext();

            var lista = db.Jugadores.ToList();

            return lista;
        }
    }
}
