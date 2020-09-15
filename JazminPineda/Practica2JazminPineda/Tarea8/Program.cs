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
            string letra = "";
            Console.WriteLine("Escriba una letra ");
            letra = Console.ReadLine();
            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
            {
                Console.WriteLine("Es una vocal ");
            }
            else
                Console.WriteLine("No es una vocal");
            Console.ReadLine();
        }
    }
}
