using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un número entero");
            int numer1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe segundo nùmero entero");
            int numer2 = int.Parse(Console.ReadLine());
            while (numer2 == 0)
            {
            Console.WriteLine("Error: No se puede dividir entre cero, escribe otro nùmero entero");
                numer2 = int.Parse(Console.ReadLine());
            }
            int divide = numer1 / numer2;
            Console.WriteLine(divide);
            Console.ReadLine();


            


        }
    }
}
