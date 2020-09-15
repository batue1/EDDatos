using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un numero entero" );
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe otro numero entero");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("El numero mayor es {0}", a);
            }
            else {
                Console.WriteLine("El numero mayor es {0}", b);
            }
            Console.ReadLine();
        }
    }
}
