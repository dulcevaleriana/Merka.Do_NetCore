using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class TipoSala
    {
        public TipoSala()
        {
            Mensajes = new HashSet<Mensaje>();
            Salas = new HashSet<Sala>();
        }

        public int TipoSalaId { get; set; }
        public string NombreSala { get; set; }

        public virtual ICollection<Mensaje> Mensajes { get; set; }
        public virtual ICollection<Sala> Salas { get; set; }
    }
}
