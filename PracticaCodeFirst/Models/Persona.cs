using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PracticaCodeFirst.Models
{
    [Table("Empleado")]
    public class Persona
    {
        public int PersonaId { get; set; }
        [Required]
        [StringLength(15)]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}