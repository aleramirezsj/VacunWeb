using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VacunWeb.Models
{
    public class DetalleCalendario
    {
        public int Id { get; set; }
        public int IdCalendario { get; set; }
        public virtual Calendario Calendario { get; set; }
        public int IdVacuna { get; set; }
        public virtual Vacuna Vacuna { get; set; }
    }
}
