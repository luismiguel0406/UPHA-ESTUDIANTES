using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uphaEstudiantes.Models
{
    public class aula
    {
        public int Id_Aula { get; set; }
        public string Numero_Aula { get; set; }
        public int Numero_Estudiantes  { get; set; }
        public bool Estado { get; set; }
    }
}
