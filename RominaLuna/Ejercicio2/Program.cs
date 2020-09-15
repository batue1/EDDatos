using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* EJERCICIO 1
            int usuario = 1234;
            int clave;
            int contraseña= 1111;
            int clave2;

            do
            {
                Console.Write("Introduzca su ID numérico de 4 digitos: ");
                clave = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduzca su ID numérico de 4 digitos: ");
                clave2 = Convert.ToInt32(Console.ReadLine());

                if (clave != usuario && clave2 != contraseña)
                    Console.WriteLine("No válida!");
            }
            while (clave != usuario && clave2 != contraseña);

            Console.WriteLine("Aceptada.");

            Console.ReadKey();
            */

            /* EJERCICIO 2
            int numero, contador;
            contador = 0;

            Console.Write("Introduce un número entero positivo: ");
            numero = Convert.ToInt32(Console.ReadLine());

            while (numero > 0)
            {
                numero = numero / 10;

                contador = contador + 1;
            }

            Console.WriteLine("El número de digitos es {0}.", contador);
            Console.ReadKey();
            */

            /* EJERCICIO 3
            int numero = 9;
            Console.WriteLine("Tabla del 9 ");
            Console.WriteLine("");
            for (int i=1; i <= 10; i++)
            {
                int multiplicar = numero * i;
                Console.WriteLine("{0} x {1} = {2}", numero, i, multiplicar);
            }
            Console.ReadKey();
            */

            /* EJERCICIO 4
            int numero;

            numero = 1;

            while (numero != 0) 
            {
                Console.Write(numero);
                Console.Write("-");
                numero = numero + 1;
            }
            Console.ReadKey();
            */

            /*EJERCICIO 5
            string saludo;

            saludo = "\"Hola\"";

            while (saludo != "no")
            {
                Console.Write(saludo);
                saludo = saludo + saludo;
            }
            Console.ReadKey();
            */


            /* EJERCICIO 6
            int a, b, c;

            a = 5;
            b = ++a;
            c = a++;
            b = b * 5;
            a = a * 2;

            Console.WriteLine("Resultados:  a= {0} b= {1} c= {2} b= {3} a= {4}", a, b, c, b, c );
            Console.ReadKey();
            */

            /*EJERCICIO 7
            int a, b, c;

            a = 5;
            b = a + 2;
            b = 3;
            c = 3;
            c *= 2;
            ++c;
            a *= b;


            Console.WriteLine("Resultados: {0} {1} {2} {3} {4} {5} {6}", a, b, b, c, c, ++c, a);
            Console.ReadKey
            */

            /* EJERCICIO 8
            string letra;

            Console.WriteLine("Ingrese una letra: ");
            letra = Console.ReadLine();

            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u") 
            {
                Console.WriteLine("La letra \"{0}\" es una vocal", letra);
            }
            else
            {
                Console.WriteLine("La letra \"{0}\" no es una vocal", letra);
            }
            Console.ReadKey();
            */

            /*  EJERCICIO 9
            int clave;
            int clave2;
            string nombre;

            Console.WriteLine("Introduzca su nombre: ");
            nombre = Console.ReadLine();

            do
            {           
                Console.Write("introduzca su contraseña numerica: ");
                clave = Convert.ToInt32(Console.ReadLine());
                Console.Write("Vuelva a introducir su contraseña: ");
                clave2 = Convert.ToInt32(Console.ReadLine());

                if (clave != clave2 )
                    Console.WriteLine("Claves no coinciden!");
            }
            while (clave != clave2 );

            Console.WriteLine("Aceptada.");

            Console.ReadKey();
            */


            /*Ejercicio 10
            string nombre;

            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            if (nombre == "Martin" )
            {
                Console.WriteLine("Hola {0} !", nombre);
            }
            else
            {
                Console.WriteLine("No te conozco.");
            }
            Console.ReadKey();
            */

        }


    }
}
