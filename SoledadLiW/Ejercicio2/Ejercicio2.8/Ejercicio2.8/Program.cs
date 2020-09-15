using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Char letra;
            Console.WriteLine("Ingrese una leta: ");
            letra = Convert.ToChar(Console.ReadLine());

            switch (letra)
            {
                case 'a':
                    Console.WriteLine("Es vocal");
                    break;
                case 'e':
                    Console.WriteLine("Es vocal");
                    break;
                case 'i':
                    Console.WriteLine("Es vocal");
                    break;
                case 'o':
                    Console.WriteLine("Es vocal");
                    break;
                case 'u':
                    Console.WriteLine("Es vocal");
                    break;
                default:
                    Console.WriteLine("Es consonante");
                    break;
            }

        }
    }
}
