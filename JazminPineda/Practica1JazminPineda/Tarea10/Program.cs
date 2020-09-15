using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba nùmero entero ");
            int entero = int.Parse(Console.ReadLine());
            if (entero % 2 == 0)
            {
                Console.WriteLine("El número {0} es par ", entero);
            }
            else {
                Console.WriteLine("El nùmero {0} es impar ", entero);
            }
            Console.ReadLine();
        }
    }
}
