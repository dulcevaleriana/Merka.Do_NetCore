using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class TarjetaMembresium
    {
        public int TarjetaMembresiaId { get; set; }
        public int ClienteId { get; set; }
        public string NombreCliente { get; set; }
        public string RazonSocialEmpresa { get; set; }
        public int PuntosAcumuladosTarjetaMembresia { get; set; }
        public DateTime FechaVencimientoTarjetaMembresia { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
