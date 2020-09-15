using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea10
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            switch (nombre)
            {
                case "martin":
                    Console.WriteLine("Hola");
                    break;
                case "Martin":
                    Console.WriteLine("Hola");
                    break;
                case "Martín":
                    Console.WriteLine("Hola");
                    break;
                default:
                    Console.WriteLine("No te conozco");
                    break;
            }
            Console.ReadKey();
        }
    }
}
