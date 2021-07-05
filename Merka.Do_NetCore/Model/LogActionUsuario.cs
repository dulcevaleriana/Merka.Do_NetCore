using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class LogActionUsuario
    {
        public int LogId { get; set; }
        public int TipoNotificacionId { get; set; }
        public int TipoEstadisticasId { get; set; }
        public int UsuarioId { get; set; }
        public int RolId { get; set; }
        public DateTime FechaEjecución { get; set; }

        public virtual RolUsuario Rol { get; set; }
        public virtual TipoEstadistica TipoEstadisticas { get; set; }
        public virtual TipoNotificacion TipoNotificacion { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
