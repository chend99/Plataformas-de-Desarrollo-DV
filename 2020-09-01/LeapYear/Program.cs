using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LeapYear(IngresarAño("Ingresa tu año de nacimiento")));
        }
        static int IngresarAño(string mensaje)
        {
            Console.WriteLine(mensaje);
            return int.Parse(Console.ReadLine());
        }
        static string LeapYear(int year)
        {
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                return $"{year} es Bisiesto";
            }
            return $"{year} NO es Bisiesto";
        }
    }
}
