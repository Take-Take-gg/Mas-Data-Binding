using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mas_Data_Binding
{
    class Empleado
    {
        public string Nombre { get; set; }
        public string Titulo { get; set; }

        public static Empleado GetEmpleado()
        {
            var emp = new Empleado()
            {
                Nombre = "El Take Take", Titulo = "hola que hace"
            };

            return emp;
        }
            
    }
}
