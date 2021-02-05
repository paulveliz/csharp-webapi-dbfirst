using System;
using System.Collections.Generic;

#nullable disable

namespace dbfirst.Models
{
    public partial class AumentosDeuda
    {
        public int Id { get; set; }
        public decimal Importe { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public int IdDeuda { get; set; }
        public int Estatus { get; set; }

        public virtual Deuda IdDeudaNavigation { get; set; }
    }
}
