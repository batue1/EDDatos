using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, resultado;
            b = 0;
            c = 0;
            a = 5;
            resultado = a;
            Console.WriteLine("a = " + resultado);
            b = a + 2;
            resultado = b;
            Console.WriteLine("b = a + 2 -> b = " + a + " + 2 -> b = " + resultado);
            b -= 3;
            resultado = b;
            Console.WriteLine("b -= 3 -> b = " + resultado);
            c = -3;
            resultado = c;
            Console.WriteLine("c = " + resultado);
            c *= 2;
            resultado = c;
            Console.WriteLine("c *= 2 -> c = " + resultado);
            ++c;
            resultado = c;
            Console.WriteLine("++c = " + resultado);
            a *= b;
            resultado = a;
            Console.WriteLine("a *= b -> " + resultado);

            Console.ReadKey();
        }
    }
}
