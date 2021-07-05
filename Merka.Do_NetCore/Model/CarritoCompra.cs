using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class CarritoCompra
    {
        public CarritoCompra()
        {
            Compras = new HashSet<Compra>();
            Facturas = new HashSet<Factura>();
            HistorialCompras = new HashSet<HistorialCompra>();
            ListadoPaqueteCompras = new HashSet<ListadoPaqueteCompra>();
        }

        public int CarritoComprasId { get; set; }
        public int ListaProductosId { get; set; }
        public decimal TotalPago { get; set; }

        public virtual ListaProducto ListaProductos { get; set; }
        public virtual ICollection<Compra> Compras { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<HistorialCompra> HistorialCompras { get; set; }
        public virtual ICollection<ListadoPaqueteCompra> ListadoPaqueteCompras { get; set; }
    }
}
