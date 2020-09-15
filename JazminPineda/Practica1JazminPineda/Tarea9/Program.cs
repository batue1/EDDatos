using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe primer nùmero ");
            int numer1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe segundo nùmero ");
            int numer2 = int.Parse(Console.ReadLine());
            int producto2 = numer1 * numer2;
            Console.WriteLine("El producto es {0}", producto2);
            Console.ReadLine();



        }
    }
}
