using System;
using System.Collections.Generic;

#nullable disable

namespace dbfirst.Models
{
    public partial class CEntradaEstado
    {
        public CEntradaEstado()
        {
            Entrada = new HashSet<Entrada>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Entrada> Entrada { get; set; }
    }
}
