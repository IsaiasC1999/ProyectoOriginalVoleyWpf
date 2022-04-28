using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProyectoVoleyWpf.Modelo
{
    class Cuota
    {

        public int Id { get; set; }
        [Required]
        public string FechaDePago { get; set; }
        [Required]
        public int IdJugador { get; set; }
        [Required]
        public Jugador Jugador { get; set; }

    }
}
