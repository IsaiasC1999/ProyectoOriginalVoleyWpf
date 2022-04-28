using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProyectoVoleyWpf.Modelo
{
    class Jugador
    {

        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Dni { get; set; }
        [Required]
        public string FechaNacimiento { get; set; }
        [Required]
        public string Domicilio { get; set; }
        [Required]
        public string Sexo { get; set; }
        [Required]
        public string Seguro { get; set; }

        public List<Cuota> Cuotas { get; set; }
        
        
    }
}
