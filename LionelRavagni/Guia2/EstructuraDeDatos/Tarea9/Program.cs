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
            string user, password1, password2;

            Console.WriteLine("Ingrese el usuario: ");
            user = Console.ReadLine();

            Console.WriteLine("Ingrese la contraseña: ");
            password1 = Console.ReadLine();

            Console.WriteLine("Ingrese nuevamente la contraseña: ");
            password2 = Console.ReadLine();
            while (!(password2.Equals(password1)))
            {
                Console.WriteLine("¡ERROR! Ingrese nuevamente la contraseña: ");
                password1 = Console.ReadLine();
                Console.WriteLine("Repita la contraseña: ");
                password2 = Console.ReadLine();
            }
            Console.WriteLine("¡Identificación validada!");
            Console.ReadKey();
        }
    }
}
