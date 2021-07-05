using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class Compra
    {
        public Compra()
        {
            Entregas = new HashSet<Entrega>();
            Facturas = new HashSet<Factura>();
        }

        public int ComprasId { get; set; }
        public int CarritoComprasId { get; set; }
        public decimal PrecioInicialCompra { get; set; }
        public decimal SubTotalCompraItbis { get; set; }
        public int? CuponesId { get; set; }
        public int? DescuentoId { get; set; }
        public string Direccion { get; set; }
        public int MetodoEnvioId { get; set; }
        public decimal TotalPago { get; set; }
        public bool Estado { get; set; }

        public virtual CarritoCompra CarritoCompras { get; set; }
        public virtual Cupone Cupones { get; set; }
        public virtual Descuento Descuento { get; set; }
        public virtual MetodoEnvio MetodoEnvio { get; set; }
        public virtual ICollection<Entrega> Entregas { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
