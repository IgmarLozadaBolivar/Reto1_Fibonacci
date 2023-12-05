using System;

namespace Ejercicio2
{
    class FibonacciProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n------------------------------------");
            Console.WriteLine("Bienvenido a Fibonacci - Ejercicio 3".ToUpper());
            Console.WriteLine("------------------------------------\n");

            Console.Write("Ingrese la cantidad de numeros de Fibonacci que desea mostrar: ");
            int m;

            while (!int.TryParse(Console.ReadLine(), out m) || m < 1)
            {
                Console.WriteLine("Por favor, ingrese un numero entero positivo.");
                Console.Write("Ingrese la cantidad de numeros de Fibonacci que desea mostrar: ");
            }

            Console.WriteLine("\nLos primeros {0} numeros de Fibonacci son:", m);

            for (int i = 0; i < m; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}