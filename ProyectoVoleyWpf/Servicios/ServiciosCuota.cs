using ProyectoVoleyWpf.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ProyectoVoleyWpf.Modelo.ViewModels;

namespace ProyectoVoleyWpf.Servicios
{
    class ServiciosCuota :IServiciosCuota
    {




        public List<JugadorViewModel> BuscarJugador(string NombreApellido)
        {
            using (var Db = new DataContext())
            {
                var resu = from P in Db.Jugadores
                           select P;


                var resultado = resu.Where(x => x.Apellido == NombreApellido || x.Nombre == NombreApellido).Select(x =>

                new JugadorViewModel
                {
                    Id = x.Id,
                    Nombre = x.Nombre,
                    Apellido = x.Apellido

                }

                ); ;

                return resultado.ToList();

            }
        }


        public void BuscarCuotas()
        {

            using ( var db = new DataContext())
            {




            }



        }

       
    }
}
