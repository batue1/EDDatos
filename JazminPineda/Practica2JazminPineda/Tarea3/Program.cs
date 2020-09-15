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
            int tablamult = 9;
            Console.WriteLine("Tabla de multiplicar 9 ");
            for (int i = 0; i <= 10; i++)
            { 
                Console.WriteLine( "{0} x {1} = {2}", tablamult, i, tablamult * i); 
            }
            Console.ReadLine(); 
                
        }
    }
}
