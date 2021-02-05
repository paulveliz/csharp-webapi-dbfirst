using System;
using System.Collections.Generic;

#nullable disable

namespace dbfirst.Models
{
    public partial class DetalleEntrada
    {
        public int Id { get; set; }
        public int IdEntrada { get; set; }
        public int IdProducto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Costo { get; set; }
        public decimal Importe { get; set; }

        public virtual Entrada IdEntradaNavigation { get; set; }
        public virtual Producto IdProductoNavigation { get; set; }
    }
}
