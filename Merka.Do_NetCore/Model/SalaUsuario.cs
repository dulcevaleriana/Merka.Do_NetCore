using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class SalaUsuario
    {
        public int SalaUsuarioId { get; set; }
        public int SalaId { get; set; }
        public int? UsuarioId { get; set; }
        public int? ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Sala Sala { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
