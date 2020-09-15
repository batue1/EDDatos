using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
        
            Console.WriteLine("Ingrese un numero para saber sus cifras: ");
            x = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(Math.Ceiling(Math.Log10(x)));
        }
    }
}
