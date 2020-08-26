using System;

namespace _2020_08_18
{
    class Program
    {
        static void Main(string[] args)
        {
            /* EJERCICIO 1*/
            //int EDAD_MINIMA = 1;
            //int MAYOR_DE_EDAD = 18;
            //int EDAD_LIMTE = 120;

            //string respuesta;
            //string mensaje;

            //Console.WriteLine("Ingresa tu nombre");
            //respuesta = Console.ReadLine();
            //string nombre = respuesta;

            //Console.WriteLine("Ingresa tu edad");
            //respuesta = Console.ReadLine();
            //int edad = int.Parse(respuesta);

            //if (edad >= EDAD_MINIMA && edad < MAYOR_DE_EDAD)
            //{
            //    mensaje = $"Usted no tiene {MAYOR_DE_EDAD} para utilizar esta aplicación.";
            //}
            //else if(edad >= MAYOR_DE_EDAD && edad < EDAD_LIMTE)
            //{
            //    mensaje = $"¡Bienvenido {nombre}!";
            //}
            //else
            //{
            //    mensaje = "Ingrese un edad válida!";
            //}

            //Console.WriteLine(mensaje);
            
            /* EJERCICIO 2 */
            int NUM_MAX = 50;
            int acumulador = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingresar numero");
                int numero = int.Parse(Console.ReadLine());
                acumulador += numero;
            
                if (acumulador >= NUM_MAX)
                {
                    break;
                }
            }
        }


    }
}
}
