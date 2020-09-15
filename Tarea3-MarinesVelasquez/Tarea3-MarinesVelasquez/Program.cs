using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3_MarinesVelasquez
{
    class Program
    {
        static void Main(string[] args)
        {
            // TAREA 1: Crea un programa que pida al usuario su identificador y su contraseña (ambos numéricos), y no le permita 
            //seguir hasta que introduzca como identificador "1234" y como contraseña "1111".
            Console.WriteLine("Tarea 1");
            Console.WriteLine("Ingrese su identificador:");
            int usuario = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su contraseña");
            int contraseña = Int32.Parse(Console.ReadLine());

            int Identificador = 1234;
            int password = 1111;

            while (usuario != Identificador && contraseña != password)
            {
                Console.WriteLine(" Informacion erronea, por favor vuelva a intentar");
                Console.WriteLine("Ingrese su identificador de nuevo:");
                usuario = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese su contraseña de nuevo");
                contraseña = Int32.Parse(Console.ReadLine());

            }
            Console.WriteLine("Felicidades! Acceso correcto");
            Console.ReadKey();

            // TAREA 2: Crea un programa calcule cuantas cifras tiene un número entero positivo (pista: 
            //se puede hacer dividiendo varias veces entre 10).
            Console.WriteLine("Tarea 2");
            Console.WriteLine("Ingrese un número entero positivo");
            int entero = Int32.Parse(Console.ReadLine());

            if (entero < 0) Console.WriteLine("Debes ingresar un numero positivo");
            else
            {
                string mayores = entero.ToString(); //convertirlo en texto
                Console.WriteLine($"La cantidad de cifras que tiene el número ingresado es: {mayores.Length}"); //cuanta los caracteres pero en texto
            }
            Console.ReadKey();

            // TAREA 3: Crea un programa que muestre la tabla de multiplicar del 9.
            Console.WriteLine("Tarea 3");
            Console.WriteLine("Tabla de multiplicar del 9");
            int mult;

            for (mult = 1; mult <=10; mult++)
            {
                Console.WriteLine($"9 *{mult} = {9*mult}");
            }
            Console.ReadKey();

            // TAREA 4: Crea un programa que contenga un bucle sin fin que escriba "Hola " en pantalla, sin avanzar de línea.
            /*Console.WriteLine("Tarea 4");
            Console.WriteLine("Bucle sin fin");

            while(true) //tienes que  colocar true ajuro adentro para que funcione, diciendole mientras sea verdadero, entra aqui, nunca no sera verdadero porque no le estas poniendo ninguna condicion
            {
                Console.WriteLine("Hola");
            }
            
       

            // TAREA 5: Crea un programa que contenga un bucle sin fin que muestre los números enteros positivos a partir del uno. 
            Console.WriteLine("Tarea 5");
            Console.WriteLine("Bucle sin fin de números enteros positivos");
            int positivo = 0;

            while (true)
            {       
                Console.WriteLine(positivo++);
            }
            */

            // TAREA 6: ¿Cuál sería el resultado de las siguientes operaciones? a=5; b=++a; c=a++; b=b*5; a=a*2; 
            //Crea un programa que lo resuelva.
            Console.WriteLine("Tarea 6");
            int a;
            int b;
            int c;
            a = b = c = 5;
            Console.WriteLine($"El resultado de a=5 es: {a}");
            Console.WriteLine($"El resultado de a=a*2 es: {a * 2}");
            Console.WriteLine($"El resultado de b=++a es: {++a}");
            Console.WriteLine($"El resultado de c=a++ es: {c++}");
            Console.WriteLine($"El resultado de b=b*5 es: {++b*5}");

            Console.ReadKey();

            // TAREA 7: ¿Cuál sería el resultado de las siguientes operaciones? 
            //a=5; b=a+2; b-=3; c=-3; c*=2; ++c; a*=b; Crea un programa que te lo muestre.
            Console.WriteLine("Tarea 7");
            int A = 5;
            int B;
            int C = -3;
            Console.WriteLine($"El resultado de a=5 es: {A}");
            Console.WriteLine($"El resultado de b=a+2 es: {B = A+2}");
            Console.WriteLine($"El resultado de b-=3 es: {B-=3}");
            Console.WriteLine($"El resultado de c=-3 es: {C}");
            Console.WriteLine($"El resultado de c*=2 es: {C *= 2}");
            Console.WriteLine($"El resultado de  ++c es: {++C}");    
            Console.WriteLine($"El resultado de  a*=b es: {a*=b}");

            Console.ReadKey();

            // TAREA 8: Crea un programa que pida una letra al usuario y diga si se trata de una vocal.
            Console.WriteLine("Tarea 7");
            Console.WriteLine("Ingrese una letra");
            string letra;
            letra = Console.ReadLine();
            if (letra=="a" || letra=="e" || letra=="i" || letra=="o" || letra=="u")
                Console.WriteLine("Es una vocal");
            else
                Console.WriteLine("No es una vocal, es una consonante");
            Console.ReadKey();

            // TAREA 9: Crear un programa que pida al usuario un nombre y una contraseña. La contraseña se debe 
            //introducir dos veces. Si las dos contraseñas no son iguales, se avisará al usuario y se le volverán a 
            //pedir las dos contraseñas.
            Console.WriteLine("Tarea 8");

            Console.WriteLine("Ingrese un usuario");
            string usuarioNombre = Console.ReadLine();
            Console.WriteLine("Ingrese una contraseña");
            string clave = Console.ReadLine();
            Console.WriteLine("Ingresa nuevamente la contraseña");
            string confirmacion = Console.ReadLine();

            while (clave != confirmacion)
            {
                Console.WriteLine("Las contraseñas no coinciden, por favor vuelva a ingresar la contraseña");
                clave = Console.ReadLine();
                Console.WriteLine("Ingresa nuevamente la contraseña");
                confirmacion = Console.ReadLine();
            }
            Console.WriteLine($"Se guardo correctamente el usuario {usuarioNombre} y la contraseña {clave}");
            Console.ReadKey();

            // TAREA 10: Crear un programa que pida al usuario su nombre, y le diga "Hola" si se llama "Martin", o bien le diga "No te conozco" si teclea otro nombre.
            Console.WriteLine("Tarea 10");

            Console.WriteLine("Ingrese su nombre");
            string  nombre = Console.ReadLine();

            if (nombre == "Martin")
                Console.WriteLine("Hola");
            else
                Console.WriteLine("No te conozco");
            Console.ReadKey();







        }
    }
}
