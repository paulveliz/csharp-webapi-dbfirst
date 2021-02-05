using System;
using System.Collections.Generic;

#nullable disable

namespace dbfirst.Models
{
    public partial class CProveedorEstado
    {
        public CProveedorEstado()
        {
            Proveedores = new HashSet<Proveedore>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Proveedore> Proveedores { get; set; }
    }
}
