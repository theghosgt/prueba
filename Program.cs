using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ensayo
{
    class Program
    {
        static void Main(string[] args)
        {
            persona objPersona = new persona();
            	objPersona.crearPersona("Hoarri", 24, "03-07-1997");
		        objPersona.crearPersona("Andres", 27, "03-07-1994");
		        objPersona.crearPersona("Oscar", 21, "26-09-2000");
            Console.WriteLine("Nombre: " + objPersona.Nombre + "Edad: " + objPersona.Edad + "Fecha De Nacimiento: " + objPersona.FechaNacimiento);
            Console.ReadLine();

        }
    }
}
