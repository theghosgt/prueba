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
            objPersona.crearPersona("Harri", 27, "03-07-1994");
			objPersona.crearPersona("Andres", 27, "03-07-1994");
            Console.WriteLine("Nombre: " + objPersona.Nombre + "Edad: " + objPersona.Edad + "Fecha De Nacimiento: " + objPersona.FechaNacimiento);
            Console.ReadLine();

        }
    }
}
