using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6
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
            Console.WriteLine("a = "+ resultado);
            b = ++a;
            resultado = b;
            Console.WriteLine("b = ++a -> b = "+ resultado);
            c = a++;
            resultado = c;
            Console.WriteLine("c = a++ -> c = " + resultado);
            b = b*5;
            resultado = b;
            Console.WriteLine("b = b*5 -> b = "+ resultado);
            a = a*2;
            resultado = a;
            Console.WriteLine("a = a*2 -> a = "+ resultado);

            Console.ReadKey();
        }
        }
    }
