using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class TipoMensaje
    {
        public TipoMensaje()
        {
            Mensajes = new HashSet<Mensaje>();
        }

        public int TipoMensajeId { get; set; }
        public string NombreTipoMensaje { get; set; }

        public virtual ICollection<Mensaje> Mensajes { get; set; }
    }
}
