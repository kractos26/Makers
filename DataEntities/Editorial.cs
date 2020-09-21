using System;
using System.Collections.Generic;

namespace DataEntities
{
    public partial class Editorial
    {
        public Editorial()
        {
            Libro = new HashSet<Libro>();
        }

        public int IdEditorial { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Libro> Libro { get; set; }
    }
}
