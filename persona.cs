using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ensallo
{
    public class persona
    {
        private string nombre;
        private int edad;
        private string fechaNacimiento;

        public string Nombre { get => nombre; set => nombre = value; }//metodo
        public int Edad { get => edad; set => edad = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }//metodo

        public void crearPersona(string _nombre,int _edad, string _fechaNacimiento)
        {
            nombre = _nombre;
            this.edad = _edad;
            fechaNacimiento = _fechaNacimiento;
        }
    }
}
