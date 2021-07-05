using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class Producto
    {
        public Producto()
        {
            Comentarios = new HashSet<Comentario>();
            Descuentos = new HashSet<Descuento>();
            ListaProductos = new HashSet<ListaProducto>();
        }

        public int ProductoId { get; set; }
        public string NombreProducto { get; set; }
        public string ImagenProducto { get; set; }
        public int CantidadProducto { get; set; }
        public int SucursalId { get; set; }
        public int SupermercadoId { get; set; }
        public decimal PrecioProducto { get; set; }
        public int? DescuentoId { get; set; }
        public decimal? PrecioAnterior { get; set; }
        public int CategoriaProductoId { get; set; }
        public string DescripcionProducto { get; set; }
        public string TablaNutricionalProductoImg { get; set; }

        public virtual CategoriaProducto CategoriaProducto { get; set; }
        public virtual Descuento Descuento { get; set; }
        public virtual Sucursal Sucursal { get; set; }
        public virtual Supermercado Supermercado { get; set; }
        public virtual ICollection<Comentario> Comentarios { get; set; }
        public virtual ICollection<Descuento> Descuentos { get; set; }
        public virtual ICollection<ListaProducto> ListaProductos { get; set; }
    }
}
