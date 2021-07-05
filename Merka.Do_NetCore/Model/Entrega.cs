using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class Entrega
    {
        public int EntregaId { get; set; }
        public int ComprasId { get; set; }
        public int ClienteId { get; set; }
        public int MensajeroEncargadoId { get; set; }
        public string UbicacionActualEntrega { get; set; }
        public string UbicacionDestinoEntrega { get; set; }
        public int StatusTipoCompraId { get; set; }
        public string FirmaClientePaqueteCompra { get; set; }
        public bool StatusFirmaEntregaPaqueteCompra { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Compra Compras { get; set; }
        public virtual Usuario MensajeroEncargado { get; set; }
        public virtual TipoStatusCompra StatusTipoCompra { get; set; }
    }
}
