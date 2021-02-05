using System;
using System.Collections.Generic;

#nullable disable

namespace dbfirst.Models
{
    public partial class Empleado
    {
        public Empleado()
        {
            Entrada = new HashSet<Entrada>();
            Venta = new HashSet<Venta>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; }
        public int Estatus { get; set; }

        public virtual CEstadoCliente EstatusNavigation { get; set; }
        public virtual ICollection<Entrada> Entrada { get; set; }
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
