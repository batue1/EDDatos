using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 5; 
            b = ++a; 
            c = a++; 
            b = b * 5;
            a = a * 2;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
