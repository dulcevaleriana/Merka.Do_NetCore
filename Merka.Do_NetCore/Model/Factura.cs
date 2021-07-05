using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class Factura
    {
        public int Factura1 { get; set; }
        public int SupermercadoId { get; set; }
        public int ClienteId { get; set; }
        public int ComprasId { get; set; }
        public int CarritoComprasId { get; set; }
        public DateTime Fecha { get; set; }
        public bool StatusTarjetaCredito { get; set; }
        public bool ComprobanteFiscal { get; set; }
        public int? ComprobanteFiscalId { get; set; }

        public virtual CarritoCompra CarritoCompras { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Compra Compras { get; set; }
        public virtual Supermercado Supermercado { get; set; }
    }
}
