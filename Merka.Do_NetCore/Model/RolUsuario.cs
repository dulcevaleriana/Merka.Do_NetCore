using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class RolUsuario
    {
        public RolUsuario()
        {
            LogActionUsuarios = new HashSet<LogActionUsuario>();
            Notificacions = new HashSet<Notificacion>();
            Usuarios = new HashSet<Usuario>();
        }

        public int RolId { get; set; }
        public string NombreRol { get; set; }

        public virtual ICollection<LogActionUsuario> LogActionUsuarios { get; set; }
        public virtual ICollection<Notificacion> Notificacions { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
