using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crea un programa que pida una letra al usuario y diga si se trata de una vocal.
            //Defino variables.
            string letter;
            bool answer;

            Console.Write("Ingrese un solo caracter: ");
            letter = Console.ReadLine();

            while (letter.Length>1)
            {
                Console.WriteLine("Solo puede ingresar un solo caracter (sin espacios): ");
                letter = Console.ReadLine();
            }

            //Evaluar si es vocal y mostrar mensaje
            answer = Regex.IsMatch(letter, "^[aeiouAEIOU]$");

            if (answer == true) Console.WriteLine("El caracter " + letter + " es una vocal.");
            else Console.WriteLine("El caracter " + letter + " no es una vocal.");

            Console.ReadKey();
        }
    }
}
