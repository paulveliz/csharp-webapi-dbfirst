using System;
using System.Collections.Generic;

#nullable disable

namespace dbfirst.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Venta = new HashSet<Venta>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int Estatus { get; set; }

        public virtual CEstadoCliente EstatusNavigation { get; set; }
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
