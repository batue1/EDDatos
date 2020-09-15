using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 5; 
            b = a + 2; 
            b -= 3; 
            c = -3; 
            c *= 2;
            ++c; 
            a *= b;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
