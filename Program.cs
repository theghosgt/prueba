using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ensallo
{
    class Program
    {
        static void Main(string[] args)
        {
            persona objPersona = new persona();
            objPersona.crearPersona("Hamilton", 24, "03-07-1997");

            Console.WriteLine("Nombre: " + objPersona.Nombre + "Edad: " + objPersona.Edad + "Fecha De Nacimiento: " + objPersona.FechaNacimiento);
            Console.ReadLine();

        }
    }
}
