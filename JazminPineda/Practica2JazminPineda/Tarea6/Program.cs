using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine(a);
            int b = ++a;
            Console.WriteLine(b);
            int c = a++;
            Console.WriteLine(c);
            b = b * 5;
            Console.WriteLine(b);
            a = a * 2;
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }

}
