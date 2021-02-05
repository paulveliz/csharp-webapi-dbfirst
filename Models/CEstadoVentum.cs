using System;
using System.Collections.Generic;

#nullable disable

namespace dbfirst.Models
{
    public partial class CEstadoVentum
    {
        public CEstadoVentum()
        {
            Venta = new HashSet<Venta>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Venta> Venta { get; set; }
    }
}
