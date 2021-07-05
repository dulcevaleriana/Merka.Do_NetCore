using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class HistorialCompra
    {
        public int HistorialCompraId { get; set; }
        public int ClienteId { get; set; }
        public string NombreCliente { get; set; }
        public string RazonSocialEmpresa { get; set; }
        public int CarritoCompraId { get; set; }
        public DateTime FechaEnvio { get; set; }
        public bool EstadoTipoHistorialCompra { get; set; }
        public decimal TotalPago { get; set; }

        public virtual CarritoCompra CarritoCompra { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
