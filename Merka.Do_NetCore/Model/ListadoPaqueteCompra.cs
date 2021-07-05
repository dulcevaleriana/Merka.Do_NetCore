using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class ListadoPaqueteCompra
    {
        public int ListadoPaqueteCompraId { get; set; }
        public int ClienteId { get; set; }
        public string NombreCliente { get; set; }
        public string RazonSocialEmpresa { get; set; }
        public int CarritoComprasId { get; set; }
        public decimal TotalPago { get; set; }
        public bool EstadoListadoPaqueteCompra { get; set; }
        public DateTime FechaCreacionPaqueteCompra { get; set; }
        public bool ErrorReportado { get; set; }
        public string MensajePaqueteCompra { get; set; }
        public bool StatusFirmaEntregaPaqueteCompra { get; set; }
        public string FirmaClientePaqueteCompra { get; set; }
        public string UbicacionActualPaqueteCompra { get; set; }
        public string UbicacionDestinoPaqueteCompra { get; set; }

        public virtual CarritoCompra CarritoCompras { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
