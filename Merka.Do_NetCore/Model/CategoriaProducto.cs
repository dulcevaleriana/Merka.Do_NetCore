using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class CategoriaProducto
    {
        public CategoriaProducto()
        {
            Descuentos = new HashSet<Descuento>();
            Productos = new HashSet<Producto>();
        }

        public int CategoriaProductoId { get; set; }
        public string NombrecategoriaProducto { get; set; }

        public virtual ICollection<Descuento> Descuentos { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
