using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Crear un programa que pida al usuario un nombre y una contraseña. La contraseña se debe introducir dos veces.
            Si las dos contraseñas no son iguales, se avisará al usuario y se le volverán a pedir las dos contraseñas.
             */
            //Defino variables.
            string name, password_1, password_2;
            bool exit = false;

            //Ingreso datos y comparo.
            Console.Write("Ingrese nombre: ");
            name = Console.ReadLine();
            do
            {
                Console.Write("Ingrese contraseña: ");
                password_1 = Console.ReadLine();
                Console.Write("Vuelva a ingresar la contraseña para verificar: ");
                password_2 = Console.ReadLine();

                if (password_1 != password_2)
                {
                    Console.WriteLine("¡Volver a ingresar contraseña (no hubo coincidencias)! ");

                }
                else exit = true;
            } while (exit == false);

            Console.WriteLine("El usuario - "+ name +" - y la contraseña - "+ password_1 +" - fueron registrados exitosamente.");
            Console.ReadKey();
        }
    }
}
