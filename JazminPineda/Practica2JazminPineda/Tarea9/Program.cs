using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea9
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string clave1;
            string clave2;
            Console.WriteLine("Escriba su nombre ");
            nombre = Console.ReadLine();
            Console.WriteLine("Escriba su contraseña ");
            clave1 = Console.ReadLine();
            Console.WriteLine("Escriba nuevamente su contraseña ");
            clave2 = Console.ReadLine();

            while (clave1 != clave2)
            {
                Console.WriteLine("las contraseñas no son iguales");
                Console.WriteLine("Escriba su contraseña ");
                clave1 = Console.ReadLine();
                Console.WriteLine("Escriba nuevamente su contraseña ");
                clave2 = Console.ReadLine();
            }
            
            Console.WriteLine("Bienvenido ");
            Console.ReadLine();
        }
    }
}
