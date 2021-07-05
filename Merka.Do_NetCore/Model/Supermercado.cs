using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class Supermercado
    {
        public Supermercado()
        {
            Facturas = new HashSet<Factura>();
            Productos = new HashSet<Producto>();
            Sucursals = new HashSet<Sucursal>();
        }

        public int SupermercadoId { get; set; }
        public string NombreSupermercado { get; set; }
        public string DireccionSupermercado { get; set; }
        public DateTime HorarioApertura { get; set; }
        public DateTime HorarioCierre { get; set; }
        public bool DiaFeriado { get; set; }
        public DateTime HorarioAperturaSabado { get; set; }
        public DateTime HorarioCierreSabado { get; set; }
        public DateTime HorarioAperturaDomingo { get; set; }
        public DateTime HorarioCierreDomingo { get; set; }

        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
        public virtual ICollection<Sucursal> Sucursals { get; set; }
    }
}
