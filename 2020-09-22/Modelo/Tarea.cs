using System;
using System.Collections.Generic;
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

    }
}
