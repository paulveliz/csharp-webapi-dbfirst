using System;
using System.Collections.Generic;

#nullable disable

namespace dbfirst.Models
{
    public partial class Proveedore
    {
        public Proveedore()
        {
            Entrada = new HashSet<Entrada>();
            Productos = new HashSet<Producto>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Estatus { get; set; }

        public virtual CProveedorEstado EstatusNavigation { get; set; }
        public virtual ICollection<Entrada> Entrada { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
