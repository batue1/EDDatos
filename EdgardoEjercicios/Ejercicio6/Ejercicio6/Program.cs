using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defino variables.
            int a, b, c;

            //Muestro el resultado de las operaciones a=5; b=++a; c=a++; b=b*5; a=a*2;

           
            Console.WriteLine("El resultado de la operación a = 5 es {0}", a = 5);
            Console.WriteLine("El resultado de la operación b=++a es {0}", b = ++a);
            Console.WriteLine("El resultado de la operación c=a++ es {0}", c = a++);
            Console.WriteLine("El resultado de la operación b=b*5 es {0}", b = b*5);
            Console.WriteLine("El resultado de a = a*2 es {0}", a = a*2);

            Console.ReadKey();
        }
    }
}
