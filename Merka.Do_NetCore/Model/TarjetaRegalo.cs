using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class TarjetaRegalo
    {
        public int TarjetaRegaloId { get; set; }
        public int ClienteId { get; set; }
        public string NombreCliente { get; set; }
        public string RazonSocialEmpresa { get; set; }
        public decimal ValorAcreditarTarjetaRegalo { get; set; }
        public DateTime FechaVencimiento { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
