using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5
{
    class Program
    {
        static void Main(string[] args)
        {
            string hola = "Hola";

            while (hola.Equals("Hola"))
            {
                Console.Write(hola);
            }
            Console.ReadKey();
        }
    }
}
