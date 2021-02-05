using System;
using System.Collections.Generic;

#nullable disable

namespace dbfirst.Models
{
    public partial class Venta
    {
        public Venta()
        {
            DetalleVenta = new HashSet<DetalleVenta>();
            Deuda = new HashSet<Deuda>();
        }

        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public decimal Descuento { get; set; }
        public decimal PrecioEntrega { get; set; }
        public decimal CostosExtra { get; set; }
        public string Comentario { get; set; }
        public int Tipo { get; set; }
        public int Estatus { get; set; }

        public virtual CEstadoVentum EstatusNavigation { get; set; }
        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Empleado IdEmpleadoNavigation { get; set; }
        public virtual CTipoVentum TipoNavigation { get; set; }
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
        public virtual ICollection<Deuda> Deuda { get; set; }
    }
}
