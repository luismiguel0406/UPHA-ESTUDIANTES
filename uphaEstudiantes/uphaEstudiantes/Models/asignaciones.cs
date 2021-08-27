using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uphaEstudiantes.Models
{
    public class asignaciones
    {
        public int Id_Asignacion { get; set; }
        public int Estudiante { get; set; }
        public int Profesor { get; set; }
        public int Aula { get; set; }
        public int Asignatura { get; set; }
        public bool Estado { get; set; }
    }
}
