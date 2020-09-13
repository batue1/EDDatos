using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TABLA DEL 9");
            Console.WriteLine("-");
            //Ciclo que imprime la tabla del nueve.
            for (int i = 1; i<=10 ; i++)
            {
                Console.WriteLine("9 x " + i + " = " + 9 * i);
                if (i == 10) Console.WriteLine("-");
            }
            Console.ReadKey();
        }
    }
}
