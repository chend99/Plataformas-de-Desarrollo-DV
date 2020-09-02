using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM_MAX = 50;
            int acumulador = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingresar numero");
                int numero = int.Parse(Console.ReadLine());
                acumulador += numero;

                if (acumulador >= NUM_MAX) break;
            }
        }
    }
}
