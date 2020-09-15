using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplo, multiplicador;

            for (multiplicador = 0; multiplicador <= 10; multiplicador++)
            {
                multiplo = multiplicador * 9;
                Console.WriteLine("9 x "+multiplicador+" = "+multiplo);
            }
            Console.ReadKey();
        }
    }
}
