using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_academico
{
    public class Profesor : Usuario
    {
        public int IdProfesor { get; set; }
        public string FechaIngreso { get; set; }

        public void PrepararClases()
        {
            Console.WriteLine("El profesor se preparó con anticipación para dar la clase");
        }

        public void PrepararClases(string Clase)
        {
            Console.WriteLine($"El profesor esta dando la clase {Clase}" );
        }

        public void PrepararClases(string Clase, string Detalle)
        {
            Console.WriteLine($"El profesor esta dando la clases del tema , {Clase} y {Detalle} ");
        }
        public void MotivarEstudiantes()
        {
            Console.WriteLine("El profesor motiva a los alumnos hacer mejores cada día");
        }

        public void MotivarEstudiantes( int Atencion)
        {
            Console.WriteLine($"El profesor al finalizar una clase les explica a los alumnos que no entieron la clase en un tiempo de  {Atencion} minutos" );

        }

        public void MotivarEstudiantes(int Atencion, string ResumenClase )
        {
            Console.WriteLine($"El prodfesor al finalizar la clase si no se entiendo les explica {Atencion} y en la siguiente clase {ResumenClase} ");
        }

        public void ControlarClases()
        {
            Console.WriteLine("El profesor tiene completo control sobre la clase que está impartiendo");
        }

        public void TomarLecciones()
        {
            Console.WriteLine("El profesor evalua a los estudiantes cada semana para saber si estan aprendiendo");
        }

        public void TomarExamenes()
        {
            Console.WriteLine("El profesor Al finalizar cada parcial tomar un examen para evaluar los conocimiento de los alumnos");
        }



        public void Promedio()
        {
            Console.WriteLine("El profesor al finalizar los dos parciales saca un promedio para saber si el estudiante aprobó la materia");
        }


    }


}
