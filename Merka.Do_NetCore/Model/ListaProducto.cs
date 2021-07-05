using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class ListaProducto
    {
        public ListaProducto()
        {
            CarritoCompras = new HashSet<CarritoCompra>();
        }

        public int ListaProductosId { get; set; }
        public int ProductoId { get; set; }
        public decimal PrecioProducto { get; set; }
        public decimal TotalPago { get; set; }

        public virtual Producto Producto { get; set; }
        public virtual ICollection<CarritoCompra> CarritoCompras { get; set; }
    }
}
