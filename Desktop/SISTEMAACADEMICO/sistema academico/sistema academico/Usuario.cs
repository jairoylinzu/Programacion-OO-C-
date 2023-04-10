using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_academico
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string ApellidoPaterno { get; set; }

        public string ApellidoMaterno { get; set; }

        public void Caminar()
        {
            Console.WriteLine("El usuario está caminando");
        }
        public void Correr()
        {
            Console.WriteLine("El usuario está corriendo");
        }

        public void Detener()
        {
            Console.WriteLine("El usuario se detuvo ");
        }



    }
}
