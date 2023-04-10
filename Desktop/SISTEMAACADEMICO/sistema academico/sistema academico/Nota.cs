using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_academico
{
    public  class Nota : Alumno
    {
        public int Puntaje { get; set; }
        public string Asignatura { get; set; }

        public int NotaLeccion { get; set; }

        public int NotaExamen { get; set; }

        public void GuardarNota()
        {
            Console.WriteLine("Las notas se guardaron correctamente en el sistema");
        }
        public void ActualizarNota()
        {
            Console.WriteLine("Las notas han sido actulizadas correctamente");
        }

        public void EliminarNota()
        {
            Console.WriteLine("Las notas que estaban mal en el sistema fueron eliminadas para que no haya problemas");
        }


       


    }
}
