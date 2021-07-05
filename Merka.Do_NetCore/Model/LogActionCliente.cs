using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class LogActionCliente
    {
        public int LogId { get; set; }
        public int TipoNotificacionId { get; set; }
        public int TipoEstadisticasId { get; set; }
        public int ClienteId { get; set; }
        public DateTime FechaEjecución { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual TipoEstadistica TipoEstadisticas { get; set; }
        public virtual TipoNotificacion TipoNotificacion { get; set; }
    }
}
