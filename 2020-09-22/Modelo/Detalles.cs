using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    class Detalles
    {
        public DateTime fecha{ get; set; }
        public DateTime tiempo{ get; set; }
        public Recurso recurso{ get; set; }
        public Tarea tarea { get; set; }
    }
}
