using System;
using System.Collections.Generic;

#nullable disable

namespace dbfirst.Models
{
    public partial class CAbonoEstado
    {
        public CAbonoEstado()
        {
            Abonos = new HashSet<Abono>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Abono> Abonos { get; set; }
    }
}
