using System;
using System.Collections.Generic;

#nullable disable

namespace dbfirst.Models
{
    public partial class Abono
    {
        public int Id { get; set; }
        public int IdDeuda { get; set; }
        public decimal Importe { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Comentario { get; set; }
        public int Estatus { get; set; }

        public virtual CAbonoEstado EstatusNavigation { get; set; }
        public virtual Deuda IdDeudaNavigation { get; set; }
    }
}
