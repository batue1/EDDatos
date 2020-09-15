using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_MarinesVelasquez
{
    class Program
    {
        static void Main(string[] args)
        {
            sumar(200, 56);
            producto(13, 13);
            resta(321, 213);
            OperacionMat(20, 5, 6);

            // TAREA 2: Crea un programa que diga el resultado de sumar 200 y 56.
            static void sumar(int numero1, int numero2)
            {
                Console.WriteLine($"Tarea Nº 2   La suma es: {numero1 + numero2}");
                Console.ReadKey();
            }

            //TAREA 3: Haz un programa que calcule el producto de los números 13 y 12.
            static void producto(int numero1, int numero2)
            {
                Console.WriteLine($"Tarea Nº 3   El producto es: {numero1 * numero2}");
                Console.ReadKey();
            }


            //TAREA 4: Un programa que calcule la diferencia (resta) entre 321 y 213

            static void resta(int num1, int num2)
            {
                Console.WriteLine($"Tarea Nº 4   La resta es: {num1 - num2}");
                Console.ReadKey();
            }

            // TAREA 5  Calcular el resultado de (20+5) / 6 

            static void OperacionMat(double num1, int num2, int num3)
            {
                Console.WriteLine($"Tarea Nº 5   El resultado de la operación matematica es: {(num1 + num2) / num3}");
                Console.ReadKey();
            }

            // TAREA 6: Crea un programa que calcule el producto de los números 12 y 102, usando variables. 

            int number1 = 12;
            int number2 = 102;
            Console.WriteLine($"Tarea Nº 6   El producto es: {number1 * number2}");

            Console.ReadKey();

            // TAREA 7: Crea un programa que calcule la suma de 200 y 1111, usando variables. 
            int numbers1 = 200;
            int numbers2 = 1111;
            Console.WriteLine($"Tarea Nº 7   La suma es: {numbers1 + numbers2}");

            Console.ReadKey();

            // TAREA 8: Crea un programa que calcule el producto de los números 10 y 25, usando variables llamadas "numero1" y "numero2". 
            int numero1 = 10;
            int numero2 = 25;
            Console.WriteLine($"Tarea Nº 8   El producto es {numero1 * numero2}");

            Console.ReadKey();

            // TAREA 9: Crea un programa que calcule el producto de dos números introducidos por el usuario. 
            Console.WriteLine("Tarea Nº 9 ");
            Console.WriteLine("Ingrese el primer  nùmero:");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo nùmero");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"El producto es: {num1 * num2}");

            Console.ReadKey();

            //TAREA 11: Crea un programa que pida al usuario dos números enteros y diga cuál es el mayor de ellos.

            Console.WriteLine("Tarea 11");
            Console.WriteLine("Ingrese el primer número:");
            int numb1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            int numb2 = Int32.Parse(Console.ReadLine());

            if (numb1 > numb2) Console.WriteLine($"El mayor es { numb1}");

            else if (numb2 == numb1) Console.WriteLine("Los dos números son iguales");

            else Console.WriteLine($"El mayor es {numb2}");

            Console.ReadKey();

            //TAREA 12:  Crea un programa que pida al usuario dos números enteros. Si el segundo no es cero, mostrará el resultado de dividir entre el primero y el segundo. Por el contrario, si el segundo número es cero, escribirá "Error: No se puede dividir entre cero".*/

            Console.WriteLine("Tarea 12");
            Console.WriteLine("Ingrese el primer número entero:");
            int primerNum = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número entero:");
            int segundNum = Int32.Parse(Console.ReadLine());

            if (segundNum == 0) Console.WriteLine("Error: No se puede dividir entre cero");
            else
                Console.WriteLine($"El resultado de la division de enteros es: {primerNum / segundNum}");

            Console.ReadKey();

            //TAREA 13: Crea un programa que pida un número del 1 al 5 al usuario, y escriba el nombre de ese número, usando "switch" (por ejemplo, si introduce "1", el programa escribirá "uno")

            Console.WriteLine("Tarea 13");
            Console.WriteLine("Ingrese un número entre 1 al 5:");
            int numero = Int32.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Uno");
                    break;
                case 2:
                    Console.WriteLine("Dos");
                    break;
                case 3:
                    Console.WriteLine("Tres");
                    break;
                case 4:
                    Console.WriteLine("Cuatro");
                    break;
                case 5:
                    Console.WriteLine("Cinco");
                    break;
                default:
                    Console.WriteLine("Número incorrecto, debe estar entre 1 al 5");
                    break;
            }
            Console.ReadKey();

            // TAREA 14: Crea un programa que escriba en pantalla los números del 1 al 10, usando "while"
            Console.WriteLine("Tarea 14");
            Console.WriteLine("Números del 1 al 10 con While");
            int number = 0;

            while (number < 10)
            {
                number++;
                Console.WriteLine(number);
            }
            Console.WriteLine("fin del ciclo");

            Console.ReadKey();

            // TAREA 15: Crea un programa que escriba en pantalla los números del 1 al 10, usando "Do while"
            Console.WriteLine("Tarea 15");
            Console.WriteLine("Números del 1 al 10 con Do while");
            int numbers = 0;

            do
            {
                numbers++;
                Console.WriteLine(numbers);
            } while (numbers < 10);
            Console.WriteLine("fin del ciclo");

            Console.ReadKey();

            // TAREA 16: Crea un programa que muestre los números del 10 al 20, ambos incluidos, usando “for
            Console.WriteLine("Tarea 16");
            Console.WriteLine("Números del 10 al 20 con For");
            int n;
            for (n = 1; n <= 20; n++)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}
