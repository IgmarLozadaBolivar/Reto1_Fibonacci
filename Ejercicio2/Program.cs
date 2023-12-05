using System;

namespace Ejercicio2
{
    class TestFibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n------------------------------------");
            Console.WriteLine("Bienvenido a Fibonacci - Ejercicio 2".ToUpper());
            Console.WriteLine("------------------------------------\n");

            Console.Write("Ingrese un numero para determinar si es Fibonacci: ");
            int nInput;

            while (!int.TryParse(Console.ReadLine(), out nInput) || nInput < 0)
            {
                Console.WriteLine("Por favor, ingrese un numero entero no negativo.");
                Console.Write("Ingrese un numero para determinar si es Fibonacci: ");
            }

            if (IsFibonacci(nInput))
            {
                Console.WriteLine($"El numero que ingresaste ({nInput}) es un numero Fibonacci.");
            }
            else
            {
                Console.WriteLine($"El numero que ingresaste ({nInput}) no es un numero Fibonacci.");
            }
        }

        static bool IsFibonacci(int number)
        {
            int n = 0, fn = 1, variable;

            while (fn < number)
            {
                variable = n + fn;
                n = fn;
                fn = variable;
            }

            return (number == fn);
        }
    }
}
