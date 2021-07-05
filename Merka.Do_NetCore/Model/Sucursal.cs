using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class Sucursal
    {
        public Sucursal()
        {
            Productos = new HashSet<Producto>();
            Usuarios = new HashSet<Usuario>();
        }

        public int SucursalId { get; set; }
        public string NombreSucursal { get; set; }
        public string DireccionSucursal { get; set; }
        public int SupermercadoId { get; set; }
        public DateTime HorarioApertura { get; set; }
        public DateTime HorarioCierre { get; set; }
        public bool DiaFeriado { get; set; }
        public DateTime HorarioAperturaSabado { get; set; }
        public DateTime HorarioCierreSabado { get; set; }
        public DateTime HorarioAperturaDomingo { get; set; }
        public DateTime HorarioCierreDomingo { get; set; }

        public virtual Supermercado Supermercado { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
