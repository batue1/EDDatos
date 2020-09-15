using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            Console.WriteLine("Ingrese su nombre por favor");
            nombre = Console.ReadLine();

            if(nombre == "Martin")
            {
                Console.WriteLine("Hola Martin");
            }
            else
            {
                Console.WriteLine("No te conozco");
            }
        }
    }
}
