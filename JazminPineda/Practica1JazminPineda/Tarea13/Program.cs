using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un numero del 1 al 5 ");
            int numero = int.Parse(Console.ReadLine());
            while (numero < 1 || numero > 5) 
            {
                Console.WriteLine("Error vuelva a escribir un numero del 1 al 5 ");
                numero = int.Parse(Console.ReadLine());
            }
            switch (numero)
            {
                case 1:
                    Console.WriteLine("uNO");
                    break;
                case 2:
                    Console.WriteLine("dos");
                    break;
                case 3:
                    Console.WriteLine("tres");
                    break;
                case 4:
                    Console.WriteLine("cuatro");
                    break;
                case 5:
                    Console.WriteLine("cinco");
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }


    }
}
