using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int EDAD_MINIMA = 1;
            int MAYOR_DE_EDAD = 18;
            int EDAD_LIMTE = 120;

            string respuesta;
            string mensaje;

            Console.WriteLine("Ingresa tu nombre");
            respuesta = Console.ReadLine();
            string nombre = respuesta;

            Console.WriteLine("Ingresa tu edad");
            respuesta = Console.ReadLine();
            int edad = int.Parse(respuesta);

            if (edad >= EDAD_MINIMA && edad < MAYOR_DE_EDAD)
            {
                mensaje = $"Usted no tiene {MAYOR_DE_EDAD} para utilizar esta aplicación.";
            }
            else if (edad >= MAYOR_DE_EDAD && edad < EDAD_LIMTE)
            {
                mensaje = $"¡Bienvenido {nombre}!";
            }
            else
            {
                mensaje = "Ingrese una edad válida!";
            }

            Console.WriteLine(mensaje);
        }
    }
}
