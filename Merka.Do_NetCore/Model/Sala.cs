using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class Sala
    {
        public Sala()
        {
            Mensajes = new HashSet<Mensaje>();
            SalaUsuarios = new HashSet<SalaUsuario>();
        }

        public int SalaId { get; set; }
        public int TipoSalaId { get; set; }
        public DateTime Fecha { get; set; }

        public virtual TipoSala TipoSala { get; set; }
        public virtual ICollection<Mensaje> Mensajes { get; set; }
        public virtual ICollection<SalaUsuario> SalaUsuarios { get; set; }
    }
}
