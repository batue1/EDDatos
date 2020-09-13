using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Crea un programa calcule cuantas cifras tiene un número entero positivo.
             */
            //Defino variables.
            string number;
            bool exit = false, answer;

            //Ingreso valor y verifico.

            do
            {
                Console.WriteLine("Ingrese un número entero: ");
                number = Console.ReadLine();

                answer = Regex.IsMatch( number , @"\D");

                if (answer == true || number == "0")
                {
                    Console.WriteLine("¡No ingresó un número entero positivo!");
                    Console.WriteLine("¡No ingrese espacios!");
                }

                else exit = true;
                
            } while (exit == false);

            //Muestro mensaje.

            Console.WriteLine("El entero positivo " + number + " ingresado tiene " + number.Length + " dígitos.");

            Console.ReadKey();
        }
    }
}
