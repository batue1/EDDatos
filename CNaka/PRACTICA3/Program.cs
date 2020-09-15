using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA._3
{
    class Program
    {
        static void Main(string[] args)
        {


            //Clase 3

            //BUCLE FOR

            /*
            int i; 
            for(i=0; i<5; i++)
            {
                Console.WriteLine("Hola Mundo");
                Console.ReadKey(); //para que no se cierre la consola
            }
            */

            // TAREA 3

            //1 Crea un programa que pida al usuario su identificador y su contraseña (ambos numéricos), y no le permita seguir hasta que introduzca como identificador &quot; 1234 & quot; y como contraseña & quot; 1111 & quot;.

            /*
            int identif;
            int contra;

            Console.WriteLine("Ingrese identificador: ");
            identif = Convert.ToInt32(Console.ReadLine());
            while (identif != 1234) 
            {
                Console.WriteLine("Es incorrecto, intente otra vez.");
                identif = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Ingrese contrasenya: ");
            contra = Convert.ToInt32(Console.ReadLine());
            while (contra != 1111) 
            {
                Console.WriteLine("Es incorrecto, intente otra vez.");
                contra = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadKey();
            */



            //2 Crea un programa calcule cuantas cifras tiene un número entero positivo (pista: se puede hacer dividiendo varias veces entre 10).

            /*
            int num;
            int vuelta = 0;

            Console.WriteLine("Ingrese un numero entero: ");
            num = Convert.ToInt32(Console.ReadLine());
            
            while (num > 0)
            {
                num = num / 10;
                vuelta++;
            }

            Console.WriteLine(vuelta);

            Console.ReadKey();
            */


            //3 Crea un programa que muestre la tabla de multiplicar del 9.

            /*
            int i;
            int resultado;

            for (i=0; i<=10; i++)
            {
                resultado = i * 9;
                Console.WriteLine("{0} x 9 es {1}", i, resultado);
            }
            Console.ReadKey();

            */

            //4 Crea un programa que contenga un bucle sin fin que muestre los números enteros
            //positivos a partir del uno.

            /*
            int i;


            for (i = 1;;)
            {
                i++;
                Console.WriteLine(i);
            }
            Console.ReadKey();

            */



            //5 Crea un programa que contenga un bucle sin fin que escriba &quot;Hola &quot; en pantalla, sin
            //avanzar de línea.

            /*
            string mensaje = "Hola" ;
            int i;

            for (i = 1; ;)
            {
                i++;
                mensaje += mensaje;
                Console.WriteLine(mensaje);
            }
            Console.ReadKey();

            */


            //6 6: ¿Cuál sería el resultado de las siguientes operaciones? a=5; b=++a; c=a++; b=b*5;
            //a = a * 2; Crea un programa que lo resuelva.

            /*
            int a = 5;
            Console.WriteLine(a);
            int b = ++a;
            Console.WriteLine(b);
            int c = a++;
            //Da 6 porque esta tomando la a++ del anterior, que seria 6
            Console.WriteLine(c);

            Console.WriteLine(a = a*2);//7*2 tene en cuenta que el valor de a va cambiando
            Console.WriteLine(b = b*5); //6*5

            Console.ReadKey();
            */



            //7 ¿Cuál sería el resultado de las siguientes operaciones? a=5; b=a+2; b-=3; c=-3; c*=2;
            //++c; a *= b; Crea un programa que te lo muestre.

            /*
            int a = 5;
            Console.WriteLine(a);
            int b = a + 2;
            Console.WriteLine(b);
            
            Console.WriteLine(b-=3);
            int c = -3;
            Console.WriteLine(c*=2);
            Console.WriteLine(++c);
            Console.WriteLine(a*=b);


            Console.ReadKey();
            */




            //8 Crea un programa que pida una letra al usuario y diga si se trata de una vocal.

            /*
            string letra;

            Console.WriteLine("Ingrese una letra: ");
            letra = Console.ReadLine();

            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
            {
                Console.WriteLine("Es una vocal.");

            }
            else
            {
                Console.WriteLine("Es una consonante.");

            }

            Console.ReadKey();
            */

            //9 Crear un programa que pida al usuario un nombre y una contraseña. La contraseña se
            //debe introducir dos veces. Si las dos contraseñas no son iguales, se avisará al usuario y se le
            //volverán a pedir las dos contraseñas.

            /*
             
            string usuario;
            string contra1 = "1";
            string contra2 = "0";

            Console.WriteLine("Usuario: ");
            usuario = Console.ReadLine();

            while (contra2 != contra1)
            {

                Console.WriteLine("Constrasena: ");
                contra1 = Console.ReadLine();
                Console.WriteLine("Repita contrasena: ");
                contra2 = Console.ReadLine();

            }

            Console.ReadKey();

            */


            //10 Crear un programa que pida al usuario su nombre, y le diga &quot;Hola&quot; si se llama
            //&quot; Martín & quot;, o bien le diga &quot; No te conozco & quot; si teclea otro nombre.

            string name;

            Console.WriteLine("Ingrese nombre: ");
            name = Console.ReadLine();

            if (name == "Martin")
            {
                Console.WriteLine("Hola");

            }
            else
            {
                Console.WriteLine("No te conozco.");

            }


            Console.ReadKey();

        }
    }
}
