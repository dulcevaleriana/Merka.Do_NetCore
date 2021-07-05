using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class Usuario
    {
        public Usuario()
        {
            Descuentos = new HashSet<Descuento>();
            Entregas = new HashSet<Entrega>();
            LogActionUsuarios = new HashSet<LogActionUsuario>();
            Mensajes = new HashSet<Mensaje>();
            SalaUsuarios = new HashSet<SalaUsuario>();
        }

        public int UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public string ImagenUsuario { get; set; }
        public string CedulaUsuario { get; set; }
        public int GeneroId { get; set; }
        public string CorreoCorporativoUsuario { get; set; }
        public string TelefonoUsuario { get; set; }
        public int SucursalId { get; set; }
        public int RolId { get; set; }

        public virtual Genero Genero { get; set; }
        public virtual RolUsuario Rol { get; set; }
        public virtual Sucursal Sucursal { get; set; }
        public virtual ICollection<Descuento> Descuentos { get; set; }
        public virtual ICollection<Entrega> Entregas { get; set; }
        public virtual ICollection<LogActionUsuario> LogActionUsuarios { get; set; }
        public virtual ICollection<Mensaje> Mensajes { get; set; }
        public virtual ICollection<SalaUsuario> SalaUsuarios { get; set; }
    }
}
