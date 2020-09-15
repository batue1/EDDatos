using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea8
{
    class Program
    {
        static void Main(string[] args)
        {
            string letra;

            Console.WriteLine("Escriba una letra: ");
            letra = Console.ReadLine();
            switch (letra)
            {
                case "a":
                    Console.WriteLine("Ha ingresado la vocal a.");
                    break;
                case "e":
                    Console.WriteLine("Ha ingresado la vocal e.");
                    break;
                case "i":
                    Console.WriteLine("Ha ingresado la vocal i.");
                    break;
                case "o":
                    Console.WriteLine("Ha ingresado la vocal o.");
                    break;
                case "u":
                    Console.WriteLine("Ha ingresado la vocal u.");
                    break;
                case "A":
                    Console.WriteLine("Ha ingresado la vocal A.");
                    break;
                case "E":
                    Console.WriteLine("Ha ingresado la vocal E.");
                    break;
                case "I":
                    Console.WriteLine("Ha ingresado la vocal I.");
                    break;
                case "O":
                    Console.WriteLine("Ha ingresado la vocal O.");
                    break;
                case "U":
                    Console.WriteLine("Ha ingresado la vocal U.");
                    break;
                default:
                    Console.WriteLine("Ha ingresado la letra consonante "+letra);
                    break;
            }
            Console.ReadLine();
        }
    }
}
