using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace dbfirst.Models
{
    public partial class ferreteriaContext : DbContext
    {
        public ferreteriaContext()
        {
        }

        public ferreteriaContext(DbContextOptions<ferreteriaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Abono> Abonos { get; set; }
        public virtual DbSet<AumentosDeuda> AumentosDeudas { get; set; }
        public virtual DbSet<CAbonoEstado> CAbonoEstados { get; set; }
        public virtual DbSet<CDeudaEstado> CDeudaEstados { get; set; }
        public virtual DbSet<CEntradaEstado> CEntradaEstados { get; set; }
        public virtual DbSet<CEstadoCliente> CEstadoClientes { get; set; }
        public virtual DbSet<CEstadoVentum> CEstadoVenta { get; set; }
        public virtual DbSet<CProductoEstado> CProductoEstados { get; set; }
        public virtual DbSet<CProductoTipo> CProductoTipos { get; set; }
        public virtual DbSet<CProveedorEstado> CProveedorEstados { get; set; }
        public virtual DbSet<CTipoVentum> CTipoVenta { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<DetalleEntrada> DetalleEntradas { get; set; }
        public virtual DbSet<DetalleVenta> DetalleVentas { get; set; }
        public virtual DbSet<Deuda> Deudas { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Entrada> Entradas { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Proveedore> Proveedores { get; set; }
        public virtual DbSet<Venta> Ventas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("data source=PAULVELIZ-WINDO\\SQLEXPRESS01;initial catalog=ferreteria;integrated security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Abono>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("comentario");

                entity.Property(e => e.Estatus).HasColumnName("estatus");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.Hora).HasColumnName("hora");

                entity.Property(e => e.IdDeuda).HasColumnName("idDeuda");

                entity.Property(e => e.Importe)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("importe");

                entity.HasOne(d => d.EstatusNavigation)
                    .WithMany(p => p.Abonos)
                    .HasForeignKey(d => d.Estatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Abonos__estatus__66603565");

                entity.HasOne(d => d.IdDeudaNavigation)
                    .WithMany(p => p.Abonos)
                    .HasForeignKey(d => d.IdDeuda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Abonos__idDeuda__6754599E");
            });

            modelBuilder.Entity<AumentosDeuda>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Estatus).HasColumnName("estatus");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.Hora).HasColumnName("hora");

                entity.Property(e => e.IdDeuda).HasColumnName("idDeuda");

                entity.Property(e => e.Importe)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("importe");

                entity.HasOne(d => d.IdDeudaNavigation)
                    .WithMany(p => p.AumentosDeuda)
                    .HasForeignKey(d => d.IdDeuda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AumentosD__idDeu__6B24EA82");
            });

            modelBuilder.Entity<CAbonoEstado>(entity =>
            {
                entity.ToTable("cAbonoEstado");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<CDeudaEstado>(entity =>
            {
                entity.ToTable("cDeudaEstado");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<CEntradaEstado>(entity =>
            {
                entity.ToTable("cEntradaEstado");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<CEstadoCliente>(entity =>
            {
                entity.ToTable("cEstadoCliente");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<CEstadoVentum>(entity =>
            {
                entity.ToTable("cEstadoVenta");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<CProductoEstado>(entity =>
            {
                entity.ToTable("cProductoEstado");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<CProductoTipo>(entity =>
            {
                entity.ToTable("cProductoTipo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<CProveedorEstado>(entity =>
            {
                entity.ToTable("cProveedorEstado");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<CTipoVentum>(entity =>
            {
                entity.ToTable("cTipoVenta");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Estatus).HasColumnName("estatus");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(55)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("telefono");

                entity.HasOne(d => d.EstatusNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.Estatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Clientes__estatu__35BCFE0A");
            });

            modelBuilder.Entity<DetalleEntrada>(entity =>
            {
                entity.ToTable("Detalle_entradas");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("cantidad");

                entity.Property(e => e.Costo)
                    .HasColumnType("numeric(8, 2)")
                    .HasColumnName("costo");

                entity.Property(e => e.IdEntrada).HasColumnName("idEntrada");

                entity.Property(e => e.IdProducto).HasColumnName("idProducto");

                entity.Property(e => e.Importe)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("importe");

                entity.Property(e => e.Precio)
                    .HasColumnType("numeric(8, 2)")
                    .HasColumnName("precio");

                entity.HasOne(d => d.IdEntradaNavigation)
                    .WithMany(p => p.DetalleEntrada)
                    .HasForeignKey(d => d.IdEntrada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Detalle_e__idEnt__4CA06362");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.DetalleEntrada)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Detalle_e__idPro__4D94879B");
            });

            modelBuilder.Entity<DetalleVenta>(entity =>
            {
                entity.ToTable("Detalle_ventas");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("numeric(8, 2)")
                    .HasColumnName("cantidad");

                entity.Property(e => e.Costo)
                    .HasColumnType("numeric(8, 2)")
                    .HasColumnName("costo");

                entity.Property(e => e.IdProducto).HasColumnName("idProducto");

                entity.Property(e => e.IdVenta).HasColumnName("idVenta");

                entity.Property(e => e.Precio)
                    .HasColumnType("numeric(8, 2)")
                    .HasColumnName("precio");

                entity.Property(e => e.Total)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("total");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.DetalleVenta)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Detalle_v__idPro__5DCAEF64");

                entity.HasOne(d => d.IdVentaNavigation)
                    .WithMany(p => p.DetalleVenta)
                    .HasForeignKey(d => d.IdVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Detalle_v__idVen__5CD6CB2B");
            });

            modelBuilder.Entity<Deuda>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Estatus).HasColumnName("estatus");

                entity.Property(e => e.IdVenta).HasColumnName("idVenta");

                entity.Property(e => e.Importe)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("importe");

                entity.HasOne(d => d.EstatusNavigation)
                    .WithMany(p => p.Deuda)
                    .HasForeignKey(d => d.Estatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Deudas__estatus__628FA481");

                entity.HasOne(d => d.IdVentaNavigation)
                    .WithMany(p => p.Deuda)
                    .HasForeignKey(d => d.IdVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Deudas__idVenta__619B8048");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Estatus).HasColumnName("estatus");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(55)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("pass");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("usuario");

                entity.HasOne(d => d.EstatusNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.Estatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Empleados__estat__403A8C7D");
            });

            modelBuilder.Entity<Entrada>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Estatus).HasColumnName("estatus");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.Hora).HasColumnName("hora");

                entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");

                entity.Property(e => e.IdProveedor).HasColumnName("idProveedor");

                entity.Property(e => e.Importe)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("importe");

                entity.HasOne(d => d.EstatusNavigation)
                    .WithMany(p => p.Entrada)
                    .HasForeignKey(d => d.Estatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Entradas__estatu__440B1D61");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.Entrada)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Entradas__idEmpl__44FF419A");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.Entrada)
                    .HasForeignKey(d => d.IdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Entradas__idProv__45F365D3");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.Costo)
                    .HasColumnType("numeric(8, 2)")
                    .HasColumnName("costo");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estatus).HasColumnName("estatus");

                entity.Property(e => e.Existencias)
                    .HasColumnType("numeric(8, 2)")
                    .HasColumnName("existencias");

                entity.Property(e => e.IdProveedor).HasColumnName("idProveedor");

                entity.Property(e => e.Precio)
                    .HasColumnType("numeric(8, 2)")
                    .HasColumnName("precio");

                entity.Property(e => e.Tipo).HasColumnName("tipo");

                entity.HasOne(d => d.EstatusNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.Estatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Productos__estat__3C69FB99");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Productos__idPro__3B75D760");

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.Tipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Productos__tipo__3D5E1FD2");
            });

            modelBuilder.Entity<Proveedore>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Estatus).HasColumnName("estatus");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(55)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.EstatusNavigation)
                    .WithMany(p => p.Proveedores)
                    .HasForeignKey(d => d.Estatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Proveedor__estat__38996AB5");
            });

            modelBuilder.Entity<Venta>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("comentario");

                entity.Property(e => e.CostosExtra)
                    .HasColumnType("numeric(8, 2)")
                    .HasColumnName("costos_extra");

                entity.Property(e => e.Descuento)
                    .HasColumnType("numeric(8, 2)")
                    .HasColumnName("descuento");

                entity.Property(e => e.Estatus).HasColumnName("estatus");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.Hora).HasColumnName("hora");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");

                entity.Property(e => e.PrecioEntrega)
                    .HasColumnType("numeric(8, 2)")
                    .HasColumnName("precio_entrega");

                entity.Property(e => e.Tipo).HasColumnName("tipo");

                entity.HasOne(d => d.EstatusNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.Estatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ventas__estatus__5629CD9C");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ventas__idClient__534D60F1");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ventas__idEmplea__5441852A");

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.Tipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ventas__tipo__5535A963");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
