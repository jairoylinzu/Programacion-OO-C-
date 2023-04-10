using System;

namespace sistema_academico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola amigos como están");
            Alumno oAlumno = new Alumno();
            oAlumno.Nombre = "Jhon Jairo";
            oAlumno.ApellidoPaterno = "Coronel";
            oAlumno.ApellidoMaterno = "Galarza";
            oAlumno.CodigoAlumno = "0943394361";
            oAlumno.FechaNacimiento = "13 / Junio / 2000";
            oAlumno.Caminar();

            Profesor oProfesor = new Profesor();
            oProfesor.Nombre = "Mercedes Lucia";
            oProfesor.ApellidoPaterno = "Carvajal";
            oProfesor.ApellidoMaterno = "Toral";
            oProfesor.IdProfesor = 10;
            oProfesor.FechaIngreso = "03 / 05 / 2022";
            Console.WriteLine(oProfesor.Nombre);
            oProfesor.PrepararClases();
            oProfesor.PrepararClases("INTEGRALES DEFINIDAS");
            oProfesor.PrepararClases("INTEGRALES INDEFINIDAS", "lA CLASE ESTUVO UN POCO COMPLICADA");

            Nota oNota = new Nota();
            oNota.Nombre = "Pedro Ivan";
            oNota.ApellidoPaterno = "Chauca";
            oNota.ApellidoMaterno = "Ojedis";
            oNota.Id = 60;
            oNota.NotaLeccion = 10;
            oNota.NotaExamen = 7;
            oNota.GuardarNota();
            oNota.ActualizarNota();
            oNota.EliminarNota();










        }

    }
}
