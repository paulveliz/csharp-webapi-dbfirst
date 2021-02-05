using System;
using System.Collections.Generic;

#nullable disable

namespace dbfirst.Models
{
    public partial class CEstadoCliente
    {
        public CEstadoCliente()
        {
            Clientes = new HashSet<Cliente>();
            Empleados = new HashSet<Empleado>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
