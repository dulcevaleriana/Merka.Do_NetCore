using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class StatusCompra
    {
        public int StatusCompraId { get; set; }
        public int ClienteId { get; set; }
        public string NombreCliente { get; set; }
        public string RazonSocialEmpresa { get; set; }
        public int CarritoComprasId { get; set; }
        public decimal TotalPago { get; set; }
        public int StatusTipoCompraId { get; set; }
        public int MensajeroStatusCompra { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual TipoStatusCompra StatusTipoCompra { get; set; }
    }
}
