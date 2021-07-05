using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class TipoDocumento
    {
        public TipoDocumento()
        {
            Clientes = new HashSet<Cliente>();
        }

        public int TipoDocumentoId { get; set; }
        public string NombreTipoDocumento { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
