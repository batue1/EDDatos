using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defino e inicializo variables.
            int number = 1;
            bool exit = false;
            // Bucle infinito que produce números enteros positivos a partir del 1.

            while (exit == false) 
            {
                Console.WriteLine(number);
                number++;
            }
        }
    }
}
