using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        { /*
           Crea un programa que pida al usuario su identificador y su contraseña (ambos numéricos).
           No puede seguir hasta que introduzca como identificador "1234" y como contraseña "1111".
           */
            //Defino variables.
            string identificador, contraseña;
            bool exit = false;

            do
            {
                Console.WriteLine("Ingrese identificador: ");
                identificador = Console.ReadLine();
                Console.WriteLine("Ingrese contraseña: ");
                contraseña = Console.ReadLine();

                if (identificador != "1234" || contraseña != "1111")
                {
                    Console.WriteLine("No puede continuar hasta que ponga como idenficiador 1234 y de contraseña 1111.");
                    Console.WriteLine("¡No ingrese espacios!");
                }
                else exit = true;

            } while (exit == false);

            Console.WriteLine("Ingresó correctamente el identificador y contraseña.");
            Console.ReadKey();
        }
    }
}
