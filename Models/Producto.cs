using System;
using System.Collections.Generic;

#nullable disable

namespace dbfirst.Models
{
    public partial class Producto
    {
        public Producto()
        {
            DetalleEntrada = new HashSet<DetalleEntrada>();
            DetalleVenta = new HashSet<DetalleVenta>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Codigo { get; set; }
        public decimal Existencias { get; set; }
        public decimal Precio { get; set; }
        public decimal Costo { get; set; }
        public int Estatus { get; set; }
        public int Tipo { get; set; }
        public int IdProveedor { get; set; }

        public virtual CProductoEstado EstatusNavigation { get; set; }
        public virtual Proveedore IdProveedorNavigation { get; set; }
        public virtual CProductoTipo TipoNavigation { get; set; }
        public virtual ICollection<DetalleEntrada> DetalleEntrada { get; set; }
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
    }
}
