using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea15
{
    class Program
    {
        static void Main(string[] args)
        {
            int numer = 1;
            do 
            {
                Console.WriteLine(numer);
                numer = numer + 1;
                            
            } while (numer <= 10);
            Console.ReadLine();  
        }
    }
}
