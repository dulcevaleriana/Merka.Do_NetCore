using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class CorreoEmailMarketing
    {
        public int CorreoEmailMarketingId { get; set; }
        public string TituloMensaje { get; set; }
        public string ImagenCorreoEmailMarketing { get; set; }
        public string ContenidoCorreoEmailMarketing { get; set; }
        public DateTime FechaCreacionCorreoEmailMarketing { get; set; }
    }
}
