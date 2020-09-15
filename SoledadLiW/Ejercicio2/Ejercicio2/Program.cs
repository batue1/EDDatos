using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Progra
    {
        public static void Main(String[] args)
        {
            {
                int usuario, password;
                int intentos = 0;
                Console.WriteLine("Check usuario y password");
                Console.WriteLine("Default Usuario 1234 y password 1111");
                do
                {
                    Console.WriteLine("Ingrese usurario por favor: ");
                    usuario = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrese password por favor: ");
                    password = Convert.ToInt32(Console.ReadLine());

                    if (usuario != 1234 || password != 1111)
                        intentos++;
                    else
                        intentos = 1;
                }
                while ((usuario != 1234 || password != 1111) && (intentos != 3));

                if (intentos == 3)
                    Console.Write("Intente nuevamente!");
                else
                    Console.WriteLine("Ingreso exitoso!");
            }
        }
    }

    }

    