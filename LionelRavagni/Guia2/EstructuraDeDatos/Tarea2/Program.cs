using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, cifras;
            cifras = 0;

            Console.WriteLine("Ingrese un numero entero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            while (numero!=0)
            {
                numero = numero / 10;
                cifras++;
            }

            Console.WriteLine("El numero ingrasado tiene "+cifras+" cifras.");
            Console.ReadKey();
        }
    }
}
