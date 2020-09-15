using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int usuario, password, password2;
            int intentos = 0;
            Console.WriteLine("Check usuario y password");
            Console.WriteLine("Default Usuario 1234 y password 1111");
            do
            {
                Console.WriteLine("Ingrese usurario por favor: ");
                usuario = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese password por favor: ");
                password = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese password por favor: ");
                password2 = Convert.ToInt32(Console.ReadLine());

                if (password == password2)
                    intentos++;
                else
                    intentos = 1;
            }
            while ((password != password2) && (intentos != 3));

            if (intentos == 3)
                Console.Write("Intente nuevamente!");
            else
                Console.WriteLine("Ingreso exitoso!");
        }
    }
}
