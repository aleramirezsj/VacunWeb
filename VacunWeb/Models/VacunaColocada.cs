using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacunWeb.Models
{
    public class VacunaColocada
    {
        public int Id { get; set; }
        public int IdVacuna { get; set; }
        public virtual Vacuna Vacuna { get; set; }
        public int IdPaciente { get; set; }
        public virtual Paciente Paciente { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Fecha { get; set; }
    }
}
