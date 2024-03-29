﻿using ProyectoVoleyWpf.Servicios;
using ProyectoVoleyWpf.Vista;
using ProyectoVoleyWpf.Vista.MenuVistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace ProyectoVoleyWpf.Controlador
{
    class LoginControlador
    {

        public static Ventana Login = new Ventana();
        public static Menu Menu1 = new Menu();
        private readonly IServiciosLogin servicios = new ServiciosLogin();

        public LoginControlador()
        {


        }
        public LoginControlador( IServiciosLogin serviciosLogin  )
        {

            this.servicios = serviciosLogin;

        }

       

        public void Ingresar( string Usuario ,string Contraseña )
        {

            var resultado = servicios.VerificarLogin(Usuario, Contraseña);

            if(resultado)
            {

                Login.Hide();
                Menu1.Show();

               
            }
            else
            {

                Login.etiError.Visibility = Visibility.Visible;


            }


        } 


    }
}
