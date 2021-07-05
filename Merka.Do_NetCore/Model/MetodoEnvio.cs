using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class MetodoEnvio
    {
        public MetodoEnvio()
        {
            Compras = new HashSet<Compra>();
        }

        public int MetodoEnvioId { get; set; }
        public string NombreMetodoEnvio { get; set; }
        public string DescripcionMetodoEnvio { get; set; }

        public virtual ICollection<Compra> Compras { get; set; }
    }
}
