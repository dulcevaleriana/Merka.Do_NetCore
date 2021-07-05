using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class Comentario
    {
        public int ComentarioId { get; set; }
        public int ClienteId { get; set; }
        public int ProductoId { get; set; }
        public short EstrellaComentario { get; set; }
        public string MensajeComentario { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
