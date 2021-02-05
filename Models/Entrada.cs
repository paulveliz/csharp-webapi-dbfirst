using System;
using System.Collections.Generic;

#nullable disable

namespace dbfirst.Models
{
    public partial class Entrada
    {
        public Entrada()
        {
            DetalleEntrada = new HashSet<DetalleEntrada>();
        }

        public int Id { get; set; }
        public int IdEmpleado { get; set; }
        public int IdProveedor { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public decimal Importe { get; set; }
        public int Estatus { get; set; }

        public virtual CEntradaEstado EstatusNavigation { get; set; }
        public virtual Empleado IdEmpleadoNavigation { get; set; }
        public virtual Proveedore IdProveedorNavigation { get; set; }
        public virtual ICollection<DetalleEntrada> DetalleEntrada { get; set; }
    }
}
