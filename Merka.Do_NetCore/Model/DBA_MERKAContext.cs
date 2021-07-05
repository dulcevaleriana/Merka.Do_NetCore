using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Merka.Do_NetCore.Model
{
    public partial class DBA_MERKAContext : DbContext
    {
        public DBA_MERKAContext()
        {
        }

        public DBA_MERKAContext(DbContextOptions<DBA_MERKAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CarritoCompra> CarritoCompras { get; set; }
        public virtual DbSet<CategoriaProducto> CategoriaProductos { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Comentario> Comentarios { get; set; }
        public virtual DbSet<Compra> Compras { get; set; }
        public virtual DbSet<ComprobanteFiscal> ComprobanteFiscals { get; set; }
        public virtual DbSet<CorreoEmailMarketing> CorreoEmailMarketings { get; set; }
        public virtual DbSet<Cupone> Cupones { get; set; }
        public virtual DbSet<Descuento> Descuentos { get; set; }
        public virtual DbSet<DiaFeriado> DiaFeriados { get; set; }
        public virtual DbSet<Entrega> Entregas { get; set; }
        public virtual DbSet<Estadistica> Estadisticas { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<Genero> Generos { get; set; }
        public virtual DbSet<HistorialCompra> HistorialCompras { get; set; }
        public virtual DbSet<ListaProducto> ListaProductos { get; set; }
        public virtual DbSet<ListadoPaqueteCompra> ListadoPaqueteCompras { get; set; }
        public virtual DbSet<LogActionCliente> LogActionClientes { get; set; }
        public virtual DbSet<LogActionUsuario> LogActionUsuarios { get; set; }
        public virtual DbSet<Mensaje> Mensajes { get; set; }
        public virtual DbSet<MetodoEnvio> MetodoEnvios { get; set; }
        public virtual DbSet<Notificacion> Notificacions { get; set; }
        public virtual DbSet<PreguntasFrecuente> PreguntasFrecuentes { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<RolUsuario> RolUsuarios { get; set; }
        public virtual DbSet<Sala> Salas { get; set; }
        public virtual DbSet<SalaUsuario> SalaUsuarios { get; set; }
        public virtual DbSet<SobreNosotro> SobreNosotros { get; set; }
        public virtual DbSet<StatusCompra> StatusCompras { get; set; }
        public virtual DbSet<Sucursal> Sucursals { get; set; }
        public virtual DbSet<Supermercado> Supermercados { get; set; }
        public virtual DbSet<TarjetaMembresium> TarjetaMembresia { get; set; }
        public virtual DbSet<TarjetaRegalo> TarjetaRegalos { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }
        public virtual DbSet<TipoEstadistica> TipoEstadisticas { get; set; }
        public virtual DbSet<TipoMensaje> TipoMensajes { get; set; }
        public virtual DbSet<TipoNotificacion> TipoNotificacions { get; set; }
        public virtual DbSet<TipoSala> TipoSalas { get; set; }
        public virtual DbSet<TipoStatusCompra> TipoStatusCompras { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-BAAGREU;Database=DBA_MERKA;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<CarritoCompra>(entity =>
            {
                entity.HasKey(e => e.CarritoComprasId)
                    .HasName("PK__CARRITO___64951FD1A16FCC03");

                entity.ToTable("CARRITO_COMPRAS_");

                entity.Property(e => e.CarritoComprasId).HasColumnName("carritoComprasId");

                entity.Property(e => e.ListaProductosId).HasColumnName("listaProductosId");

                entity.Property(e => e.TotalPago)
                    .HasColumnType("money")
                    .HasColumnName("totalPago");

                entity.HasOne(d => d.ListaProductos)
                    .WithMany(p => p.CarritoCompras)
                    .HasForeignKey(d => d.ListaProductosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CARRITO_C__lista__10566F31");
            });

            modelBuilder.Entity<CategoriaProducto>(entity =>
            {
                entity.ToTable("CATEGORIA_PRODUCTO");

                entity.Property(e => e.CategoriaProductoId).HasColumnName("categoriaProductoId");

                entity.Property(e => e.NombrecategoriaProducto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombrecategoriaProducto");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("CLIENTES__");

                entity.Property(e => e.ApellidoCliente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellidoCliente");

                entity.Property(e => e.ContraseñaCliente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contraseñaCliente");

                entity.Property(e => e.CorreoCliente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correoCliente");

                entity.Property(e => e.CódigoPostalCliente).HasColumnName("códigoPostalCliente");

                entity.Property(e => e.EmailMarketing).HasColumnName("emailMarketing");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaNacimientoCliente)
                    .HasColumnType("date")
                    .HasColumnName("fechaNacimientoCliente");

                entity.Property(e => e.GeneroId).HasColumnName("generoId");

                entity.Property(e => e.ImagenCliente)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("imagenCliente");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreCliente");

                entity.Property(e => e.NumeroDocumentoCliente)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("numeroDocumentoCliente");

                entity.Property(e => e.TeléfonoCliente)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("teléfonoCliente");

                entity.Property(e => e.TipoDocumentoId).HasColumnName("tipoDocumentoId");

                entity.HasOne(d => d.Genero)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.GeneroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CLIENTES___gener__797309D9");

                entity.HasOne(d => d.TipoDocumento)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.TipoDocumentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CLIENTES___tipoD__7A672E12");
            });

            modelBuilder.Entity<Comentario>(entity =>
            {
                entity.ToTable("COMENTARIO");

                entity.Property(e => e.ComentarioId).HasColumnName("comentarioId");

                entity.Property(e => e.EstrellaComentario).HasColumnName("estrellaComentario");

                entity.Property(e => e.MensajeComentario)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("mensajeComentario");

                entity.Property(e => e.ProductoId).HasColumnName("productoId");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Comentarios)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__COMENTARI__Clien__1F98B2C1");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.Comentarios)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__COMENTARI__produ__208CD6FA");
            });

            modelBuilder.Entity<Compra>(entity =>
            {
                entity.HasKey(e => e.ComprasId)
                    .HasName("PK__COMPRA____6E7476FE25E462B3");

                entity.ToTable("COMPRA__");

                entity.Property(e => e.ComprasId).HasColumnName("comprasId");

                entity.Property(e => e.CarritoComprasId).HasColumnName("carritoComprasId");

                entity.Property(e => e.CuponesId).HasColumnName("cuponesId");

                entity.Property(e => e.DescuentoId).HasColumnName("descuentoId");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.MetodoEnvioId).HasColumnName("metodoEnvioId");

                entity.Property(e => e.PrecioInicialCompra)
                    .HasColumnType("money")
                    .HasColumnName("precioInicialCompra");

                entity.Property(e => e.SubTotalCompraItbis)
                    .HasColumnType("money")
                    .HasColumnName("subTotalCompraITBIS");

                entity.Property(e => e.TotalPago)
                    .HasColumnType("money")
                    .HasColumnName("totalPago");

                entity.HasOne(d => d.CarritoCompras)
                    .WithMany(p => p.Compras)
                    .HasForeignKey(d => d.CarritoComprasId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__COMPRA____carrit__03F0984C");

                entity.HasOne(d => d.Cupones)
                    .WithMany(p => p.Compras)
                    .HasForeignKey(d => d.CuponesId)
                    .HasConstraintName("FK__COMPRA____cupone__04E4BC85");

                entity.HasOne(d => d.Descuento)
                    .WithMany(p => p.Compras)
                    .HasForeignKey(d => d.DescuentoId)
                    .HasConstraintName("FK__COMPRA____descue__05D8E0BE");

                entity.HasOne(d => d.MetodoEnvio)
                    .WithMany(p => p.Compras)
                    .HasForeignKey(d => d.MetodoEnvioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__COMPRA____metodo__06CD04F7");
            });

            modelBuilder.Entity<ComprobanteFiscal>(entity =>
            {
                entity.ToTable("COMPROBANTE_FISCAL");

                entity.Property(e => e.ComprobanteFiscalId).HasColumnName("comprobanteFiscalId");

                entity.Property(e => e.Rnc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("rnc");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.ComprobanteFiscals)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__COMPROBAN__Clien__25518C17");
            });

            modelBuilder.Entity<CorreoEmailMarketing>(entity =>
            {
                entity.ToTable("CORREO_EMAIL_MARKETING_");

                entity.Property(e => e.CorreoEmailMarketingId).HasColumnName("correoEmailMarketingId");

                entity.Property(e => e.ContenidoCorreoEmailMarketing)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("contenidoCorreoEmailMarketing");

                entity.Property(e => e.FechaCreacionCorreoEmailMarketing)
                    .HasColumnType("date")
                    .HasColumnName("fechaCreacionCorreoEmailMarketing");

                entity.Property(e => e.ImagenCorreoEmailMarketing)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("imagenCorreoEmailMarketing");

                entity.Property(e => e.TituloMensaje)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tituloMensaje");
            });

            modelBuilder.Entity<Cupone>(entity =>
            {
                entity.HasKey(e => e.CuponesId)
                    .HasName("PK__CUPONES___C7E98FD97D98B8FF");

                entity.ToTable("CUPONES_");

                entity.Property(e => e.CuponesId).HasColumnName("cuponesId");

                entity.Property(e => e.CodigoCupones)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codigoCupones");

                entity.Property(e => e.DescuentoCupones)
                    .HasColumnType("smallmoney")
                    .HasColumnName("descuentoCupones");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnType("date")
                    .HasColumnName("fechaVencimiento");

                entity.Property(e => e.ImagenCupones)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("imagenCupones");

                entity.Property(e => e.NombreCupones)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreCupones");

                entity.Property(e => e.PrecioDescontar)
                    .HasColumnType("smallmoney")
                    .HasColumnName("precioDescontar");
            });

            modelBuilder.Entity<Descuento>(entity =>
            {
                entity.ToTable("DESCUENTOS_");

                entity.Property(e => e.DescuentoId).HasColumnName("descuentoId");

                entity.Property(e => e.CategoriaProductoId).HasColumnName("categoriaProductoId");

                entity.Property(e => e.DescuentoAplicar)
                    .HasColumnType("smallmoney")
                    .HasColumnName("descuentoAplicar");

                entity.Property(e => e.FechaExpiracionDescuento)
                    .HasColumnType("date")
                    .HasColumnName("fechaExpiracionDescuento");

                entity.Property(e => e.ProductoId).HasColumnName("productoId");

                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.HasOne(d => d.CategoriaProducto)
                    .WithMany(p => p.Descuentos)
                    .HasForeignKey(d => d.CategoriaProductoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DESCUENTO__categ__0C85DE4D");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.Descuentos)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DESCUENTO__produ__0B91BA14");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Descuentos)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DESCUENTO__usuar__0D7A0286");
            });

            modelBuilder.Entity<DiaFeriado>(entity =>
            {
                entity.ToTable("DIA_FERIADO_");

                entity.Property(e => e.DiaFeriadoId).HasColumnName("diaFeriadoId");

                entity.Property(e => e.FechaDiaFeriado)
                    .HasColumnType("date")
                    .HasColumnName("fechaDiaFeriado");

                entity.Property(e => e.HorarioAperturaDiaFeriado)
                    .HasColumnType("datetime")
                    .HasColumnName("horarioAperturaDiaFeriado");

                entity.Property(e => e.HorarioCierreDiaFeriad)
                    .HasColumnType("datetime")
                    .HasColumnName("horarioCierreDiaFeriad");

                entity.Property(e => e.NombreDiaFeriado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreDiaFeriado");

                entity.Property(e => e.SeLabora).HasColumnName("seLabora");
            });

            modelBuilder.Entity<Entrega>(entity =>
            {
                entity.ToTable("ENTREGAS_");

                entity.Property(e => e.EntregaId).HasColumnName("entregaId");

                entity.Property(e => e.ComprasId).HasColumnName("comprasId");

                entity.Property(e => e.FirmaClientePaqueteCompra)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("firmaClientePaqueteCompra");

                entity.Property(e => e.MensajeroEncargadoId).HasColumnName("mensajeroEncargadoId");

                entity.Property(e => e.StatusFirmaEntregaPaqueteCompra).HasColumnName("statusFirmaEntregaPaqueteCompra");

                entity.Property(e => e.StatusTipoCompraId).HasColumnName("statusTipoCompraId");

                entity.Property(e => e.UbicacionActualEntrega)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("ubicacionActualEntrega");

                entity.Property(e => e.UbicacionDestinoEntrega)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("ubicacionDestinoEntrega");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Entregas)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ENTREGAS___Clien__18EBB532");

                entity.HasOne(d => d.Compras)
                    .WithMany(p => p.Entregas)
                    .HasForeignKey(d => d.ComprasId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ENTREGAS___compr__17F790F9");

                entity.HasOne(d => d.MensajeroEncargado)
                    .WithMany(p => p.Entregas)
                    .HasForeignKey(d => d.MensajeroEncargadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ENTREGAS___mensa__19DFD96B");

                entity.HasOne(d => d.StatusTipoCompra)
                    .WithMany(p => p.Entregas)
                    .HasForeignKey(d => d.StatusTipoCompraId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ENTREGAS___statu__1AD3FDA4");
            });

            modelBuilder.Entity<Estadistica>(entity =>
            {
                entity.HasKey(e => e.EstadisticasId)
                    .HasName("PK__ESTADIST__83B4A5333C694216");

                entity.ToTable("ESTADISTICAS_");

                entity.Property(e => e.EstadisticasId).HasColumnName("estadisticasId");

                entity.Property(e => e.DocumentoEstadisticas)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("documentoEstadisticas");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("date")
                    .HasColumnName("fechaCreacion");

                entity.Property(e => e.TipoEstadisticasId).HasColumnName("tipoEstadisticasId");

                entity.HasOne(d => d.TipoEstadisticas)
                    .WithMany(p => p.Estadisticas)
                    .HasForeignKey(d => d.TipoEstadisticasId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ESTADISTI__tipoE__1EA48E88");
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.Factura1)
                    .HasName("PK__FACTURA__B3BC03396F7F52BD");

                entity.ToTable("FACTURA");

                entity.Property(e => e.Factura1).HasColumnName("factura");

                entity.Property(e => e.CarritoComprasId).HasColumnName("carritoComprasId");

                entity.Property(e => e.ComprasId).HasColumnName("comprasId");

                entity.Property(e => e.ComprobanteFiscal).HasColumnName("comprobanteFiscal");

                entity.Property(e => e.ComprobanteFiscalId).HasColumnName("comprobanteFiscalId");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.StatusTarjetaCredito).HasColumnName("statusTarjetaCredito");

                entity.Property(e => e.SupermercadoId).HasColumnName("supermercadoId");

                entity.HasOne(d => d.CarritoCompras)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.CarritoComprasId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FACTURA__carrito__245D67DE");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FACTURA__Cliente__22751F6C");

                entity.HasOne(d => d.Compras)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.ComprasId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FACTURA__compras__236943A5");

                entity.HasOne(d => d.Supermercado)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.SupermercadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FACTURA__superme__2180FB33");
            });

            modelBuilder.Entity<Genero>(entity =>
            {
                entity.ToTable("GENERO");

                entity.Property(e => e.GeneroId).HasColumnName("generoId");

                entity.Property(e => e.NombreGenero)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreGenero");
            });

            modelBuilder.Entity<HistorialCompra>(entity =>
            {
                entity.ToTable("HISTORIAL_COMPRA_");

                entity.Property(e => e.HistorialCompraId).HasColumnName("historialCompraId");

                entity.Property(e => e.CarritoCompraId).HasColumnName("carritoCompraId");

                entity.Property(e => e.EstadoTipoHistorialCompra).HasColumnName("estadoTipoHistorialCompra");

                entity.Property(e => e.FechaEnvio)
                    .HasColumnType("date")
                    .HasColumnName("fechaEnvio");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreCliente");

                entity.Property(e => e.RazonSocialEmpresa)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("razonSocialEmpresa");

                entity.Property(e => e.TotalPago)
                    .HasColumnType("money")
                    .HasColumnName("totalPago");

                entity.HasOne(d => d.CarritoCompra)
                    .WithMany(p => p.HistorialCompras)
                    .HasForeignKey(d => d.CarritoCompraId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HISTORIAL__carri__17036CC0");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.HistorialCompras)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HISTORIAL__Clien__160F4887");
            });

            modelBuilder.Entity<ListaProducto>(entity =>
            {
                entity.HasKey(e => e.ListaProductosId)
                    .HasName("PK__LISTA_PR__555C3C07EF16D8A7");

                entity.ToTable("LISTA_PRODUCTO_");

                entity.Property(e => e.ListaProductosId).HasColumnName("listaProductosId");

                entity.Property(e => e.PrecioProducto)
                    .HasColumnType("money")
                    .HasColumnName("precioProducto");

                entity.Property(e => e.ProductoId).HasColumnName("productoId");

                entity.Property(e => e.TotalPago)
                    .HasColumnType("money")
                    .HasColumnName("totalPago");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.ListaProductos)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LISTA_PRO__produ__114A936A");
            });

            modelBuilder.Entity<ListadoPaqueteCompra>(entity =>
            {
                entity.ToTable("LISTADO_PAQUETE_COMPRA_");

                entity.Property(e => e.ListadoPaqueteCompraId).HasColumnName("listadoPaqueteCompraId");

                entity.Property(e => e.CarritoComprasId).HasColumnName("carritoComprasId");

                entity.Property(e => e.ErrorReportado).HasColumnName("errorReportado");

                entity.Property(e => e.EstadoListadoPaqueteCompra).HasColumnName("estadoListadoPaqueteCompra");

                entity.Property(e => e.FechaCreacionPaqueteCompra)
                    .HasColumnType("date")
                    .HasColumnName("fechaCreacionPaqueteCompra");

                entity.Property(e => e.FirmaClientePaqueteCompra)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("firmaClientePaqueteCompra");

                entity.Property(e => e.MensajePaqueteCompra)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("mensajePaqueteCompra");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreCliente");

                entity.Property(e => e.RazonSocialEmpresa)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("razonSocialEmpresa");

                entity.Property(e => e.StatusFirmaEntregaPaqueteCompra).HasColumnName("statusFirmaEntregaPaqueteCompra");

                entity.Property(e => e.TotalPago)
                    .HasColumnType("money")
                    .HasColumnName("totalPago");

                entity.Property(e => e.UbicacionActualPaqueteCompra)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("ubicacionActualPaqueteCompra");

                entity.Property(e => e.UbicacionDestinoPaqueteCompra)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("ubicacionDestinoPaqueteCompra");

                entity.HasOne(d => d.CarritoCompras)
                    .WithMany(p => p.ListadoPaqueteCompras)
                    .HasForeignKey(d => d.CarritoComprasId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LISTADO_P__carri__1332DBDC");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.ListadoPaqueteCompras)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LISTADO_P__Clien__123EB7A3");
            });

            modelBuilder.Entity<LogActionCliente>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK__LOG_ACTI__5E54864816143380");

                entity.ToTable("LOG_ACTION_CLIENTE");

                entity.Property(e => e.FechaEjecución)
                    .HasColumnType("date")
                    .HasColumnName("fechaEjecución");

                entity.Property(e => e.TipoEstadisticasId).HasColumnName("tipoEstadisticasId");

                entity.Property(e => e.TipoNotificacionId).HasColumnName("tipoNotificacionId");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.LogActionClientes)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LOG_ACTIO__Clien__787EE5A0");

                entity.HasOne(d => d.TipoEstadisticas)
                    .WithMany(p => p.LogActionClientes)
                    .HasForeignKey(d => d.TipoEstadisticasId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LOG_ACTIO__tipoE__778AC167");

                entity.HasOne(d => d.TipoNotificacion)
                    .WithMany(p => p.LogActionClientes)
                    .HasForeignKey(d => d.TipoNotificacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LOG_ACTIO__tipoN__76969D2E");
            });

            modelBuilder.Entity<LogActionUsuario>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK__LOG_ACTI__5E54864898784966");

                entity.ToTable("LOG_ACTION_USUARIO");

                entity.Property(e => e.FechaEjecución)
                    .HasColumnType("date")
                    .HasColumnName("fechaEjecución");

                entity.Property(e => e.RolId).HasColumnName("rolId");

                entity.Property(e => e.TipoEstadisticasId).HasColumnName("tipoEstadisticasId");

                entity.Property(e => e.TipoNotificacionId).HasColumnName("tipoNotificacionId");

                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.LogActionUsuarios)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LOG_ACTIO__rolId__75A278F5");

                entity.HasOne(d => d.TipoEstadisticas)
                    .WithMany(p => p.LogActionUsuarios)
                    .HasForeignKey(d => d.TipoEstadisticasId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LOG_ACTIO__tipoE__73BA3083");

                entity.HasOne(d => d.TipoNotificacion)
                    .WithMany(p => p.LogActionUsuarios)
                    .HasForeignKey(d => d.TipoNotificacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LOG_ACTIO__tipoN__72C60C4A");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.LogActionUsuarios)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LOG_ACTIO__usuar__74AE54BC");
            });

            modelBuilder.Entity<Mensaje>(entity =>
            {
                entity.ToTable("MENSAJE__");

                entity.Property(e => e.MensajeId).HasColumnName("mensajeId");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.Mensaje1)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("mensaje");

                entity.Property(e => e.SalaId).HasColumnName("salaId");

                entity.Property(e => e.TipoMensajeId).HasColumnName("tipoMensajeId");

                entity.Property(e => e.TipoSalaId).HasColumnName("tipoSalaId");

                entity.Property(e => e.UrlLink)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("url_link");

                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Mensajes)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("FK__MENSAJE____Clien__7C4F7684");

                entity.HasOne(d => d.Sala)
                    .WithMany(p => p.Mensajes)
                    .HasForeignKey(d => d.SalaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MENSAJE____salaI__7D439ABD");

                entity.HasOne(d => d.TipoMensaje)
                    .WithMany(p => p.Mensajes)
                    .HasForeignKey(d => d.TipoMensajeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MENSAJE____tipoM__7E37BEF6");

                entity.HasOne(d => d.TipoSala)
                    .WithMany(p => p.Mensajes)
                    .HasForeignKey(d => d.TipoSalaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MENSAJE____tipoS__7F2BE32F");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Mensajes)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK__MENSAJE____usuar__7B5B524B");
            });

            modelBuilder.Entity<MetodoEnvio>(entity =>
            {
                entity.ToTable("METODO_ENVIO");

                entity.Property(e => e.MetodoEnvioId).HasColumnName("metodoEnvioId");

                entity.Property(e => e.DescripcionMetodoEnvio)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcionMetodoEnvio");

                entity.Property(e => e.NombreMetodoEnvio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreMetodoEnvio");
            });

            modelBuilder.Entity<Notificacion>(entity =>
            {
                entity.ToTable("NOTIFICACION_");

                entity.Property(e => e.NotificacionId).HasColumnName("notificacionId");

                entity.Property(e => e.FechaNotificacion)
                    .HasColumnType("date")
                    .HasColumnName("fechaNotificacion");

                entity.Property(e => e.MensajeNotificacion)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("mensajeNotificacion");

                entity.Property(e => e.RolId).HasColumnName("rolId");

                entity.Property(e => e.TipoNotificacionId).HasColumnName("tipoNotificacionId");

                entity.Property(e => e.UsuarioReceptorId).HasColumnName("usuarioReceptorId");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.Notificacions)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NOTIFICAC__rolId__1BC821DD");

                entity.HasOne(d => d.TipoNotificacion)
                    .WithMany(p => p.Notificacions)
                    .HasForeignKey(d => d.TipoNotificacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NOTIFICAC__tipoN__1CBC4616");

                entity.HasOne(d => d.UsuarioReceptor)
                    .WithMany(p => p.Notificacions)
                    .HasForeignKey(d => d.UsuarioReceptorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NOTIFICAC__usuar__1DB06A4F");
            });

            modelBuilder.Entity<PreguntasFrecuente>(entity =>
            {
                entity.HasKey(e => e.PreguntasFrecuentesId)
                    .HasName("PK__PREGUNTA__527F45FB8F1316EF");

                entity.ToTable("PREGUNTAS_FRECUENTES_");

                entity.Property(e => e.PreguntasFrecuentesId).HasColumnName("preguntasFrecuentesId");

                entity.Property(e => e.PreguntaPreguntasFrecuentes)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("preguntaPreguntasFrecuentes");

                entity.Property(e => e.RespuestaPreguntasFrecuentes)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("respuestaPreguntasFrecuentes");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.ToTable("PRODUCTO__");

                entity.Property(e => e.ProductoId).HasColumnName("productoId");

                entity.Property(e => e.CantidadProducto).HasColumnName("cantidadProducto");

                entity.Property(e => e.CategoriaProductoId).HasColumnName("categoriaProductoId");

                entity.Property(e => e.DescripcionProducto)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcionProducto");

                entity.Property(e => e.DescuentoId).HasColumnName("descuentoId");

                entity.Property(e => e.ImagenProducto)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("imagenProducto");

                entity.Property(e => e.NombreProducto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreProducto");

                entity.Property(e => e.PrecioAnterior)
                    .HasColumnType("money")
                    .HasColumnName("precioAnterior");

                entity.Property(e => e.PrecioProducto)
                    .HasColumnType("money")
                    .HasColumnName("precioProducto");

                entity.Property(e => e.SucursalId).HasColumnName("sucursalId");

                entity.Property(e => e.SupermercadoId).HasColumnName("supermercadoId");

                entity.Property(e => e.TablaNutricionalProductoImg)
                    .IsUnicode(false)
                    .HasColumnName("tablaNutricionalProductoIMG");

                entity.HasOne(d => d.CategoriaProducto)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.CategoriaProductoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PRODUCTO___categ__09A971A2");

                entity.HasOne(d => d.Descuento)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.DescuentoId)
                    .HasConstraintName("FK__PRODUCTO___descu__0A9D95DB");

                entity.HasOne(d => d.Sucursal)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.SucursalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PRODUCTO___sucur__07C12930");

                entity.HasOne(d => d.Supermercado)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.SupermercadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PRODUCTO___super__08B54D69");
            });

            modelBuilder.Entity<RolUsuario>(entity =>
            {
                entity.HasKey(e => e.RolId)
                    .HasName("PK__ROL_USUA__540236340E742F43");

                entity.ToTable("ROL_USUARIO");

                entity.Property(e => e.RolId).HasColumnName("rolId");

                entity.Property(e => e.NombreRol)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreRol");
            });

            modelBuilder.Entity<Sala>(entity =>
            {
                entity.ToTable("SALA__");

                entity.Property(e => e.SalaId).HasColumnName("salaId");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.TipoSalaId).HasColumnName("tipoSalaId");

                entity.HasOne(d => d.TipoSala)
                    .WithMany(p => p.Salas)
                    .HasForeignKey(d => d.TipoSalaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SALA____tipoSala__00200768");
            });

            modelBuilder.Entity<SalaUsuario>(entity =>
            {
                entity.ToTable("SALA_USUARIO__");

                entity.Property(e => e.SalaUsuarioId).HasColumnName("salaUsuarioId");

                entity.Property(e => e.SalaId).HasColumnName("salaId");

                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.SalaUsuarios)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("FK__SALA_USUA__Clien__02FC7413");

                entity.HasOne(d => d.Sala)
                    .WithMany(p => p.SalaUsuarios)
                    .HasForeignKey(d => d.SalaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SALA_USUA__salaI__01142BA1");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.SalaUsuarios)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK__SALA_USUA__usuar__02084FDA");
            });

            modelBuilder.Entity<SobreNosotro>(entity =>
            {
                entity.HasKey(e => e.SobreNosotrosId)
                    .HasName("PK__SOBRE_NO__5042C1D0CB09D676");

                entity.ToTable("SOBRE_NOSOTROS_");

                entity.Property(e => e.SobreNosotrosId).HasColumnName("sobreNosotrosId");

                entity.Property(e => e.MisionSobreNosotros)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("misionSobreNosotros");

                entity.Property(e => e.QuienesSomosSobreNosotros)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("quienesSomosSobreNosotros");

                entity.Property(e => e.ValoresSobreNosotros)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("valoresSobreNosotros");

                entity.Property(e => e.VisionSobreNosotros)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("visionSobreNosotros");
            });

            modelBuilder.Entity<StatusCompra>(entity =>
            {
                entity.ToTable("STATUS_COMPRA_");

                entity.Property(e => e.StatusCompraId).HasColumnName("statusCompraId");

                entity.Property(e => e.CarritoComprasId).HasColumnName("carritoComprasId");

                entity.Property(e => e.MensajeroStatusCompra).HasColumnName("mensajeroStatusCompra");

                entity.Property(e => e.NombreCliente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreCliente");

                entity.Property(e => e.RazonSocialEmpresa)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("razonSocialEmpresa");

                entity.Property(e => e.StatusTipoCompraId).HasColumnName("statusTipoCompraId");

                entity.Property(e => e.TotalPago)
                    .HasColumnType("money")
                    .HasColumnName("totalPago");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.StatusCompras)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STATUS_CO__Clien__14270015");

                entity.HasOne(d => d.StatusTipoCompra)
                    .WithMany(p => p.StatusCompras)
                    .HasForeignKey(d => d.StatusTipoCompraId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STATUS_CO__statu__151B244E");
            });

            modelBuilder.Entity<Sucursal>(entity =>
            {
                entity.ToTable("SUCURSAL_");

                entity.Property(e => e.SucursalId).HasColumnName("sucursalId");

                entity.Property(e => e.DiaFeriado).HasColumnName("diaFeriado");

                entity.Property(e => e.DireccionSucursal)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("direccionSucursal");

                entity.Property(e => e.HorarioApertura)
                    .HasColumnType("datetime")
                    .HasColumnName("horarioApertura");

                entity.Property(e => e.HorarioAperturaDomingo)
                    .HasColumnType("datetime")
                    .HasColumnName("horarioAperturaDomingo");

                entity.Property(e => e.HorarioAperturaSabado)
                    .HasColumnType("datetime")
                    .HasColumnName("horarioAperturaSabado");

                entity.Property(e => e.HorarioCierre)
                    .HasColumnType("datetime")
                    .HasColumnName("horarioCierre");

                entity.Property(e => e.HorarioCierreDomingo)
                    .HasColumnType("datetime")
                    .HasColumnName("horarioCierreDomingo");

                entity.Property(e => e.HorarioCierreSabado)
                    .HasColumnType("datetime")
                    .HasColumnName("horarioCierreSabado");

                entity.Property(e => e.NombreSucursal)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreSucursal");

                entity.Property(e => e.SupermercadoId).HasColumnName("supermercadoId");

                entity.HasOne(d => d.Supermercado)
                    .WithMany(p => p.Sucursals)
                    .HasForeignKey(d => d.SupermercadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SUCURSAL___super__6EF57B66");
            });

            modelBuilder.Entity<Supermercado>(entity =>
            {
                entity.ToTable("SUPERMERCADO_");

                entity.Property(e => e.SupermercadoId).HasColumnName("supermercadoId");

                entity.Property(e => e.DiaFeriado).HasColumnName("diaFeriado");

                entity.Property(e => e.DireccionSupermercado)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("direccionSupermercado");

                entity.Property(e => e.HorarioApertura)
                    .HasColumnType("datetime")
                    .HasColumnName("horarioApertura");

                entity.Property(e => e.HorarioAperturaDomingo)
                    .HasColumnType("datetime")
                    .HasColumnName("horarioAperturaDomingo");

                entity.Property(e => e.HorarioAperturaSabado)
                    .HasColumnType("datetime")
                    .HasColumnName("horarioAperturaSabado");

                entity.Property(e => e.HorarioCierre)
                    .HasColumnType("datetime")
                    .HasColumnName("horarioCierre");

                entity.Property(e => e.HorarioCierreDomingo)
                    .HasColumnType("datetime")
                    .HasColumnName("horarioCierreDomingo");

                entity.Property(e => e.HorarioCierreSabado)
                    .HasColumnType("datetime")
                    .HasColumnName("horarioCierreSabado");

                entity.Property(e => e.NombreSupermercado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreSupermercado");
            });

            modelBuilder.Entity<TarjetaMembresium>(entity =>
            {
                entity.HasKey(e => e.TarjetaMembresiaId)
                    .HasName("PK__TARJETA___5EC7FD873ADC642D");

                entity.ToTable("TARJETA_MEMBRESIA_");

                entity.Property(e => e.TarjetaMembresiaId).HasColumnName("tarjetaMembresiaId");

                entity.Property(e => e.FechaVencimientoTarjetaMembresia)
                    .HasColumnType("date")
                    .HasColumnName("fechaVencimientoTarjetaMembresia");

                entity.Property(e => e.NombreCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreCliente");

                entity.Property(e => e.PuntosAcumuladosTarjetaMembresia).HasColumnName("puntosAcumuladosTarjetaMembresia");

                entity.Property(e => e.RazonSocialEmpresa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("razonSocialEmpresa");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.TarjetaMembresia)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TARJETA_M__Clien__0E6E26BF");
            });

            modelBuilder.Entity<TarjetaRegalo>(entity =>
            {
                entity.ToTable("TARJETA_REGALO_");

                entity.Property(e => e.TarjetaRegaloId).HasColumnName("tarjetaRegaloId");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnType("date")
                    .HasColumnName("fechaVencimiento");

                entity.Property(e => e.NombreCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreCliente");

                entity.Property(e => e.RazonSocialEmpresa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("razonSocialEmpresa");

                entity.Property(e => e.ValorAcreditarTarjetaRegalo)
                    .HasColumnType("money")
                    .HasColumnName("valorAcreditarTarjetaRegalo");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.TarjetaRegalos)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TARJETA_R__Clien__0F624AF8");
            });

            modelBuilder.Entity<TipoDocumento>(entity =>
            {
                entity.ToTable("TIPO_DOCUMENTO");

                entity.Property(e => e.TipoDocumentoId).HasColumnName("tipoDocumentoId");

                entity.Property(e => e.NombreTipoDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreTipoDocumento");
            });

            modelBuilder.Entity<TipoEstadistica>(entity =>
            {
                entity.HasKey(e => e.TipoEstadisticasId)
                    .HasName("PK__TIPO_EST__570DE4994D4C3E64");

                entity.ToTable("TIPO_ESTADISTICAS_");

                entity.Property(e => e.TipoEstadisticasId).HasColumnName("tipoEstadisticasId");

                entity.Property(e => e.NombreTipoEstadisticas)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreTipoEstadisticas");
            });

            modelBuilder.Entity<TipoMensaje>(entity =>
            {
                entity.ToTable("TIPO_MENSAJE__");

                entity.Property(e => e.TipoMensajeId).HasColumnName("tipoMensajeId");

                entity.Property(e => e.NombreTipoMensaje)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoNotificacion>(entity =>
            {
                entity.ToTable("TIPO_NOTIFICACION_");

                entity.Property(e => e.TipoNotificacionId).HasColumnName("tipoNotificacionId");

                entity.Property(e => e.NombreTipoNotificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreTipoNotificacion");
            });

            modelBuilder.Entity<TipoSala>(entity =>
            {
                entity.ToTable("TIPO_SALA__");

                entity.Property(e => e.TipoSalaId).HasColumnName("tipoSalaId");

                entity.Property(e => e.NombreSala)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreSala");
            });

            modelBuilder.Entity<TipoStatusCompra>(entity =>
            {
                entity.HasKey(e => e.StatusTipoCompraId)
                    .HasName("PK__TIPO_STA__FB5F35E175A55CEA");

                entity.ToTable("TIPO_STATUS_COMPRA");

                entity.Property(e => e.StatusTipoCompraId).HasColumnName("statusTipoCompraId");

                entity.Property(e => e.NombreStatusTipoCompra)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreStatusTipoCompra");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("USUARIO__");

                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.Property(e => e.ApellidoUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellidoUsuario");

                entity.Property(e => e.CedulaUsuario)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("cedulaUsuario");

                entity.Property(e => e.CorreoCorporativoUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correoCorporativoUsuario");

                entity.Property(e => e.GeneroId).HasColumnName("generoId");

                entity.Property(e => e.ImagenUsuario)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("imagenUsuario");

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreUsuario");

                entity.Property(e => e.RolId).HasColumnName("rolId");

                entity.Property(e => e.SucursalId).HasColumnName("sucursalId");

                entity.Property(e => e.TelefonoUsuario)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("telefonoUsuario");

                entity.HasOne(d => d.Genero)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.GeneroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USUARIO____gener__6FE99F9F");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USUARIO____rolId__71D1E811");

                entity.HasOne(d => d.Sucursal)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.SucursalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USUARIO____sucur__70DDC3D8");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
