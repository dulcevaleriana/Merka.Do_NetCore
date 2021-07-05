using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class TipoEstadistica
    {
        public TipoEstadistica()
        {
            Estadisticas = new HashSet<Estadistica>();
            LogActionClientes = new HashSet<LogActionCliente>();
            LogActionUsuarios = new HashSet<LogActionUsuario>();
        }

        public int TipoEstadisticasId { get; set; }
        public string NombreTipoEstadisticas { get; set; }

        public virtual ICollection<Estadistica> Estadisticas { get; set; }
        public virtual ICollection<LogActionCliente> LogActionClientes { get; set; }
        public virtual ICollection<LogActionUsuario> LogActionUsuarios { get; set; }
    }
}
