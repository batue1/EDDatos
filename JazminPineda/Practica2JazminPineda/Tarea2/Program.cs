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
            int cuenta = 0;
            Console.WriteLine("Escriba un numero entero positivo ");
            string numero = Console.ReadLine();
            for (int i = 1; i <= numero.Length; i++) 
            {
                cuenta = i;
                
            }
            Console.WriteLine(cuenta);
            Console.ReadLine();
        }
    }
}
