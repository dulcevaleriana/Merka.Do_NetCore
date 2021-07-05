using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class ComprobanteFiscal
    {
        public int ComprobanteFiscalId { get; set; }
        public int ClienteId { get; set; }
        public string Rnc { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
