using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("ejercicio 1");
            int a = 200;
            int b = 56;
            Console.WriteLine(a + b);

            //2
            Console.WriteLine("ejercicio 2");
            int x = 13;
            int y = 12;
            Console.WriteLine(x * y);

            //3
            Console.WriteLine("ejercicio 3");
            int resta1 = 321;
            int resta2 = 213;
            Console.WriteLine(resta1 - resta2);

            //4
            Console.WriteLine("ejercicio 4");
            int num1 = 20;
            int num2 = 5;
            int suma = num1 + num2;
            int resultado = suma / 6;
            Console.WriteLine(resultado);

            //5
            Console.WriteLine("ejercicio 5");
            int num3 = 12;
            int num4 = 102;
            int resultado1 = num3 * num4;
            Console.WriteLine(resultado1);

            //6
            Console.WriteLine("ejercicio 6");
            int suma1 = 200;
            int suma2 = 1111;
            int result = suma1 + suma2;
            Console.WriteLine(result);

            //7
            Console.WriteLine("ejercicio 7");
            int numero1 = 10;
            int numero2 = 25;
            int result1 = numero1 * numero2;
            Console.WriteLine(result1);

            //8
            Console.WriteLine("ejercicio 8");
            Console.WriteLine("introduzca dos numeros para obtener su producto: ");
            int input1;
            int input2;

            input1 = Convert.ToInt16(Console.ReadLine());
            input2 = Convert.ToInt16(Console.ReadLine());

            int resultados = input1 * input2;

            Console.WriteLine(resultados);

            //9
            Console.WriteLine("ejercicio 9");
            Console.WriteLine("introduzca un numero para saber si es par o inpar: ");
            int input3;
            input3 = Convert.ToInt16(Console.ReadLine());

                if(input3 % 2 == 0)
                {
                    Console.WriteLine("Es par");
                }
                else
                {
                    Console.WriteLine("Es inpar");
                }

            //10
            Console.WriteLine("ejercicio 10");
            Console.WriteLine("Ingrese dos numeros para saber cual es el mayor: ");
            int input4;
            int input5;
            input4 = Convert.ToInt16(Console.ReadLine());
            input5 = Convert.ToInt16(Console.ReadLine());

            if (input4 > input5)
            {
                Console.WriteLine("El numero " + input4 + " es mayor que " + input5);
            }
            else
            {
                Console.WriteLine("El numero " + input5 + " es mayor que " + input4);
            }

            //11
            Console.WriteLine("ejercicio 11");
            Console.WriteLine("Ingrese dos numeros para dividir: ");
            int input6;
            int input7;
            input6 = Convert.ToInt16(Console.ReadLine());
            input7 = Convert.ToInt16(Console.ReadLine());


            if(input7 != 0)
            {
                int resultados1 = input6 / input7;
                Console.WriteLine("El resultado de la division es: " + resultados1);
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir entre cero");
            }

            //12
            Console.WriteLine("ejercicio 12");
            Console.WriteLine("Ingrese un numero entre 1 y 5");
            int ingresado;
            ingresado = Convert.ToInt16(Console.ReadLine());

            switch (ingresado)
            {
                case 1:
                    Console.WriteLine("uno");
                    break;

                case 2:
                    Console.WriteLine("dos");
                    break;
                case 3:
                    Console.WriteLine("tres");
                    break;
                case 4:
                    Console.WriteLine("cuatro");
                    break;
                case 5:
                    Console.WriteLine("cinco");
                    break;

                default:
                    Console.WriteLine("ninguno");
                    break;
            }

            //13
            Console.WriteLine("ejercicio 3");
            int i = 0;

            while(i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            //14
            Console.WriteLine("ejercicio 14");
            int j = 0;

            do
            {
                Console.WriteLine(j);
                j++;

            } while (j <= 10);

            //15
            Console.WriteLine("ejercicio 15");
            for (int z = 1; z <= 10; z++)
            {
                Console.WriteLine(z);
            }

        }
    }
}
