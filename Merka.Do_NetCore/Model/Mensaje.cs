using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class Mensaje
    {
        public int MensajeId { get; set; }
        public int? UsuarioId { get; set; }
        public int? ClienteId { get; set; }
        public int SalaId { get; set; }
        public string Mensaje1 { get; set; }
        public DateTime Fecha { get; set; }
        public int TipoMensajeId { get; set; }
        public int TipoSalaId { get; set; }
        public string UrlLink { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Sala Sala { get; set; }
        public virtual TipoMensaje TipoMensaje { get; set; }
        public virtual TipoSala TipoSala { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
