using System;
using System.Collections.Generic;

#nullable disable

namespace dbfirst.Models
{
    public partial class CDeudaEstado
    {
        public CDeudaEstado()
        {
            Deuda = new HashSet<Deuda>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Deuda> Deuda { get; set; }
    }
}
