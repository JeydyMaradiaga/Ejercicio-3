using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Usuario
    {
        public string NomUsuario { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }

        public Usuario(string nomUsuario, string nombre, string clave)
        {
            NomUsuario = nomUsuario;
            Nombre = nombre;
            Clave = clave;
        }

        public Usuario()
        {
        }

        
    }
}
