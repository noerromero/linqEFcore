using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace linq.Models
{
    [Table("Estudiante",Schema ="Pruebas")]
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaNacimiento { get; set; }

    }
}
