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
            int a = 5;
            Console.WriteLine(a);
            int b = a + 2;
            Console.WriteLine(b);
            b -= 3;
            Console.WriteLine(b);
            int c = -3;
            Console.WriteLine(c);
            c *= 2;
            Console.WriteLine(c);
            ++c;
            Console.WriteLine(c);
            a *= b;
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
