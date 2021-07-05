using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class Genero
    {
        public Genero()
        {
            Clientes = new HashSet<Cliente>();
            Usuarios = new HashSet<Usuario>();
        }

        public int GeneroId { get; set; }
        public string NombreGenero { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
