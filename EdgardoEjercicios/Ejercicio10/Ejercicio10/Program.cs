using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {/*
          Crear un programa que pida al usuario su nombre, y le diga "Hola" si se llama "Martín"
           , o bien le diga "No te conozco" si teclea otro nombre.
          */
            //Defino variables.
            string name;
            bool answer;

            Console.Write("Ingrese un nombre (sin espacios) : ");
            name = Console.ReadLine();

            //Verificar y mostrar mensaje.
            answer = Regex.IsMatch(name, "^[mM]art[ií]n$");

            if (answer == true) Console.WriteLine("Hola.");
            else Console.WriteLine("No te conozco");

            Console.ReadKey();

        }
    }
}
