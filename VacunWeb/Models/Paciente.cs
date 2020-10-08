using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacunWeb.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public int Dni { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        public string Sexo { get; set; }
        public bool Prematuro { get; set; }
        [Required]
        public double Peso { get; set; }
        [Required]
        public string Domicilio { get; set; }
        [Required]
        public int IdTutor { get; set; }
        public virtual Tutor Tutor { get; set; }
        public int IdCalendario { get; set; }
        public virtual Calendario Calendario { get; set; }

    }
}
