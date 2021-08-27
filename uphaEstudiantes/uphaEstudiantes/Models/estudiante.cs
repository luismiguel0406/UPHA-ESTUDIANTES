using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uphaEstudiantes.Models
{
    public class estudiante
    {
        public int Id_Est { get; set; }
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public bool Estado { get; set; }
    }
}
