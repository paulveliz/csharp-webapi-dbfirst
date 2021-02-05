using System;
using System.Collections.Generic;

#nullable disable

namespace dbfirst.Models
{
    public partial class CProductoEstado
    {
        public CProductoEstado()
        {
            Productos = new HashSet<Producto>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
