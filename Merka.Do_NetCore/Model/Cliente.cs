using System;
using System.Collections.Generic;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class Cliente
    {
        public Cliente()
        {
            Comentarios = new HashSet<Comentario>();
            ComprobanteFiscals = new HashSet<ComprobanteFiscal>();
            Entregas = new HashSet<Entrega>();
            Facturas = new HashSet<Factura>();
            HistorialCompras = new HashSet<HistorialCompra>();
            ListadoPaqueteCompras = new HashSet<ListadoPaqueteCompra>();
            LogActionClientes = new HashSet<LogActionCliente>();
            Mensajes = new HashSet<Mensaje>();
            Notificacions = new HashSet<Notificacion>();
            SalaUsuarios = new HashSet<SalaUsuario>();
            StatusCompras = new HashSet<StatusCompra>();
            TarjetaMembresia = new HashSet<TarjetaMembresium>();
            TarjetaRegalos = new HashSet<TarjetaRegalo>();
        }

        public int ClienteId { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string ImagenCliente { get; set; }
        public string TeléfonoCliente { get; set; }
        public int CódigoPostalCliente { get; set; }
        public DateTime FechaNacimientoCliente { get; set; }
        public int GeneroId { get; set; }
        public int TipoDocumentoId { get; set; }
        public string NumeroDocumentoCliente { get; set; }
        public string CorreoCliente { get; set; }
        public string ContraseñaCliente { get; set; }
        public bool Estado { get; set; }
        public bool EmailMarketing { get; set; }

        public virtual Genero Genero { get; set; }
        public virtual TipoDocumento TipoDocumento { get; set; }
        public virtual ICollection<Comentario> Comentarios { get; set; }
        public virtual ICollection<ComprobanteFiscal> ComprobanteFiscals { get; set; }
        public virtual ICollection<Entrega> Entregas { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<HistorialCompra> HistorialCompras { get; set; }
        public virtual ICollection<ListadoPaqueteCompra> ListadoPaqueteCompras { get; set; }
        public virtual ICollection<LogActionCliente> LogActionClientes { get; set; }
        public virtual ICollection<Mensaje> Mensajes { get; set; }
        public virtual ICollection<Notificacion> Notificacions { get; set; }
        public virtual ICollection<SalaUsuario> SalaUsuarios { get; set; }
        public virtual ICollection<StatusCompra> StatusCompras { get; set; }
        public virtual ICollection<TarjetaMembresium> TarjetaMembresia { get; set; }
        public virtual ICollection<TarjetaRegalo> TarjetaRegalos { get; set; }
    }
}
