using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class Notificacion
    {
        public int NotificacionId { get; set; }
        public int RolId { get; set; }
        public int TipoNotificacionId { get; set; }
        public int UsuarioReceptorId { get; set; }
        public string MensajeNotificacion { get; set; }
        public DateTime FechaNotificacion { get; set; }

        public virtual RolUsuario Rol { get; set; }
        public virtual TipoNotificacion TipoNotificacion { get; set; }
        public virtual Cliente UsuarioReceptor { get; set; }
    }
}
