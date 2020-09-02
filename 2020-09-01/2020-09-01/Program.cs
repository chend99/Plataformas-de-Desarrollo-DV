using System;

namespace _2020_09_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*JUEGO INSPIRADO DEL FINAL DE PROGRAMACIÓN AVANZADA AHORA CON RANDOM*/
            Random rng = new Random();

            int num_max = 100; //Número Máximo del número a generar aleatoriamente.
            int num_min = 1; //Número Mínimo del número a generar aleatoreimente.
            int max_intentos = 7; //Número de intentos máximos.

            int intentos; //Intentos actuales del usuario
            int numero_elegido; //Numero elegido actualmente por el usuario
            int numero_adivinar; //Numero que se tendrá que adivinar, se generará aleatoriamente.

            bool adivinado; //Flag por si el número es adivinado.
            bool continuar; //Flag para preguntar si el usuario quiere continuar jugando

            string mensaje; //String para mostrar al usuario

            do
            {
                //reseteo
                intentos = 0;
                numero_adivinar = rng.Next(num_max - num_min + 1) + num_min;
                continuar = true;
                adivinado = false;

                Console.WriteLine($"Tienes {max_intentos} intentos para adivinar el número del {num_min} al {num_max} !");
                while (!adivinado && intentos < max_intentos)
                {
                    Console.Write("Ingresar número: ");
                    numero_elegido = int.Parse(Console.ReadLine());

                    if (numero_elegido == numero_adivinar)
                    {
                        adivinado = true;
                        mensaje = $"Perfecto! adivinaste el número en {intentos} intentos";
                    }
                    else if (numero_elegido > numero_adivinar)
                    {
                        intentos++;
                        mensaje = $"Nope, el número es más chico. Te quedan {max_intentos - intentos} intentos";
                    }
                    else
                    {
                        intentos++;
                        mensaje = $"Nope, el número es más grande. Te quedan {max_intentos - intentos} intentos";
                    }
                    Console.WriteLine(mensaje);
                }

                if (!adivinado)
                {
                    Console.WriteLine($"¡Qué mal! Con la estrategia correcta este juego es imposible perder... El número era {numero_adivinar}");
                }

                Console.WriteLine("Ingrese cualquier tecla y enter para continuar o escriba 'no' para finalizar.");

                string respuesta = Console.ReadLine();
                if (respuesta.ToLower().Equals("no"))
                {
                    continuar = false;
                }
            } while (continuar);
        }
    }
}
