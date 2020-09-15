using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerclase3
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {//Tarea 1: Crea un programa que pida al usuario su identificador y su contraseña (ambos numéricos), y no le permita seguir hasta que introduzca como identificador "1234" y como contraseña "1111".

            /*
                string identificador, pass;

                Console.WriteLine("Ingrese su id");
                identificador = Console.ReadLine();
                Console.WriteLine("Ingrese su contraseña");
                pass = Console.ReadLine();

                while (identificador != "1234" || pass != "1111")
                {
                    Console.WriteLine("Ingrese su id");
                    identificador = Console.ReadLine();
                    Console.WriteLine("Ingrese su contraseña");
                    pass = Console.ReadLine();
                }
                Console.ReadLine();

                */
            //Tarea 2: Crea un programa calcule cuantas cifras tiene un número entero positivo (pista: se puede hacer dividiendo varias veces entre 10).

            /*
            int numero, contador;
            contador = 1;

            Console.WriteLine("Ingrese un numero positivo");
            numero = Convert.ToInt32(Console.ReadLine());

            while (numero >= 10)
               {
                   contador++;
                   numero /= 10;
               }



            Console.WriteLine("El número que ingreso tiene {0} cifras", contador);
            Console.ReadLine();
            */

            //Tarea 3: Crea un programa que muestre la tabla de multiplicar del 9.

            /*
            int n, resultado;


            for (n = 0; n < 10; n++)
            {
                resultado = 9 * n;
                Console.WriteLine("9 x {0} = {1}", n, resultado);
            }

            Console.ReadLine();

            */

            //Tarea 4: Crea un programa que contenga un bucle sin fin que muestre los números enteros positivos a partir del uno.

            /*
            int n = 1;
            for (;;)
            {
                Console.WriteLine(n);
                n++;
            }
            Console.ReadLine();
            */

            //Tarea 5: Crea un programa que contenga un bucle sin fin que escriba "Hola " en pantalla, sin avanzar de línea.

            /*
            for (; ; )
                Console.Write("Hola");
            */

            //Tarea 6: ¿Cuál sería el resultado de las siguientes operaciones? a=5; b=++a; c=a++; b=b*5; a=a*2; Crea un programa que lo resuelva.

            /*
            int a, b, c;

            a = 5;
            Console.WriteLine("a es igual a {0}", a);
            b = ++a;
            Console.WriteLine("Ahora a vale {0} y b vale {1}", a, b);
            c = a++;
            Console.WriteLine("Ahora a vale {0} y c vale {1}", a, c);
            b *= 5;
            Console.WriteLine("Ahora b vale {0}", b);
            a *= 2;
            Console.WriteLine("Ahora a vale {0}", a);

            Console.ReadLine();

            */


            //Tarea 7: ¿Cuál sería el resultado de las siguientes operaciones? a=5; b=a+2; b-=3; c=-3; c*=2; ++c; a*=b; Crea un programa que te lo muestre.
            /*
            int a, b, c;

            a = 5;
            Console.WriteLine("a es igual a {0}", a);
            b = a + 2;
            Console.WriteLine("b es igual a {0}", b);
            b -= 3;
            Console.WriteLine("Ahora b vale {0}", b);
            c = -3;
            Console.WriteLine("c vale {0}", c);
            c *= 2;
            Console.WriteLine("Ahora c vale {0}", c);
            c++;
            Console.WriteLine("Ahora c vale {0}", c);
            a *= b;
            Console.WriteLine("Ahora a vale {0}", a);

            Console.ReadLine();
            */

            //Tarea 8: Crea un programa que pida una letra al usuario y diga si se trata de una vocal.

            /*
            char letra;
            bool esvocal;


            Console.WriteLine("Ingrese una letra");
            letra = Convert.ToChar(Console.ReadLine());
            esvocal = (letra == 'a') || (letra == 'e') || (letra == 'i') || (letra == 'o') || (letra == 'u');

            if (esvocal)
                Console.WriteLine("La letra ingresada es una vocal");
            else
                Console.WriteLine("La letra ingresada no es una vocal");

            Console.ReadLine();
            */

            //Tarea 9: Crear un programa que pida al usuario un nombre y una contraseña. La contraseña se debe introducir dos veces. Si las dos contraseñas no son iguales, se avisará al usuario y se le volverán a pedir las dos contraseñas.

            /*
            string nombre, contraseña1, contraseña2;

            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Escriba su contraseña");
            contraseña1 = Console.ReadLine();
            Console.WriteLine("Escriba su contraseña nuevamente");
            contraseña2 = Console.ReadLine();

            while (contraseña1 != contraseña2)
            {
                Console.WriteLine("Las contraseñas no coinciden");
                Console.WriteLine("Escriba su contraseña");
                contraseña1 = Console.ReadLine();
                Console.WriteLine("Escriba su contraseña nuevamente");
                contraseña2 = Console.ReadLine();
            }

            Console.ReadLine();
            */

            //Tarea 10: Crear un programa que pida al usuario su nombre, y le diga "Hola" si se llama "Martín", o bien le diga "No te conozco" si teclea otro nombre.

            string nombre;

            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();

            if (nombre == "Martín")
                Console.WriteLine("Hola");
            else
                Console.WriteLine("No te conozco. Rajá de acá!");

            Console.ReadLine();
        }
    }
}
