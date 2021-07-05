using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class TipoStatusCompra
    {
        public TipoStatusCompra()
        {
            Entregas = new HashSet<Entrega>();
            StatusCompras = new HashSet<StatusCompra>();
        }

        public int StatusTipoCompraId { get; set; }
        public string NombreStatusTipoCompra { get; set; }

        public virtual ICollection<Entrega> Entregas { get; set; }
        public virtual ICollection<StatusCompra> StatusCompras { get; set; }
    }
}
