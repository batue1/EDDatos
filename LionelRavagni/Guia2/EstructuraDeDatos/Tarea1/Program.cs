using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            int id, password, idUser, passUser;
            id = 1234;
            password = 1111;
            Console.WriteLine("Ingrese su numero identificador: ");
            idUser = Convert.ToInt32(Console.ReadLine());
            while (idUser != id)
            {
                Console.WriteLine("Identificador incorrecto. Vuelva a ingresarlo: ");
                idUser = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Ingrese su contraseña: ");
            passUser = Convert.ToInt32(Console.ReadLine());
            while (passUser != password)
            {
                Console.WriteLine("Contraseña incorrecta. Vuelva a ingresarla: ");
                passUser = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("¡Identificación validada!");
            Console.ReadKey();
        }
    }
}
