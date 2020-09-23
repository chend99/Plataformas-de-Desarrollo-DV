using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora c1 = new Calculadora();
            Console.WriteLine(c1.Sumar(1, 1));
            Console.WriteLine(c1.Restar(1, 1));
            Console.WriteLine(c1.Multiplicar(3, 5));
            Console.WriteLine(c1.Dividir(1, 2));
            
        }
    }
}
