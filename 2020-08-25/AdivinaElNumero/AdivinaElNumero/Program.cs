using System;

namespace AdivinaElNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            /*JUEGO INSPIRADO DEL FINAL DE PROGRAMACIÓN AVANZADA*/
            int intentos;
            int max_intentos = 7;
            int numero_elegido;
            int numero_adivinar = 87; //No vimos random así que pongo uno por defecto.

            bool adivinado;
            bool continuar;

            string respuesta;

            do
            {
                //reseteo
                intentos = 0;
                continuar = true;
                adivinado = false;

                Console.WriteLine($"Tienes {max_intentos} intentos para adivinar el número del 1 al 100!");
                while (!adivinado && intentos < max_intentos)
                {
                    Console.Write("Número: ");
                    numero_elegido = int.Parse(Console.ReadLine());

                    if (numero_elegido == numero_adivinar)
                    {
                        adivinado = true;
                        Console.WriteLine($"Perfecto! adivinaste el número en {intentos}");
                    }
                    else if (numero_elegido > numero_adivinar)
                    {
                        Console.WriteLine("Nope, el número es más chico.");
                        intentos++;
                    }
                    else
                    {
                        Console.WriteLine("Nope, el número es más grande.");
                        intentos++;
                    }

                }
                if (!adivinado)
                {
                    Console.WriteLine($"¡Qué mal! para la próxima... El número era {numero_adivinar}");
                }
                Console.WriteLine("Ingrese cualquier tecla y enter para continuar o escriba 'no' para finalizar.");
                respuesta = Console.ReadLine();
                if (respuesta.ToLower().Equals("no"))
                {
                    continuar = false;
                }
            } while (continuar);
        }
    }
}
