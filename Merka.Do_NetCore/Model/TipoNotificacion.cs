using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class TipoNotificacion
    {
        public TipoNotificacion()
        {
            LogActionClientes = new HashSet<LogActionCliente>();
            LogActionUsuarios = new HashSet<LogActionUsuario>();
            Notificacions = new HashSet<Notificacion>();
        }

        public int TipoNotificacionId { get; set; }
        public string NombreTipoNotificacion { get; set; }

        public virtual ICollection<LogActionCliente> LogActionClientes { get; set; }
        public virtual ICollection<LogActionUsuario> LogActionUsuarios { get; set; }
        public virtual ICollection<Notificacion> Notificacions { get; set; }
    }
}
