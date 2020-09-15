using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private const int V = 1234;
        private const int A = 1111;

        static void Main(string[] args)
        {
            Console.WriteLine("Escriba su número de identificación ");
            int Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba su contraseña");
            int Pasword = int.Parse(Console.ReadLine());
            if (Id == V && Pasword == A)
            {
                Console.WriteLine("Bienvenido usuario {0}", V);
            }
            else
                Console.WriteLine("Usuario no autorizado ");


            Console.ReadLine();


        }
    }
}
