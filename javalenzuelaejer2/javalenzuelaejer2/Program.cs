using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace javalenzuelaejer2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* tarea 1 */

            /*int identificador, contraseña;
            
            do
            {
                Console.Write("Introduzca su identificador: ");
                identificador = Convert.ToInt32(Console.ReadLine());

                Console.Write("Introduzca su contraseña: ");
                contraseña = Convert.ToInt32(Console.ReadLine());

                if (identificador != 1234) ;
                if (contraseña != 1111) ;
                Console.WriteLine("No valido");
            }

            while (identificador != 1234);
            while (contraseña != 1111);
            Console.WriteLine("Aceptado");*/


            /* tarea 2 */

            /*int numero = 435443;
            int cifras = 1;

            while (numero >= 10)
            {
                numero /= 10;
                cifras++;
            }
            Console.Write("Tiene {0} cifras", cifras);
            Console.ReadLine();*/


            /* tarea 3 */

            /*int numero = 9, i;

            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0}x{1}={2}", numero, i, (numero * i));
            }
            Console.ReadKey(); */

            /* tarea 4*/

            /*int f;

            for (f=1; ; f++) {
                Console.WriteLine(f);
            }
            Console.ReadKey();*/


            /* tarea 5*/

            /*
            int i = 1;

            while (i > 0)
            {
                Console.Write("hola");
            }
            Console.ReadLine(); */

            /* tarea 6*/
            /*

            int a, b, c;
            a = 5;
            Console.WriteLine("a = " + a);
            b = ++a;
            Console.WriteLine("b = ++a es " + b);
            c = a++;
            Console.WriteLine("c = a++ es " + c);
            b = b * 5;
            Console.WriteLine("b = b * 5 es " + b);
            a = a * 2;
            Console.WriteLine("a = a * 2 es " + a);

            Console.ReadKey();

            /* tarea 8*/
            /*
            string letra;
            Console.Write("Digite una letra: ");
            letra = Console.ReadLine();

            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
            {
                Console.WriteLine("La letra \"{0}\" es una vocal", letra);
            }
            else
            {
                Console.WriteLine("La letra \"{0}\" no es una vocal", letra);
            }
            Console.ReadKey();/*

            /*tarea 9*/

            string nombre, contraseña1, contraseña2;

            Console.Write("Ingrese su nombre: ");
            nombre = Convert.ToString(Console.ReadLine());

            Console.Write("Ingrese su contraseña: ");
            contraseña1 = Convert.ToString(Console.ReadLine());

            Console.Write("Ingrese su contraseña: ");
            contraseña2 = Convert.ToString(Console.ReadLine());

            while (contraseña1 != contraseña2)
            {
                Console.WriteLine("Las contraseñas no coinciden!! ");
                
            }
            Console.ReadKey();

            /*tarea 10*/
            /* 

            string nombre;

            Console.Write("Ingrese su nombre: ");
            nombre = Convert.ToString(Console.ReadLine());

            if (nombre == "martin" || nombre == "Martin")
            {
                Console.WriteLine("Hola");
            }
            else
            {
                Console.WriteLine("No te conozco");
            }
            Console.ReadKey(); */




        }
    }
}
