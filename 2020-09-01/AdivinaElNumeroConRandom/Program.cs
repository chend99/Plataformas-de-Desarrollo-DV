using System;

namespace AdivinaElNumeroConRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            /*JUEGO INSPIRADO DEL FINAL DE PROGRAMACIÓN AVANZADA AHORA CON RANDOM*/

            int num_max = 100; //Número Máximo del número a generar aleatoriamente.
            int num_min = 1; //Número Mínimo del número a generar aleatoreimente.

            int intentos, numero_elegido, numero_adivinar; //Intentos maximos que tendrá el usuario, Numero elegido actualmente por el usuario, Numero que se tendrá que adivinar, se generará aleatoriamente.
            bool adivinado, continuar; //Flag por si el número es adivinado, Flag para preguntar si el usuario quiere continuar jugando

            do
            {
                SeteoDelJuego(out intentos, out numero_adivinar, out continuar, out adivinado, num_min, num_max);

                Console.WriteLine($"Tienes {intentos} intentos para adivinar el número del {num_min} al {num_max} !");
                while (!adivinado && intentos > 0)
                {
                    numero_elegido = PedirNumero("Ingresar número: ");

                    if (numero_elegido == numero_adivinar)
                    {
                        Ganaste($"Perfecto! adivinaste el número en {intentos} intentos", ref adivinado);
                    }
                    else if (numero_elegido > numero_adivinar)
                    {
                        Fallaste($"Nope, el número es más chico.", ref intentos);
                    }
                    else
                    {
                        Fallaste($"Nope, el número es más grande.", ref intentos);
                    }
                }

                if (!adivinado)
                {
                    Perdiste($"¡Qué mal! Con la estrategia correcta este juego es imposible perder... El número era {numero_adivinar}");
                }

                Continuar("Ingrese cualquier tecla y enter para continuar o escriba 'no' para finalizar.", ref continuar);

            } while (continuar);
        }
        static void Ganaste(string mensaje, ref bool adivinado)
        {
            adivinado = true;
            Console.WriteLine(mensaje);
        }
        static void Perdiste(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
        static void Fallaste(string mensaje, ref int intentos)
        {
            intentos--;
            Console.WriteLine(mensaje + $" Te quedan {intentos} intentos");
        }
        static void Continuar(string mensaje, ref bool continuar)
        {
            Console.WriteLine(mensaje);
            string respuesta = Console.ReadLine();
            if (respuesta.ToLower().Equals("no"))
            {
                continuar = false;
            }
        }

        static int PedirNumero(string mensaje)
        {
            Console.Write(mensaje);
            return int.Parse(Console.ReadLine());
        }
        static int GenerarNumeroRandom(int num_min, int num_max)
        {
            Random rng = new Random();
            return rng.Next(num_max - num_min + 1) + num_min;
        }
        static void SeteoDelJuego(out int intentos, out int numero_adivinar, out bool continuar, out bool adivinado, int num_min, int num_max)
        {
            intentos = 7;
            numero_adivinar = GenerarNumeroRandom(num_min, num_max);
            continuar = true;
            adivinado = false;
        }
    }
}
