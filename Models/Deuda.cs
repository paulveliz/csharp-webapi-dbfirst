using System;
using System.Collections.Generic;

#nullable disable

namespace dbfirst.Models
{
    public partial class Deuda
    {
        public Deuda()
        {
            Abonos = new HashSet<Abono>();
            AumentosDeuda = new HashSet<AumentosDeuda>();
        }

        public int Id { get; set; }
        public decimal Importe { get; set; }
        public int IdVenta { get; set; }
        public int Estatus { get; set; }

        public virtual CDeudaEstado EstatusNavigation { get; set; }
        public virtual Venta IdVentaNavigation { get; set; }
        public virtual ICollection<Abono> Abonos { get; set; }
        public virtual ICollection<AumentosDeuda> AumentosDeuda { get; set; }
    }
}
