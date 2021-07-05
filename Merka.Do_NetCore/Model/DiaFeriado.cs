using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class DiaFeriado
    {
        public int DiaFeriadoId { get; set; }
        public string NombreDiaFeriado { get; set; }
        public DateTime FechaDiaFeriado { get; set; }
        public bool SeLabora { get; set; }
        public DateTime HorarioAperturaDiaFeriado { get; set; }
        public DateTime HorarioCierreDiaFeriad { get; set; }
    }
}
