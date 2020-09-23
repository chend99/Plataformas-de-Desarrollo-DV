using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    class Detalles
    {
        public DateTime fecha{ get; set; }
        public int tiempo { get; set; }
        public Recurso recurso{ get; set; }
        public Tarea tarea { get; set; }

        public Detalles(DateTime fecha, int tiempo, Recurso recurso, Tarea tarea)
        {
            this.fecha = fecha;
            this.tiempo = tiempo;
            this.recurso = recurso;
            this.tarea = tarea;
        }
    }
}
