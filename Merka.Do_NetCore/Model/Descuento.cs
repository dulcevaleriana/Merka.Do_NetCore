using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class Descuento
    {
        public Descuento()
        {
            Compras = new HashSet<Compra>();
            Productos = new HashSet<Producto>();
        }

        public int DescuentoId { get; set; }
        public int ProductoId { get; set; }
        public int CategoriaProductoId { get; set; }
        public int UsuarioId { get; set; }
        public decimal DescuentoAplicar { get; set; }
        public DateTime FechaExpiracionDescuento { get; set; }

        public virtual CategoriaProducto CategoriaProducto { get; set; }
        public virtual Producto Producto { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<Compra> Compras { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
