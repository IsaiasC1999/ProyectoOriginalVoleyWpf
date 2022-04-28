using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ProyectoVoleyWpf.Modelo;

namespace ProyectoVoleyWpf.Servicios
{
    class ServiciosLogin : IServiciosLogin
    {
        public bool VerificarLogin(string Usuario, string Contraseña)
        {
            using (var db = new DataContext())
            {
                    
                IQueryable<Administrador> resu = from p in db.Administradores
                                               select p;

                var resultado = resu.Where(x => x.Usuario == Usuario && x.Contraseña == Contraseña);



                if (resultado == null)
                {
                    return false;

                }

                else
                {

                    return true;
                }
            }

        }
    }
}
