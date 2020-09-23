using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Modelo
{
    class Tarea
    {
        public string titulo { get; set; }
        public DateTime vencimiento { get; set; }
        public int estimacion { get; set; }
        public Recurso responsable{ get; set; }
        public bool estado{ get; set; }
        public Tarea(string titulo, DateTime vencimiento, int estimacion, Recurso responsable, bool estado)
        {
            this.titulo = titulo;
            this.vencimiento = vencimiento;
            this.estimacion = estimacion;
            this.responsable = responsable; 
            this.estado = estado;
        }

    }
}
