using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class Estadistica
    {
        public int EstadisticasId { get; set; }
        public int TipoEstadisticasId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string DocumentoEstadisticas { get; set; }

        public virtual TipoEstadistica TipoEstadisticas { get; set; }
    }
}
