using ProyectoVoleyWpf.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ProyectoVoleyWpf.Vista.MenuVistas;
using ProyectoVoleyWpf.Modelo.ViewModels;
using System.Windows;

namespace ProyectoVoleyWpf.Servicios
{
    class ServiciosJugador : IServiciosJugador
    {
        public void AgregarJugador(Jugador j1)
        {
            using (var Db = new DataContext())
            {

                Db.Jugadores.Add(j1);
                Db.SaveChanges();

            }
        }

        public List<Jugador> BuscarJugadador(string NombreOApellido)
        {
            using (var Db = new DataContext())
            {
                var resu = from P in Db.Jugadores 
                           select P;


                var resultado = resu.Where(x => x.Apellido == NombreOApellido || x.Nombre == NombreOApellido);

                return resultado.ToList();

            }
        }


        public void MostrarJugadorEditar(int id)
        {

            using(var db = new DataContext())
            {

                var j1 = db.Jugadores.Find(id);

                var form = new FormularioJugadores();

                form.etiId.Content = j1.Id.ToString();
                form.txbNombre.Text = j1.Nombre;
                form.txbApellido.Text = j1.Apellido;
                form.txbDni.Text = j1.Dni;
                form.dpFechaNacimiento.SelectedDate = Convert.ToDateTime(j1.FechaNacimiento);
                form.txbDomicilio.Text = j1.Domicilio;
                form.btnGuardar.Visibility = System.Windows.Visibility.Hidden;


                if(j1.Sexo == "Masculino") form.rbSexoM.IsChecked = true;
                    
                else form.rbSexoF.IsChecked = true;

                if (j1.Seguro == "Si") form.rbSeguroSI.IsChecked = true;
                else form.rbSeguroNO.IsChecked = true;

                 form.Show();

                form.btnGuardar.Visibility = System.Windows.Visibility.Collapsed;

                

            }

        }


        public void EditarJugador(int id , Jugador JugadorCambios)
        {
            using ( var db = new DataContext() )
            {
                var jugadorEditar=  db.Jugadores.Find(id);


                jugadorEditar.Nombre = JugadorCambios.Nombre;
                jugadorEditar.Apellido = JugadorCambios.Apellido;
                jugadorEditar.Dni = JugadorCambios.Dni;
                jugadorEditar.FechaNacimiento = JugadorCambios.FechaNacimiento;
                jugadorEditar.Domicilio = JugadorCambios.Domicilio;
                jugadorEditar.Sexo = JugadorCambios.Sexo;
                jugadorEditar.Seguro = JugadorCambios.Seguro;

                db.SaveChanges();

                


            }


        }

        public void Borrar(int id)
        {
           using(var db = new DataContext())
            {

                

                var j1 =db.Jugadores.Find(id);

                db.Jugadores.Remove(j1);

                db.SaveChanges();
                

            }

        }


        public void MostrarFormularioPago(int id)
        {

            using (var db = new DataContext())
            {

                var j1 = db.Jugadores.Find(id);

                var formPago = new FormularioDePago();

                formPago.etiNombre.Content = j1.Nombre + " " + j1.Apellido;
                formPago.etiId.Content = j1.Id.ToString();
                formPago.Show();


            }

        }

        public void ConfirmaPago(Cuota cuota1)
        {
            using ( var db = new DataContext())
            {

                db.Cuotas.Add(cuota1);

                db.SaveChanges();
                  

            }
        }
    }
}
