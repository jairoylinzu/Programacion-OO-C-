using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_academico
{
    public class Asignatura: Matricula
    {
        public string Sigla { get; set; }
        public string Nombre { get; set; }

        public string Curso { get; set; }
    }
}


