using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defino variables.

            int a, b, c ;

            //Muestro los resultados de las operaciones a=5; b=a+2; b-=3; c=-3; c*=2; ++c; a*=b;
            Console.WriteLine("El resultado de la operación a=5 es {0}", a=5);
            Console.WriteLine("El resultado de la operación b = a + 2 es {0}", b = a + 2);
            Console.WriteLine("El resultado de la operación b -= 3 es {0}", b -=3);
            Console.WriteLine("El resultado de la operación c =-3 es {0}", c = -3);
            Console.WriteLine("El resultado de la operación c*=2 es {0}", c*=2);
            Console.WriteLine("El resultado de la operación ++c es {0}", ++c);
            Console.WriteLine("El resultado de la operación a*=b es {0}", a *= b);

            Console.ReadKey();

        }
    }
}
