using System;
using System.Collections.Generic;

namespace Modelo
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario u1 = new Usuario("cherath", "B45gGh56fFVC");
            Recurso r1 = new Recurso("david", u1);
            List<Tarea> tareas = new List<Tarea>();
            tareas.Add(new Tarea("Ejercicio1", new DateTime(2020, 9, 22), 10, r1, false));
            tareas.Add(new Tarea("Ejercicio2", new DateTime(2020, 9, 23), 12, r1, false));
            tareas.Add(new Tarea("Ejercicio3", new DateTime(2020, 9, 24), 12, r1, false));
            tareas.Add(new Tarea("Ejercicio4", new DateTime(2020, 9, 25), 11, r1, false));
            tareas.Add(new Tarea("Ejercicio5", new DateTime(2020, 9, 26), 9, r1, false));
        }
    }
}
