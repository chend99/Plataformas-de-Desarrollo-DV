using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    class Usuario
    {
        public string usuario { get; set; }
        public string clave { get; set; }

        public Usuario(string usuario, string clave)
        {
            this.usuario = usuario;
            this.clave = clave;
        }
    }
}
