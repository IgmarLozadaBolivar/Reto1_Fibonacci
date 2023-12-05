using System;

namespace Ejercicio1
{
    class TestFibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n------------------------------------");
            Console.WriteLine("Bienvenido a Fibonacci - Ejercicio 1".ToUpper());
            Console.WriteLine("------------------------------------\n");

            Console.Write("Ingrese un numero entero: ");
            int nInput = Convert.ToInt32(Console.ReadLine());

            int n = 0, fn = 1, variable;

            if (nInput <= 1)
            {
                Console.Write(n);
                return;
            }

            for (int i = 2; i <= nInput; i++)
            {

                variable = n + fn;
                n = fn;
                fn = variable;
            }

            Console.Write($"El numero que ingresaste fue: {nInput}\n");
            Console.Write($"Resultado: F{nInput} = {fn}");
        }
    }
}