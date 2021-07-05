using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class Cupone
    {
        public Cupone()
        {
            Compras = new HashSet<Compra>();
        }

        public int CuponesId { get; set; }
        public string NombreCupones { get; set; }
        public decimal? DescuentoCupones { get; set; }
        public decimal? PrecioDescontar { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string CodigoCupones { get; set; }
        public string ImagenCupones { get; set; }

        public virtual ICollection<Compra> Compras { get; set; }
    }
}
